﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Signum.Web.Views
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 3 "..\..\Signum\Views\FilterBuilder.cshtml"
    using Signum.Engine.DynamicQuery;
    
    #line default
    #line hidden
    using Signum.Entities;
    
    #line 1 "..\..\Signum\Views\FilterBuilder.cshtml"
    using Signum.Entities.DynamicQuery;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Signum\Views\FilterBuilder.cshtml"
    using Signum.Entities.Reflection;
    
    #line default
    #line hidden
    using Signum.Utilities;
    using Signum.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Signum/Views/FilterBuilder.cshtml")]
    public partial class FilterBuilder : System.Web.Mvc.WebViewPage<Context>
    {
        public FilterBuilder()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Signum\Views\FilterBuilder.cshtml"
   
    List<FilterOption> filterOptions = (List<FilterOption>)ViewData[ViewDataKeys.FilterOptions];
    QueryDescription queryDescription = (QueryDescription)ViewData[ViewDataKeys.QueryDescription];
    bool filtersVisible = (bool?)ViewData[ViewDataKeys.FiltersVisible] ?? true;
    bool showAddColumn = (bool?)ViewData[ViewDataKeys.ShowAddColumn] ?? false;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\r\n<div");

WriteAttribute("id", Tuple.Create(" id=\"", 498), Tuple.Create("\"", 537)
            
            #line 13 "..\..\Signum\Views\FilterBuilder.cshtml"
, Tuple.Create(Tuple.Create("", 503), Tuple.Create<System.Object, System.Int32>(Model.Compose("tblFilterBuilder")
            
            #line default
            #line hidden
, 503), false)
);

WriteLiteral(" class=\"panel panel-default sf-filters form-xs\"");

WriteLiteral(" ");

            
            #line 13 "..\..\Signum\Views\FilterBuilder.cshtml"
                                                                                        Write(filtersVisible ? "" : "style=display:none");

            
            #line default
            #line hidden
WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"panel-heading sf-filters-body\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 15 "..\..\Signum\Views\FilterBuilder.cshtml"
   Write(Html.QueryTokenBuilder(null, new Context(Model, "tokenBuilder"), (QueryTokenBuilderSettings)ViewData[ViewDataKeys.QueryTokenSettings] ?? 
        SearchControlHelper.GetQueryTokenBuilderSettings(queryDescription, SubTokensOptions.CanAnyAll | SubTokensOptions.CanElement)));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n        <div");

WriteLiteral(" class=\"btn-group\"");

WriteLiteral(">\r\n            <a");

WriteAttribute("id", Tuple.Create(" id=\"", 1015), Tuple.Create("\"", 1050)
            
            #line 19 "..\..\Signum\Views\FilterBuilder.cshtml"
, Tuple.Create(Tuple.Create("", 1020), Tuple.Create<System.Object, System.Int32>(Model.Compose("btnAddFilter")
            
            #line default
            #line hidden
, 1020), false)
);

WriteLiteral(" class=\"sf-query-button sf-add-filter btn btn-default btn-sm\"");

WriteAttribute("title", Tuple.Create(" title=\"", 1112), Tuple.Create("\"", 1159)
            
            #line 19 "..\..\Signum\Views\FilterBuilder.cshtml"
                                       , Tuple.Create(Tuple.Create("", 1120), Tuple.Create<System.Object, System.Int32>(SearchMessage.AddFilter.NiceToString()
            
            #line default
            #line hidden
, 1120), false)
);

WriteLiteral(">\r\n                <span");

WriteLiteral(" class=\"glyphicon glyphicon-arrow-down\"");

WriteLiteral("></span>\r\n");

WriteLiteral("                ");

            
            #line 21 "..\..\Signum\Views\FilterBuilder.cshtml"
           Write(SearchMessage.AddFilter.NiceToString());

            
            #line default
            #line hidden
WriteLiteral("\r\n            </a>\r\n        </div>\r\n\r\n");

            
            #line 25 "..\..\Signum\Views\FilterBuilder.cshtml"
        
            
            #line default
            #line hidden
            
            #line 25 "..\..\Signum\Views\FilterBuilder.cshtml"
         if (showAddColumn)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"btn-group\"");

WriteLiteral(">\r\n                <a");

