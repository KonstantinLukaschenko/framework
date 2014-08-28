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
    
    #line 3 "..\..\Signum\Views\SearchControl.cshtml"
    using System.Configuration;
    
    #line default
    #line hidden
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
    
    #line 5 "..\..\Signum\Views\SearchControl.cshtml"
    using Newtonsoft.Json;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Signum\Views\SearchControl.cshtml"
    using Signum.Engine.DynamicQuery;
    
    #line default
    #line hidden
    using Signum.Entities;
    
    #line 1 "..\..\Signum\Views\SearchControl.cshtml"
    using Signum.Entities.DynamicQuery;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Signum\Views\SearchControl.cshtml"
    using Signum.Entities.Reflection;
    
    #line default
    #line hidden
    using Signum.Utilities;
    using Signum.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Signum/Views/SearchControl.cshtml")]
    public partial class SearchControl : System.Web.Mvc.WebViewPage<Context>
    {
        public SearchControl()
        {
        }
        public override void Execute()
        {
            
            #line 7 "..\..\Signum\Views\SearchControl.cshtml"
   
    Model.ReadOnly = false; /*SearchControls Context should never inherit Readonly property of parent context */
    FindOptions findOptions = (FindOptions)ViewData[ViewDataKeys.FindOptions];
    QueryDescription queryDescription = (QueryDescription)ViewData[ViewDataKeys.QueryDescription];
    var entityColumn = queryDescription.Columns.SingleEx(a => a.IsEntity);
    Type entitiesType = Lite.Extract(entityColumn.Type);
    Implementations implementations = entityColumn.Implementations.Value;
    findOptions.Pagination = findOptions.Pagination ?? (Navigator.Manager.QuerySettings.GetOrThrow(findOptions.QueryName, "Missing QuerySettings for QueryName {0}").Pagination) ?? FindOptions.DefaultPagination;

    ViewData[ViewDataKeys.FindOptions] = findOptions;

    var prefix = Model.Compose("sfSearchControl");

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteAttribute("id", Tuple.Create(" id=\"", 1014), Tuple.Create("\"", 1026)
            
            #line 20 "..\..\Signum\Views\SearchControl.cshtml"
, Tuple.Create(Tuple.Create("", 1019), Tuple.Create<System.Object, System.Int32>(prefix
            
            #line default
            #line hidden
, 1019), false)
);

WriteLiteral(" \r\n     class=\"sf-search-control SF-control-container\"");

WriteLiteral(" \r\n     data-prefix=\"");

            
            #line 22 "..\..\Signum\Views\SearchControl.cshtml"
             Write(Model.Prefix);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" \r\n     data-find-url=\"");

            
            #line 23 "..\..\Signum\Views\SearchControl.cshtml"
               Write(Navigator.FindRoute(findOptions.QueryName));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" \r\n     data-queryName=\"");

            
            #line 24 "..\..\Signum\Views\SearchControl.cshtml"
                Write(QueryUtils.GetQueryUniqueKey(findOptions.QueryName));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" \r\n     >\r\n\r\n");

            
            #line 27 "..\..\Signum\Views\SearchControl.cshtml"
    
            
            #line default
            #line hidden
            
            #line 27 "..\..\Signum\Views\SearchControl.cshtml"
      
        bool filtersAlwaysHidden = !findOptions.ShowHeader || !findOptions.ShowFilters && !findOptions.ShowFilterButton;
    
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <div");

WriteAttribute("style", Tuple.Create(" style=\"", 1420), Tuple.Create("\"", 1477)
, Tuple.Create(Tuple.Create("", 1428), Tuple.Create("display:", 1428), true)
            
            #line 31 "..\..\Signum\Views\SearchControl.cshtml"
, Tuple.Create(Tuple.Create("", 1436), Tuple.Create<System.Object, System.Int32>(filtersAlwaysHidden ? "none" : "block"
            
            #line default
            #line hidden
, 1436), false)
);

