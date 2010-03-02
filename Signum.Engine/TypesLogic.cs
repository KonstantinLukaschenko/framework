﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Signum.Entities;
using Signum.Engine.Maps;
using Signum.Entities.Reflection;
using Signum.Engine.Properties;
using Signum.Utilities;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Signum.Engine
{
    public static class TypeLogic
    {
        static Dictionary<Type, TypeDN> typeToDN; 
        public static Dictionary<Type, TypeDN> TypeToDN 
        {
            get { return typeToDN.ThrowIfNullC(Resources.TypeDNTableNotCached); }
            set { typeToDN = value; }
        }

        static Dictionary<TypeDN, Type> dnToType; 
        public static Dictionary<TypeDN, Type> DnToType
        {
            get { return dnToType.ThrowIfNullC(Resources.TypeDNTableNotCached); }
            set { dnToType = value;  }
        }

        public static void Start(SchemaBuilder sb)
        {
            if (sb.NotDefined(MethodInfo.GetCurrentMethod()))
            {
                sb.Include<TypeDN>();

                sb.Schema.Synchronizing += Schema_Synchronizing;
                sb.Schema.Generating += Schema_Generating;
                sb.Schema.Initializing(InitLevel.Level0SyncEntities, Schema_Initializing);
            }
        }

        static void Schema_Initializing(Schema sender)
        {
            List<TypeDN> types = Administrator.UnsafeRetrieveAll<TypeDN>();

            var dict = EnumerableExtensions.JoinStrict(
                types, sender.Tables.Keys, t => t.FullClassName, t => (Reflector.ExtractEnumProxy(t) ?? t).FullName,
                (typeDN, type) => new { typeDN, type },
                Resources.CachingTypesTableFrom0.Formato(sender.Table(typeof(TypeDN)).Name)
                ).ToDictionary(a => a.type, a => a.typeDN);

            sender.IDsForType = dict.SelectDictionary(k => k, v => v.Id);
            sender.TablesForID = sender.IDsForType.ToDictionary(p => p.Value, p => sender.Table(p.Key));

            typeToDN = dict;
            dnToType = typeToDN.Inverse();
        }

        public static Dictionary<TypeDN, Type> TryDNToType(Replacements replacements)
        {
            return (from dn in Administrator.TryRetrieveAll<TypeDN>(replacements)
                    join t in Schema.Current.Tables.Keys on dn.FullClassName equals (Reflector.ExtractEnumProxy(t) ?? t).Name
                    select new { dn, t }).ToDictionary(a => a.dn, a => a.t);
        }

        public static SqlPreCommand Schema_Synchronizing(Replacements replacements)
        {
            Table table = Schema.Current.Table<TypeDN>();

            Dictionary<string, TypeDN> should = GenerateSchemaTypes().ToDictionary(s => s.TableName);
            Dictionary<string, TypeDN> current = replacements.ApplyReplacements(
                Administrator.TryRetrieveAll<TypeDN>(replacements).ToDictionary(c => c.TableName), Replacements.KeyTables);

            return Synchronizer.SynchronizeScript(
                current,
                should,
                (tn, c) => table.DeleteSqlSync(c),
                (tn, s) => table.InsertSqlSync(s),
                (tn, c, s) =>
                {
                    c.FullClassName = s.FullClassName;
                    c.TableName = s.TableName;
                    c.FriendlyName = s.FriendlyName;
                    return table.UpdateSqlSync(c);
                }, Spacing.Double);
        }

        public static SqlPreCommand Schema_Generating()
        {
            Table table = Schema.Current.Table<TypeDN>();

            return (from ei in GenerateSchemaTypes()
                    select table.InsertSqlSync(ei)).Combine(Spacing.Simple);
        }

        public static List<TypeDN> GenerateSchemaTypes()
        {
            var lista = (from tab in Schema.Current.Tables.Values
                         let type = Reflector.ExtractEnumProxy(tab.Type) ?? tab.Type
                         select new TypeDN
                         {
                             FullClassName = type.FullName,
                             TableName = tab.Name,
                             FriendlyName = type.NiceName()
                         }).ToList();
            return lista;
        }

        public static List<Lite<TypeDN>> TypesAssignableFrom(Type type)
        {
            return TypeToDN.Where(a => type.IsAssignableFrom(a.Key)).Select(a => a.Value.ToLite()).ToList();
        }


        public static string TryParseLite(Type liteType, string liteKey, out Lite lite)
        {
            string error = Lite.TryParseLite(liteType, liteKey, TryGetType, out lite);
            if (error != null)
                return error;

            lite = Database.RetrieveLite(liteType, lite.RuntimeType, lite.Id);
            return null;
        }

        public static Lite ParseLite(Type liteType, string liteKey)
        {
            Lite lite = Lite.ParseLite(liteType, liteKey, TryGetType);

            return Database.RetrieveLite(liteType, lite.RuntimeType, lite.Id);
        }

        private static Type GetType(string typeName)
        {
            return typeToDN.Keys.Where(t => t.Name == typeName).Single("Type {0} not found in the Schema".Formato(typeName));
        }

        private static Type TryGetType(string typeName)
        {
            return typeToDN.Keys.Where(t => t.Name == typeName).SingleOrDefault();
        }
    }
}
