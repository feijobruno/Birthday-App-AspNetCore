#pragma checksum "C:\Users\USUARIO\source\repos\infnet\aspNet\BirthdayApp\BirthdayApp\Views\People\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f32146b2dfcfaca5f2cdf09a4d758da04b010240"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_People_Result), @"mvc.1.0.view", @"/Views/People/Result.cshtml")]
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
#nullable restore
#line 1 "C:\Users\USUARIO\source\repos\infnet\aspNet\BirthdayApp\BirthdayApp\Views\_ViewImports.cshtml"
using BirthdayApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USUARIO\source\repos\infnet\aspNet\BirthdayApp\BirthdayApp\Views\_ViewImports.cshtml"
using BirthdayApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f32146b2dfcfaca5f2cdf09a4d758da04b010240", @"/Views/People/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"302b1a199cb68fcd595e294761e791dd9899342e", @"/Views/_ViewImports.cshtml")]
    public class Views_People_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<People>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\USUARIO\source\repos\infnet\aspNet\BirthdayApp\BirthdayApp\Views\People\Result.cshtml"
  
    ViewData["Title"] = "Result";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\USUARIO\source\repos\infnet\aspNet\BirthdayApp\BirthdayApp\Views\People\Result.cshtml"
 if (!String.IsNullOrEmpty(ViewBag.Message))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 126, "\"", 153, 2);
            WriteAttributeValue("", 134, "alert", 134, 5, true);
#nullable restore
#line 10 "C:\Users\USUARIO\source\repos\infnet\aspNet\BirthdayApp\BirthdayApp\Views\People\Result.cshtml"
WriteAttributeValue(" ", 139, ViewBag.Type, 140, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\" id=\"divAlert\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\r\n        <strong>Success!</strong> ");
#nullable restore
#line 12 "C:\Users\USUARIO\source\repos\infnet\aspNet\BirthdayApp\BirthdayApp\Views\People\Result.cshtml"
                             Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 14 "C:\Users\USUARIO\source\repos\infnet\aspNet\BirthdayApp\BirthdayApp\Views\People\Result.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h3 style=""margin-top: 25px;"">People found</h3>
<hr />

<table class=""table"">
    <thead>
        <tr>
            <th>FirstName</th>
            <th>LastName</th>
            <th>Birthday</th>
            <th colspan=""2"">Action</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 28 "C:\Users\USUARIO\source\repos\infnet\aspNet\BirthdayApp\BirthdayApp\Views\People\Result.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\USUARIO\source\repos\infnet\aspNet\BirthdayApp\BirthdayApp\Views\People\Result.cshtml"
               Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\USUARIO\source\repos\infnet\aspNet\BirthdayApp\BirthdayApp\Views\People\Result.cshtml"
               Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\USUARIO\source\repos\infnet\aspNet\BirthdayApp\BirthdayApp\Views\People\Result.cshtml"
               Write(item.Birthday.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a class=\"btn btn-warning btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 957, "\"", 988, 2);
            WriteAttributeValue("", 964, "/People/Edit?id=", 964, 16, true);
#nullable restore
#line 35 "C:\Users\USUARIO\source\repos\infnet\aspNet\BirthdayApp\BirthdayApp\Views\People\Result.cshtml"
WriteAttributeValue("", 980, item.Id, 980, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n                    <a class=\"btn btn-danger btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 1052, "\"", 1085, 2);
            WriteAttributeValue("", 1059, "/People/Delete?id=", 1059, 18, true);
#nullable restore
#line 36 "C:\Users\USUARIO\source\repos\infnet\aspNet\BirthdayApp\BirthdayApp\Views\People\Result.cshtml"
WriteAttributeValue("", 1077, item.Id, 1077, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 39 "C:\Users\USUARIO\source\repos\infnet\aspNet\BirthdayApp\BirthdayApp\Views\People\Result.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<People>> Html { get; private set; }
    }
}
#pragma warning restore 1591
