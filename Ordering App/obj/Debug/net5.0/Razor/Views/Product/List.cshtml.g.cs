#pragma checksum "C:\Users\aprox\source\repos\CourseProject\Ordering App\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ec768a7bf764d36d95547960013e61fcd156c80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
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
#line 1 "C:\Users\aprox\source\repos\CourseProject\Ordering App\Views\_ViewImports.cshtml"
using Ordering_App.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ec768a7bf764d36d95547960013e61fcd156c80", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba1c3dbf943c40c834dfaf74682e0d796afb81d8", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("        <h1>Продукти</h1>\r\n        <h3>");
#nullable restore
#line 2 "C:\Users\aprox\source\repos\CourseProject\Ordering App\Views\Product\List.cshtml"
       Write(Model.CurrCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 3 "C:\Users\aprox\source\repos\CourseProject\Ordering App\Views\Product\List.cshtml"
          
            foreach (var product in Model.GetGoods)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                <p>");
#nullable restore
#line 7 "C:\Users\aprox\source\repos\CourseProject\Ordering App\Views\Product\List.cshtml"
              Write(product.comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Ціна:");
#nullable restore
#line 8 "C:\Users\aprox\source\repos\CourseProject\Ordering App\Views\Product\List.cshtml"
                   Write(product.price.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n");
#nullable restore
#line 10 "C:\Users\aprox\source\repos\CourseProject\Ordering App\Views\Product\List.cshtml"
             }
         

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591