#pragma checksum "C:\Users\Asus\Desktop\bitirme_test2\bitirme_test2\WebApplication1\Pages\Panel\insertion_error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "931943752c3de452cefcd3161ee723ae359f15de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApplication1.Pages.Panel.Pages_Panel_insertion_error), @"mvc.1.0.razor-page", @"/Pages/Panel/insertion_error.cshtml")]
namespace WebApplication1.Pages.Panel
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
#line 1 "C:\Users\Asus\Desktop\bitirme_test2\bitirme_test2\WebApplication1\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asus\Desktop\bitirme_test2\bitirme_test2\WebApplication1\Pages\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Asus\Desktop\bitirme_test2\bitirme_test2\WebApplication1\Pages\_ViewImports.cshtml"
using WebApplication1.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"931943752c3de452cefcd3161ee723ae359f15de", @"/Pages/Panel/insertion_error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe4e1bff6fc54723de9108228ede66c4abee35ff", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Panel_insertion_error : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"alert alert-danger\" role=\"alert\">\r\n    <span>The Product Couldn\'t Inserted To Gittigidiyor Api, Check the Product Description and/or Title For Being Too Short (Gittigidiyor\r\n    Api Won\'t Allow Short Titles and Descriptions</span>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Pages.Panel.Crud_panel.insertion_errorModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication1.Pages.Panel.Crud_panel.insertion_errorModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication1.Pages.Panel.Crud_panel.insertion_errorModel>)PageContext?.ViewData;
        public WebApplication1.Pages.Panel.Crud_panel.insertion_errorModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
