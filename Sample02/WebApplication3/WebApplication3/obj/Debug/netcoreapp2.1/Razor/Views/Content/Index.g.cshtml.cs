#pragma checksum "C:\Users\博源\source\repos\WebApplication3\WebApplication3\Views\Content\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "894ff3296b1fc30138030800a9aeeb3a308b7890"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Content_Index), @"mvc.1.0.view", @"/Views/Content/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Content/Index.cshtml", typeof(AspNetCore.Views_Content_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\博源\source\repos\WebApplication3\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3;

#line default
#line hidden
#line 2 "C:\Users\博源\source\repos\WebApplication3\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3.Models;

#line default
#line hidden
#line 3 "C:\Users\博源\source\repos\WebApplication3\WebApplication3\Views\Content\Index.cshtml"
using Humanizer;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"894ff3296b1fc30138030800a9aeeb3a308b7890", @"/Views/Content/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"463d1c12e8fc14b2589daa67feec3183fea97611", @"/Views/_ViewImports.cshtml")]
    public class Views_Content_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContentViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\博源\source\repos\WebApplication3\WebApplication3\Views\Content\Index.cshtml"
  
    ViewData["Title"] = "内容列表";

#line default
#line hidden
            BeginContext(86, 79, true);
            WriteLiteral("\r\n<div class=\"panel panel-default todo-panel\">\r\n    <div class=\"panel-heading\">");
            EndContext();
            BeginContext(166, 17, false);
#line 9 "C:\Users\博源\source\repos\WebApplication3\WebApplication3\Views\Content\Index.cshtml"
                          Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(183, 314, true);
            WriteLiteral(@"</div>

    <table class=""table table-hover"">
        <thead>
            <tr>
                <td> <input type=""checkbox"" class=""done-checkbox""></td>
                <td>序号</td>
                <td>标题</td>
                <td>内容</td>
                <td>添加时间</td>
            </tr>
        </thead>

");
            EndContext();
#line 22 "C:\Users\博源\source\repos\WebApplication3\WebApplication3\Views\Content\Index.cshtml"
         foreach (var item in Model.Contents)
        {

#line default
#line hidden
            BeginContext(555, 130, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                <input type=\"checkbox\" class=\"done-checkbox\">\r\n            </td>\r\n            <td>");
            EndContext();
            BeginContext(686, 7, false);
#line 28 "C:\Users\博源\source\repos\WebApplication3\WebApplication3\Views\Content\Index.cshtml"
           Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(693, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(717, 10, false);
#line 29 "C:\Users\博源\source\repos\WebApplication3\WebApplication3\Views\Content\Index.cshtml"
           Write(item.title);

#line default
#line hidden
            EndContext();
            BeginContext(727, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(751, 12, false);
#line 30 "C:\Users\博源\source\repos\WebApplication3\WebApplication3\Views\Content\Index.cshtml"
           Write(item.content);

#line default
#line hidden
            EndContext();
            BeginContext(763, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(787, 24, false);
#line 31 "C:\Users\博源\source\repos\WebApplication3\WebApplication3\Views\Content\Index.cshtml"
           Write(item.add_time.Humanize());

#line default
#line hidden
            EndContext();
            BeginContext(811, 24, true);
            WriteLiteral("</td>\r\n\r\n        </tr>\r\n");
            EndContext();
#line 34 "C:\Users\博源\source\repos\WebApplication3\WebApplication3\Views\Content\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(846, 22, true);
            WriteLiteral("    </table>\r\n</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591