#pragma checksum "C:\Users\PC\Desktop\ANOOSHEH-Library\ANOOSHEH-Library\Views\Blogpost\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b4bcbfcb715bf8ff1390abacd4436ff232bfd7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blogpost_Index), @"mvc.1.0.view", @"/Views/Blogpost/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b4bcbfcb715bf8ff1390abacd4436ff232bfd7e", @"/Views/Blogpost/Index.cshtml")]
    public class Views_Blogpost_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ANOOSHEH_Library.Models.Blogpost>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\PC\Desktop\ANOOSHEH-Library\ANOOSHEH-Library\Views\Blogpost\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\PC\Desktop\ANOOSHEH-Library\ANOOSHEH-Library\Views\Blogpost\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Subject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\PC\Desktop\ANOOSHEH-Library\ANOOSHEH-Library\Views\Blogpost\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\PC\Desktop\ANOOSHEH-Library\ANOOSHEH-Library\Views\Blogpost\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Comment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\PC\Desktop\ANOOSHEH-Library\ANOOSHEH-Library\Views\Blogpost\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Posted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 32 "C:\Users\PC\Desktop\ANOOSHEH-Library\ANOOSHEH-Library\Views\Blogpost\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "C:\Users\PC\Desktop\ANOOSHEH-Library\ANOOSHEH-Library\Views\Blogpost\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Subject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "C:\Users\PC\Desktop\ANOOSHEH-Library\ANOOSHEH-Library\Views\Blogpost\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\Users\PC\Desktop\ANOOSHEH-Library\ANOOSHEH-Library\Views\Blogpost\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Comment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\Users\PC\Desktop\ANOOSHEH-Library\ANOOSHEH-Library\Views\Blogpost\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Posted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1213, "\"", 1236, 1);
#nullable restore
#line 47 "C:\Users\PC\Desktop\ANOOSHEH-Library\ANOOSHEH-Library\Views\Blogpost\Index.cshtml"
WriteAttributeValue("", 1228, item.Id, 1228, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1289, "\"", 1312, 1);
#nullable restore
#line 48 "C:\Users\PC\Desktop\ANOOSHEH-Library\ANOOSHEH-Library\Views\Blogpost\Index.cshtml"
WriteAttributeValue("", 1304, item.Id, 1304, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1367, "\"", 1390, 1);
#nullable restore
#line 49 "C:\Users\PC\Desktop\ANOOSHEH-Library\ANOOSHEH-Library\Views\Blogpost\Index.cshtml"
WriteAttributeValue("", 1382, item.Id, 1382, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 52 "C:\Users\PC\Desktop\ANOOSHEH-Library\ANOOSHEH-Library\Views\Blogpost\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ANOOSHEH_Library.Models.Blogpost>> Html { get; private set; }
    }
}
#pragma warning restore 1591