WriteLiteral(">\r\n");

            
            #line 32 "..\..\Signum\Views\SearchControl.cshtml"
        
            
            #line default
            #line hidden
            
            #line 32 "..\..\Signum\Views\SearchControl.cshtml"
          
            ViewData[ViewDataKeys.FilterOptions] = findOptions.FilterOptions;
            ViewData[ViewDataKeys.FiltersVisible] = findOptions.ShowFilters;
            ViewData[ViewDataKeys.ShowAddColumn] = string.IsNullOrEmpty(Model.Prefix) && findOptions.AllowChangeColumns;
            Html.RenderPartial(Navigator.Manager.FilterBuilderView); 
        
            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n\r\n\r\n\r\n\r\n    <div");

WriteLiteral(" class=\"sf-query-button-bar\"");

WriteAttribute("style", Tuple.Create(" style=\"", 1910), Tuple.Create("\"", 1967)
            
            #line 43 "..\..\Signum\Views\SearchControl.cshtml"
, Tuple.Create(Tuple.Create("", 1918), Tuple.Create<System.Object, System.Int32>(findOptions.ShowHeader ? null : "display:none"
            
            #line default
            #line hidden
, 1918), false)
);

WriteLiteral(">\r\n");

            
            #line 44 "..\..\Signum\Views\SearchControl.cshtml"
        
            
            #line default
            #line hidden
            
            #line 44 "..\..\Signum\Views\SearchControl.cshtml"
         if (!filtersAlwaysHidden)
        {

            
            #line default
            #line hidden
WriteLiteral("            <a");

WriteAttribute("class", Tuple.Create("  class=\"", 2032), Tuple.Create("\"", 2133)
, Tuple.Create(Tuple.Create("", 2041), Tuple.Create("sf-query-button", 2041), true)
, Tuple.Create(Tuple.Create(" ", 2056), Tuple.Create("sf-filters-header", 2057), true)
, Tuple.Create(Tuple.Create(" ", 2074), Tuple.Create("btn", 2075), true)
, Tuple.Create(Tuple.Create(" ", 2078), Tuple.Create("btn-default", 2079), true)
            
            #line 46 "..\..\Signum\Views\SearchControl.cshtml"
, Tuple.Create(Tuple.Create(" ", 2090), Tuple.Create<System.Object, System.Int32>(findOptions.ShowFilters ? "active" : ""
            
            #line default
            #line hidden
, 2091), false)
);

WriteAttribute("onclick", Tuple.Create("\r\n            onclick=\"", 2134), Tuple.Create("\"", 2209)
            
            #line 47 "..\..\Signum\Views\SearchControl.cshtml"
, Tuple.Create(Tuple.Create("", 2157), Tuple.Create<System.Object, System.Int32>(JsFunction.SFControlThen(prefix, "toggleFilters()")
            
            #line default
            #line hidden
, 2157), false)
);

WriteAttribute("title", Tuple.Create("\r\n            title=\"", 2210), Tuple.Create("\"", 2351)
            
            #line 48 "..\..\Signum\Views\SearchControl.cshtml"
, Tuple.Create(Tuple.Create("", 2231), Tuple.Create<System.Object, System.Int32>(findOptions.ShowFilters ? JavascriptMessage.hideFilters.NiceToString() : JavascriptMessage.showFilters.NiceToString()
            
            #line default
            #line hidden
, 2231), false)
);

WriteLiteral(">\r\n                <span");

WriteLiteral(" class=\"glyphicon glyphicon glyphicon-filter\"");

WriteLiteral("></span>\r\n            </a>\r\n");

            
            #line 51 "..\..\Signum\Views\SearchControl.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"sf-query-button sf-search btn btn-primary\"");

WriteAttribute("id", Tuple.Create(" id=\"", 2539), Tuple.Create("\"", 2570)
            
            #line 52 "..\..\Signum\Views\SearchControl.cshtml"
    , Tuple.Create(Tuple.Create("", 2544), Tuple.Create<System.Object, System.Int32>(Model.Compose("qbSearch")
            
            #line default
            #line hidden
, 2544), false)
);

WriteLiteral(">");

            
            #line 52 "..\..\Signum\Views\SearchControl.cshtml"
                                                                                                           Write(SearchMessage.Search.NiceToString());

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n        <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n            $(\"#");

            
            #line 54 "..\..\Signum\Views\SearchControl.cshtml"
           Write(Model.Compose("qbSearch"));

            
            #line default
            #line hidden
WriteLiteral("\").click(function(e){ $(\"#");

            
            #line 54 "..\..\Signum\Views\SearchControl.cshtml"
                                                               Write(Model.Compose("sfSearchControl"));

            
            #line default
            #line hidden
WriteLiteral("\").SFControl().then(function(c){c.search();}) });\r\n            $(\"#");

            
            #line 55 "..\..\Signum\Views\SearchControl.cshtml"
           Write(Model.Compose("tblFilterBuilder"));

            
            #line default
            #line hidden
WriteLiteral("\").keyup(function(e){ if (e.which == 13) { $(\"#");

            
            #line 55 "..\..\Signum\Views\SearchControl.cshtml"
                                                                                            Write(Model.Compose("qbSearch"));

            
            #line default
            #line hidden
WriteLiteral("\").click(); } });\r\n        </script>\r\n\r\n");

            
            #line 58 "..\..\Signum\Views\SearchControl.cshtml"
        
            
            #line default
            #line hidden
            
            #line 58 "..\..\Signum\Views\SearchControl.cshtml"
         if (findOptions.Create)
        {

            
            #line default
            #line hidden
WriteLiteral("            <a");

WriteLiteral(" class=\"sf-query-button btn btn-default sf-line-button sf-create\"");

WriteAttribute("id", Tuple.Create(" id=\"", 3099), Tuple.Create("\"", 3136)
            
            #line 60 "..\..\Signum\Views\SearchControl.cshtml"
    , Tuple.Create(Tuple.Create("", 3104), Tuple.Create<System.Object, System.Int32>(Model.Compose("qbSearchCreate")
            
            #line default
            #line hidden
, 3104), false)
);

WriteAttribute("title", Tuple.Create(" title=\"", 3137), Tuple.Create("\"", 3265)
            
            #line 60 "..\..\Signum\Views\SearchControl.cshtml"
                                             , Tuple.Create(Tuple.Create("", 3145), Tuple.Create<System.Object, System.Int32>(SearchMessage.CreateNew0.NiceToString(implementations.IsByAll ? "?" : implementations.Types.CommaOr(a => a.NiceName()))
            
            #line default
            #line hidden
, 3145), false)
);

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 3266), Tuple.Create("\"", 3327)
            
            #line 60 "..\..\Signum\Views\SearchControl.cshtml"
                                                                                                                                                                                , Tuple.Create(Tuple.Create("", 3276), Tuple.Create<System.Object, System.Int32>(JsFunction.SFControlThen(prefix, "create_click()")
            
            #line default
            #line hidden
, 3276), false)
);