WriteAttribute("id", Tuple.Create(" id=\"", 1421), Tuple.Create("\"", 1456)
            
            #line 28 "..\..\Signum\Views\FilterBuilder.cshtml"
, Tuple.Create(Tuple.Create("", 1426), Tuple.Create<System.Object, System.Int32>(Model.Compose("btnAddColumn")
            
            #line default
            #line hidden
, 1426), false)
);

WriteLiteral(" class=\"sf-query-button sf-add-column btn btn-default btn-sm\"");

WriteAttribute("title", Tuple.Create(" title=\"", 1518), Tuple.Create("\"", 1565)
            
            #line 28 "..\..\Signum\Views\FilterBuilder.cshtml"
                                           , Tuple.Create(Tuple.Create("", 1526), Tuple.Create<System.Object, System.Int32>(SearchMessage.AddColumn.NiceToString()
            
            #line default
            #line hidden
, 1526), false)
);

WriteLiteral(">\r\n                    <span");

WriteLiteral(" class=\"glyphicon glyphicon-arrow-right\"");

WriteLiteral("></span>\r\n");

WriteLiteral("                    ");

            
            #line 30 "..\..\Signum\Views\FilterBuilder.cshtml"
               Write(SearchMessage.AddColumn.NiceToString());

            
            #line default
            #line hidden
WriteLiteral("\r\n                </a>\r\n            </div>\r\n");

            
            #line 33 "..\..\Signum\Views\FilterBuilder.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"panel-body sf-filters-list table-responsive\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"sf-explanation\"");

WriteAttribute("style", Tuple.Create(" style=\"", 1870), Tuple.Create("\"", 1955)
            
            #line 37 "..\..\Signum\Views\FilterBuilder.cshtml"
, Tuple.Create(Tuple.Create("", 1878), Tuple.Create<System.Object, System.Int32>((filterOptions == null || filterOptions.Count == 0) ? "" : "display:none;"
            
            #line default
            #line hidden
, 1878), false)
);

WriteLiteral(">");

            
            #line 37 "..\..\Signum\Views\FilterBuilder.cshtml"
                                                                                                                     Write(SearchMessage.NoFiltersSpecified.NiceToString());

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        <table");

WriteAttribute("id", Tuple.Create(" id=\"", 2027), Tuple.Create("\"", 2060)
            
            #line 38 "..\..\Signum\Views\FilterBuilder.cshtml"
, Tuple.Create(Tuple.Create("", 2032), Tuple.Create<System.Object, System.Int32>(Model.Compose("tblFilters")
            
            #line default
            #line hidden
, 2032), false)
);

WriteAttribute("style", Tuple.Create(" style=\"", 2061), Tuple.Create("\"", 2147)
            
            #line 38 "..\..\Signum\Views\FilterBuilder.cshtml"
, Tuple.Create(Tuple.Create("", 2069), Tuple.Create<System.Object, System.Int32>((filterOptions == null || filterOptions.Count == 0) ? "display:none" : null
            
            #line default
            #line hidden
, 2069), false)
);

WriteLiteral(" class=\"table\"");

WriteLiteral(">\r\n            <thead>\r\n                <tr>\r\n                    <th></th>\r\n    " +
"                <th");

WriteLiteral(" class=\"sf-filter-field-header\"");

WriteLiteral(">");

            
            #line 42 "..\..\Signum\Views\FilterBuilder.cshtml"
                                                  Write(SearchMessage.Field.NiceToString());

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </th>\r\n                    <th>");

            
            #line 44 "..\..\Signum\Views\FilterBuilder.cshtml"
                   Write(SearchMessage.Operation.NiceToString());

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </th>\r\n                    <th>");

            
            #line 46 "..\..\Signum\Views\FilterBuilder.cshtml"
                   Write(SearchMessage.Value.NiceToString());

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n       " +
"     <tbody>\r\n");

            
            #line 51 "..\..\Signum\Views\FilterBuilder.cshtml"
                
            
            #line default
            #line hidden
            
            #line 51 "..\..\Signum\Views\FilterBuilder.cshtml"
                 for (int i = 0; i < filterOptions.Count; i++)
                {
                    FilterOption filter = filterOptions[i];
                    
            
            #line default
            #line hidden
            
            #line 54 "..\..\Signum\Views\FilterBuilder.cshtml"
               Write(Html.NewFilter(queryDescription.QueryName, filter, Model, i));

            
            #line default
            #line hidden
            
            #line 54 "..\..\Signum\Views\FilterBuilder.cshtml"
                                                                                 
                }

            
            #line default
            #line hidden
WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
