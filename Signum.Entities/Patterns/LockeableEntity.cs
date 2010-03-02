﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Signum.Entities.Properties;
using System.Linq.Expressions;
using System.ComponentModel;
using Signum.Utilities;

namespace Signum.Entities.Patterns
{
    [Serializable]
    public abstract class LockeableEntity : Entity
    {
        bool locked;
        public bool Locked
        {
            get { return locked; }
            set
            {
                if (UnsafeSet(ref locked, value, () => Locked))
                    ItemLockedChanged(Locked);
            }
        }

        protected bool UnsafeSet<T>(ref T variable, T value, Expression<Func<T>> property)
        { 
            return base.Set<T>(ref variable, value, property);
        }

        protected virtual void ItemLockedChanged(bool locked)
        {
        }

        protected override bool Set<T>(ref T variable, T value, Expression<Func<T>> property)
        {
            if (EqualityComparer<T>.Default.Equals(variable, value))
                return false;

            if (this.locked)
                throw new ApplicationException(Resources.LockedModificationException + " "+ this.ToString());
            
            return base.Set<T>(ref variable, value, property);
        }

        protected internal override void PreSaving(ref bool graphModified)
        {
            UnsafeSet(ref toStr, ToString(), () => ToStr);
        }
    }
}