WriteLiteral(">\r\n                <span");

WriteLiteral(" class=\"glyphicon glyphicon-plus\"");

WriteLiteral("></span>\r\n            </a>\r\n");

            
            #line 63 "..\..\Signum\Views\SearchControl.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 65 "..\..\Signum\Views\SearchControl.cshtml"
        
            
            #line default
            #line hidden
            
            #line 65 "..\..\Signum\Views\SearchControl.cshtml"
         if (findOptions.ShowContextMenu)
        {


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"btn-group\"");

WriteLiteral(">\r\n                <button");

WriteLiteral(" class=\"sf-query-button sf-tm-selected btn btn-default dropdown-toggle\"");

WriteLiteral(" data-toggle=\"dropdown\"");

WriteAttribute("id", Tuple.Create(" id=\"", 3636), Tuple.Create("\"", 3670)
            
            #line 69 "..\..\Signum\Views\SearchControl.cshtml"
                                          , Tuple.Create(Tuple.Create("", 3641), Tuple.Create<System.Object, System.Int32>(Model.Compose("btnSelected")
            
            #line default
            #line hidden
, 3641), false)
);

WriteLiteral(" disabled=\"disabled\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 70 "..\..\Signum\Views\SearchControl.cshtml"
               Write(JavascriptMessage.Selected);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    (<span");

WriteAttribute("id", Tuple.Create(" id=\"", 3769), Tuple.Create("\"", 3807)
            
            #line 71 "..\..\Signum\Views\SearchControl.cshtml"
, Tuple.Create(Tuple.Create("", 3774), Tuple.Create<System.Object, System.Int32>(Model.Compose("btnSelectedSpan")
            
            #line default
            #line hidden
, 3774), false)
);

WriteLiteral(">0</span>)\r\n                <span");

WriteLiteral(" class=\"caret\"");

WriteLiteral("></span>\r\n                </button>\r\n                <ul");

WriteLiteral(" class=\"dropdown-menu\"");

WriteAttribute("id", Tuple.Create(" id=\"", 3933), Tuple.Create("\"", 3975)
            
            #line 74 "..\..\Signum\Views\SearchControl.cshtml"
, Tuple.Create(Tuple.Create("", 3938), Tuple.Create<System.Object, System.Int32>(Model.Compose("btnSelectedDropDown")
            
            #line default
            #line hidden
, 3938), false)
);

WriteLiteral(">\r\n                    <li>hi there!</li>\r\n                </ul>\r\n            </d" +
"iv>\r\n");

            
            #line 78 "..\..\Signum\Views\SearchControl.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 80 "..\..\Signum\Views\SearchControl.cshtml"
   Write(ButtonBarQueryHelper.GetButtonBarElementsForQuery(new QueryButtonContext
       {
           Url = Url,
           ControllerContext = this.ViewContext,
           QueryName = findOptions.QueryName,
           ManualQueryButtons = (ToolBarButton[])ViewData[ViewDataKeys.ManualToolbarButtons],
           EntityType = entitiesType,
           Prefix = Model.Prefix
       }).ToStringButton(Html));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 90 "..\..\Signum\Views\SearchControl.cshtml"
        
            
            #line default
            #line hidden
            
            #line 90 "..\..\Signum\Views\SearchControl.cshtml"
         if ((bool?)ViewData[ViewDataKeys.AvoidFullScreenButton] != true)
        { 

            
            #line default
            #line hidden
WriteLiteral("             <a");

WriteAttribute("id", Tuple.Create(" id=\"", 4592), Tuple.Create("\"", 4627)
            
            #line 92 "..\..\Signum\Views\SearchControl.cshtml"
, Tuple.Create(Tuple.Create("", 4597), Tuple.Create<System.Object, System.Int32>(Model.Compose("sfFullScreen")
            
            #line default
            #line hidden
, 4597), false)
);

WriteLiteral(" class=\"sf-query-button btn btn-default\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" class=\"glyphicon glyphicon-new-window\"");

WriteLiteral("></span>\r\n            </a>\r\n");

            
            #line 95 "..\..\Signum\Views\SearchControl.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div");

WriteAttribute("id", Tuple.Create(" id=\"", 4801), Tuple.Create("\"", 4834)
            
            #line 98 "..\..\Signum\Views\SearchControl.cshtml"
, Tuple.Create(Tuple.Create("", 4806), Tuple.Create<System.Object, System.Int32>(Model.Compose("divResults")
            
            #line default
            #line hidden
, 4806), false)
);

WriteLiteral(" class=\"sf-search-results-container table-responsive\"");

WriteLiteral(">\r\n        <table");

WriteAttribute("id", Tuple.Create(" id=\"", 4905), Tuple.Create("\"", 4938)
            
            #line 99 "..\..\Signum\Views\SearchControl.cshtml"
, Tuple.Create(Tuple.Create("", 4910), Tuple.Create<System.Object, System.Int32>(Model.Compose("tblResults")
            
            #line default
            #line hidden
, 4910), false)
);

WriteLiteral(" class=\"sf-search-results  table table-hover  table-condensed\"");

WriteLiteral(">\r\n            <thead>\r\n                <tr>\r\n");

            
            #line 102 "..\..\Signum\Views\SearchControl.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 102 "..\..\Signum\Views\SearchControl.cshtml"
                     if (findOptions.AllowSelection)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <th");

WriteLiteral(" class=\"sf-th-selection\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 105 "..\..\Signum\Views\SearchControl.cshtml"
                       Write(Html.CheckBox(Model.Compose("cbSelectAll"), false, new { onclick = JsFunction.SFControlThen(prefix, "toggleSelectAll()") }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </th>\r\n");

            
            #line 107 "..\..\Signum\Views\SearchControl.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    ");

            
            #line 108 "..\..\Signum\Views\SearchControl.cshtml"
                     if (findOptions.Navigate)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <th");

WriteLiteral(" class=\"sf-th-entity\"");

WriteLiteral("></th>\r\n");

            
            #line 111 "..\..\Signum\Views\SearchControl.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    ");

            
            #line 112 "..\..\Signum\Views\SearchControl.cshtml"
                      List<Column> columns = findOptions.MergeColumns(); 
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 113 "..\..\Signum\Views\SearchControl.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 113 "..\..\Signum\Views\SearchControl.cshtml"
                     foreach (var col in columns)
                    {
                        var order = findOptions.OrderOptions.FirstOrDefault(oo => oo.Token.FullKey() == col.Name);
                        OrderType? orderType = null;
                        if (order != null)
                        {
                            orderType = order.OrderType;
                        }
                        
            
            #line default
            #line hidden
            
            #line 121 "..\..\Signum\Views\SearchControl.cshtml"
                   Write(SearchControlHelper.Header(col, orderType));

            
            #line default
            #line hidden
            
            #line 121 "..\..\Signum\Views\SearchControl.cshtml"
                                                                   
                    }

            
            #line default
            #line hidden
WriteLiteral("                </tr>\r\n            </thead>\r\n            <tbody>\r\n");

            
            #line 126 "..\..\Signum\Views\SearchControl.cshtml"
                
            
            #line default
            #line hidden
            
            #line 126 "..\..\Signum\Views\SearchControl.cshtml"
                   int columnsCount = columns.Count + (findOptions.Navigate ? 1 : 0) + (findOptions.AllowSelection ? 1 : 0); 
            
            #line default
            #line hidden
WriteLiteral("\r\n                <tr>\r\n                    <td");

WriteAttribute("colspan", Tuple.Create(" colspan=\"", 6343), Tuple.Create("\"", 6366)
            
            #line 128 "..\..\Signum\Views\SearchControl.cshtml"
, Tuple.Create(Tuple.Create("", 6353), Tuple.Create<System.Object, System.Int32>(columnsCount
            
            #line default
            #line hidden
, 6353), false)
);

WriteLiteral(">");

            
            #line 128 "..\..\Signum\Views\SearchControl.cshtml"
                                           Write(JavascriptMessage.searchForResults.NiceToString());

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>\r" +
"\n\r\n");

            
            #line 134 "..\..\Signum\Views\SearchControl.cshtml"
    
            
            #line default
            #line hidden
            
            #line 134 "..\..\Signum\Views\SearchControl.cshtml"
      
        ViewData[ViewDataKeys.ShowFooter] = findOptions.ShowFooter;
        ViewData[ViewDataKeys.Pagination] = findOptions.Pagination;
        
            
            #line default
            #line hidden
            
            #line 137 "..\..\Signum\Views\SearchControl.cshtml"
   Write(Html.Partial(Navigator.Manager.PaginationSelectorView, Model));

            
            #line default
            #line hidden
            
            #line 137 "..\..\Signum\Views\SearchControl.cshtml"
                                                                      
    
            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n    require([\"");

            
            #line 141 "..\..\Signum\Views\SearchControl.cshtml"
         Write(JsModule.Finder);

            
            #line default
            #line hidden
WriteLiteral("\"], function(Finder) { new Finder.SearchControl($(\"#");

            
            #line 141 "..\..\Signum\Views\SearchControl.cshtml"
                                                                             Write(Model.Compose("sfSearchControl"));

            
            #line default
            #line hidden
WriteLiteral("\"), \r\n");

WriteLiteral("        ");

            
            #line 142 "..\..\Signum\Views\SearchControl.cshtml"
    Write(MvcHtmlString.Create(findOptions.ToJS(Model.Prefix).ToString()));

            
            #line default
            #line hidden
WriteLiteral(",\r\n");

WriteLiteral("        ");

            
            #line 143 "..\..\Signum\Views\SearchControl.cshtml"
    Write(MvcHtmlString.Create(JsonConvert.SerializeObject(implementations.ToJsTypeInfos(isSearch : true, prefix: prefix))));

            
            #line default
            #line hidden
WriteLiteral(").ready();});\r\n</script>\r\n");

        }
    }
}
#pragma warning restore 1591
