#pragma checksum "H:\Nazar1988\Nazar1988\Views\UserPanel\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17ea48a07fde9ceaaa36255851c4c2935994c188"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserPanel_Index), @"mvc.1.0.view", @"/Views/UserPanel/Index.cshtml")]
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
#line 1 "H:\Nazar1988\Nazar1988\Views\_ViewImports.cshtml"
using Nazar1988;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\Nazar1988\Nazar1988\Views\_ViewImports.cshtml"
using Nazar1988.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17ea48a07fde9ceaaa36255851c4c2935994c188", @"/Views/UserPanel/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c574e794144fdefb135c02c7521de91fd45e6757", @"/Views/_ViewImports.cshtml")]
    public class Views_UserPanel_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Nazar1988.Models.ViewModels.InformationUserViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "H:\Nazar1988\Nazar1988\Views\UserPanel\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""user-account"">
        <div class=""row"">
            
            <div class=""col-md-9 col-sm-8 col-xs-12"">
                <section class=""user-account-content"">
                    <header><h1> داشبورد </h1></header>
                    <div class=""inner"">
                        <div class=""account-information"">
                            <h3> اطلاعات کاربری </h3>
                            <ul>
                                <li> <i class=""zmdi zmdi-assignment-account""></i> نام کاربری : ");
#nullable restore
#line 19 "H:\Nazar1988\Nazar1988\Views\UserPanel\Index.cshtml"
                                                                                          Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n                                <li> <i class=\"zmdi zmdi-email\"></i> ایمیل : ");
#nullable restore
#line 20 "H:\Nazar1988\Nazar1988\Views\UserPanel\Index.cshtml"
                                                                        Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </li>\r\n                                <li> <i class=\"zmdi zmdi-calendar-check\"></i> تاریخ عضویت : ");
#nullable restore
#line 21 "H:\Nazar1988\Nazar1988\Views\UserPanel\Index.cshtml"
                                                                                       Write(Model.RegisterDate.ToShamsi());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n                                <li> <i class=\"zmdi zmdi-account\"></i>  اعتبار حساب : ");
#nullable restore
#line 22 "H:\Nazar1988\Nazar1988\Views\UserPanel\Index.cshtml"
                                                                                 Write(Model.Wallet.ToString("#,0 تومان"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n                            </ul>\r\n                        </div>\r\n                    </div>\r\n                </section>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Nazar1988.Models.ViewModels.InformationUserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
