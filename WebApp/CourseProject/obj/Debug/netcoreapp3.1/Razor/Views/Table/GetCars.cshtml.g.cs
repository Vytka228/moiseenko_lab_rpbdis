#pragma checksum "F:\Новая папка (3)\WebApp\CourseProject\Views\Table\GetCars.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fce8c5ca005035d85c363381cd4a23c559cf76b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Table_GetCars), @"mvc.1.0.view", @"/Views/Table/GetCars.cshtml")]
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
#line 1 "F:\Новая папка (3)\WebApp\CourseProject\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Новая папка (3)\WebApp\CourseProject\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fce8c5ca005035d85c363381cd4a23c559cf76b1", @"/Views/Table/GetCars.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Table_GetCars : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebApp.Models.CarViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Новая папка (3)\WebApp\CourseProject\Views\Table\GetCars.cshtml"
  
    ViewBag.Title = "Таблица машин";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "F:\Новая папка (3)\WebApp\CourseProject\Views\Table\GetCars.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
:
<div>
    <table border=""1"">
        <thead>
            <tr>
                <td>
                    Id
                </td>
                <td>
                    Марка автомобиля
                </td>
                <td>
                    Номер автомобиля
                </td>
                <td>
                    ФИО владельца
                </td>
            </tr>
        </thead>
");
#nullable restore
#line 26 "F:\Новая папка (3)\WebApp\CourseProject\Views\Table\GetCars.cshtml"
         foreach (var elem in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 30 "F:\Новая папка (3)\WebApp\CourseProject\Views\Table\GetCars.cshtml"
               Write(elem.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 33 "F:\Новая папка (3)\WebApp\CourseProject\Views\Table\GetCars.cshtml"
               Write(elem.Carbrands);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "F:\Новая папка (3)\WebApp\CourseProject\Views\Table\GetCars.cshtml"
               Write(elem.Numberofthecar);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "F:\Новая папка (3)\WebApp\CourseProject\Views\Table\GetCars.cshtml"
               Write(elem.OwnersFIO);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 42 "F:\Новая папка (3)\WebApp\CourseProject\Views\Table\GetCars.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebApp.Models.CarViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591