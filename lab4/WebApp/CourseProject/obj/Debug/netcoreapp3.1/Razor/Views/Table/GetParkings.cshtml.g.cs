#pragma checksum "F:\Новая папка (3)\WebApp\CourseProject\Views\Table\GetParkings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a16a971ddb5e435ef40ce0fac96161c8aa051c8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Table_GetParkings), @"mvc.1.0.view", @"/Views/Table/GetParkings.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a16a971ddb5e435ef40ce0fac96161c8aa051c8a", @"/Views/Table/GetParkings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Table_GetParkings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebApp.Models.ParkingViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Новая папка (3)\WebApp\CourseProject\Views\Table\GetParkings.cshtml"
  
    ViewBag.Title = "Таблица мебели";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "F:\Новая папка (3)\WebApp\CourseProject\Views\Table\GetParkings.cshtml"
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
                    Тип парковки
                </td>
                <td>
                    Дата въезда
                </td>
                <td>
                    Дата выезда
                </td>
                <td>
                    Номер автомобиля
                </td>
                <td>
                    Стоимость
                </td>
            </tr>
        </thead>
");
#nullable restore
#line 32 "F:\Новая папка (3)\WebApp\CourseProject\Views\Table\GetParkings.cshtml"
         foreach (var elem in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "F:\Новая папка (3)\WebApp\CourseProject\Views\Table\GetParkings.cshtml"
               Write(elem.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "F:\Новая папка (3)\WebApp\CourseProject\Views\Table\GetParkings.cshtml"
               Write(elem.TypeParking);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "F:\Новая папка (3)\WebApp\CourseProject\Views\Table\GetParkings.cshtml"
               Write(elem.Dateentry);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "F:\Новая папка (3)\WebApp\CourseProject\Views\Table\GetParkings.cshtml"
               Write(elem.Datedeparture);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "F:\Новая папка (3)\WebApp\CourseProject\Views\Table\GetParkings.cshtml"
               Write(elem.CarsNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "F:\Новая папка (3)\WebApp\CourseProject\Views\Table\GetParkings.cshtml"
               Write(elem.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 54 "F:\Новая папка (3)\WebApp\CourseProject\Views\Table\GetParkings.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebApp.Models.ParkingViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591