#pragma checksum "H:\Nazar1988\Nazar1988\Areas\MyMaster\Views\Accounter\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcb7008b64607e3df3569296325ce944d45d70a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_MyMaster_Views_Accounter_Details), @"mvc.1.0.view", @"/Areas/MyMaster/Views/Accounter/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcb7008b64607e3df3569296325ce944d45d70a8", @"/Areas/MyMaster/Views/Accounter/Details.cshtml")]
    public class Areas_MyMaster_Views_Accounter_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Nazar1988.Models.ViewModels.ShowOrderViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PrintPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "H:\Nazar1988\Nazar1988\Areas\MyMaster\Views\Accounter\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_MymasterLayout.cshtml";
    int row = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>نمایش فاکتور</h1>\r\n<hr />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dcb7008b64607e3df3569296325ce944d45d70a83622", async() => {
                WriteLiteral("چاپ فاکتور");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 10 "H:\Nazar1988\Nazar1988\Areas\MyMaster\Views\Accounter\Details.cshtml"
                                                             WriteLiteral(ViewBag.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>تصویر</th>\r\n        <th>عنوان</th>\r\n        <th>تعداد</th>\r\n        <th>قیمت</th>\r\n        <th>جمع</th>\r\n        <th></th>\r\n    </tr>\r\n");
#nullable restore
#line 21 "H:\Nazar1988\Nazar1988\Areas\MyMaster\Views\Accounter\Details.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 24 "H:\Nazar1988\Nazar1988\Areas\MyMaster\Views\Accounter\Details.cshtml"
           Write(row);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <img style=\"max-width: 150px\" class=\"thumbnail\"");
            BeginWriteAttribute("src", " src=\"", 749, "\"", 778, 2);
            WriteAttributeValue("", 755, "/Images/", 755, 8, true);
#nullable restore
#line 26 "H:\Nazar1988\Nazar1988\Areas\MyMaster\Views\Accounter\Details.cshtml"
WriteAttributeValue("", 763, item.ImageName, 763, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </td>\r\n            <td>");
#nullable restore
#line 28 "H:\Nazar1988\Nazar1988\Areas\MyMaster\Views\Accounter\Details.cshtml"
           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "H:\Nazar1988\Nazar1988\Areas\MyMaster\Views\Accounter\Details.cshtml"
           Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "H:\Nazar1988\Nazar1988\Areas\MyMaster\Views\Accounter\Details.cshtml"
           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "H:\Nazar1988\Nazar1988\Areas\MyMaster\Views\Accounter\Details.cshtml"
           Write(item.Sum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 33 "H:\Nazar1988\Nazar1988\Areas\MyMaster\Views\Accounter\Details.cshtml"

        row += 1;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td colspan=\"5\" class=\"text-left\">جمع کل : </td>\r\n        <td colspan=\"2\">\r\n            ");
#nullable restore
#line 39 "H:\Nazar1988\Nazar1988\Areas\MyMaster\Views\Accounter\Details.cshtml"
       Write(Model.Sum(s => s.Sum).ToString("#,0 تومان"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n\r\n\r\n        <td colspan=\"5\" class=\"text-left\">جمع محصول : </td>\r\n        <td colspan=\"2\">\r\n            ");
#nullable restore
#line 45 "H:\Nazar1988\Nazar1988\Areas\MyMaster\Views\Accounter\Details.cshtml"
       Write(Model.Sum(s => s.Count).ToString("#,0 تومان"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n\r\n\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Nazar1988.Models.ViewModels.ShowOrderViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
