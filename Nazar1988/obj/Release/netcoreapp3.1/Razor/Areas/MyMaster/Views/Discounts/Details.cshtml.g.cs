#pragma checksum "C:\Users\milad\Desktop\Nazar1988\Nazar1988\Areas\MyMaster\Views\Discounts\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5d1a2ca964783f1a9a0b9ed962023b8e309a714"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_MyMaster_Views_Discounts_Details), @"mvc.1.0.view", @"/Areas/MyMaster/Views/Discounts/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5d1a2ca964783f1a9a0b9ed962023b8e309a714", @"/Areas/MyMaster/Views/Discounts/Details.cshtml")]
    public class Areas_MyMaster_Views_Discounts_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Nazar1988.Models.Discount>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\milad\Desktop\Nazar1988\Nazar1988\Areas\MyMaster\Views\Discounts\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_MymasterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Discount</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 15 "C:\Users\milad\Desktop\Nazar1988\Nazar1988\Areas\MyMaster\Views\Discounts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DiscountPercent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 18 "C:\Users\milad\Desktop\Nazar1988\Nazar1988\Areas\MyMaster\Views\Discounts\Details.cshtml"
       Write(Html.DisplayFor(model => model.DiscountPercent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 21 "C:\Users\milad\Desktop\Nazar1988\Nazar1988\Areas\MyMaster\Views\Discounts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 24 "C:\Users\milad\Desktop\Nazar1988\Nazar1988\Areas\MyMaster\Views\Discounts\Details.cshtml"
       Write(Html.DisplayFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 27 "C:\Users\milad\Desktop\Nazar1988\Nazar1988\Areas\MyMaster\Views\Discounts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EndtDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 30 "C:\Users\milad\Desktop\Nazar1988\Nazar1988\Areas\MyMaster\Views\Discounts\Details.cshtml"
       Write(Html.DisplayFor(model => model.EndtDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 33 "C:\Users\milad\Desktop\Nazar1988\Nazar1988\Areas\MyMaster\Views\Discounts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductIdies));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 36 "C:\Users\milad\Desktop\Nazar1988\Nazar1988\Areas\MyMaster\Views\Discounts\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProductIdies.ProductID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1002, "\"", 1033, 1);
#nullable restore
#line 41 "C:\Users\milad\Desktop\Nazar1988\Nazar1988\Areas\MyMaster\Views\Discounts\Details.cshtml"
WriteAttributeValue("", 1017, Model.ProductId, 1017, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Nazar1988.Models.Discount> Html { get; private set; }
    }
}
#pragma warning restore 1591