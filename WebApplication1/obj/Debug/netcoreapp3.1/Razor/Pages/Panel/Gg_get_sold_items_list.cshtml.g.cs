#pragma checksum "C:\Users\Asus\Desktop\bitirme_test2\bitirme_test2\WebApplication1\Pages\Panel\Gg_get_sold_items_list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4867731350443ec7236a1c4f935f172f25d0faea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApplication1.Pages.Panel.Pages_Panel_Gg_get_sold_items_list), @"mvc.1.0.razor-page", @"/Pages/Panel/Gg_get_sold_items_list.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4867731350443ec7236a1c4f935f172f25d0faea", @"/Pages/Panel/Gg_get_sold_items_list.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe4e1bff6fc54723de9108228ede66c4abee35ff", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Panel_Gg_get_sold_items_list : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\r\n    <!-- Categories grid-->\r\n    <!-- Category-->\r\n");
#nullable restore
#line 8 "C:\Users\Asus\Desktop\bitirme_test2\bitirme_test2\WebApplication1\Pages\Panel\Gg_get_sold_items_list.cshtml"
      
        if (Model.getProduct.Products != null)
        {
            for (int i = 0; i < Model.getProduct.Products.Product.Length; i++)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n");
#nullable restore
#line 15 "C:\Users\Asus\Desktop\bitirme_test2\bitirme_test2\WebApplication1\Pages\Panel\Gg_get_sold_items_list.cshtml"
                     if (@Model.getProduct.Products.Product[i].Product1.Photos.Photo != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img");
            BeginWriteAttribute("src", " src=", 469, "", 537, 1);
#nullable restore
#line 17 "C:\Users\Asus\Desktop\bitirme_test2\bitirme_test2\WebApplication1\Pages\Panel\Gg_get_sold_items_list.cshtml"
WriteAttributeValue("", 474, Model.getProduct.Products.Product[i].Product1.Photos.Photo.Url, 474, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"item\" width=\"40\" height=\"30\">\r\n");
#nullable restore
#line 18 "C:\Users\Asus\Desktop\bitirme_test2\bitirme_test2\WebApplication1\Pages\Panel\Gg_get_sold_items_list.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span style=\"font-size:16px\">");
#nullable restore
#line 19 "C:\Users\Asus\Desktop\bitirme_test2\bitirme_test2\WebApplication1\Pages\Panel\Gg_get_sold_items_list.cshtml"
                                            Write(Model.getProduct.Products.Product[i].Product1.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span style=\"font-size:14px\"> Price ₺");
#nullable restore
#line 19 "C:\Users\Asus\Desktop\bitirme_test2\bitirme_test2\WebApplication1\Pages\Panel\Gg_get_sold_items_list.cshtml"
                                                                                                                                            Write(Model.getProduct.Products.Product[i].Product1.BuyNowPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n                <br />\r\n");
#nullable restore
#line 22 "C:\Users\Asus\Desktop\bitirme_test2\bitirme_test2\WebApplication1\Pages\Panel\Gg_get_sold_items_list.cshtml"
            }
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                <span>No items found.</span>\r\n            </div>\r\n");
#nullable restore
#line 29 "C:\Users\Asus\Desktop\bitirme_test2\bitirme_test2\WebApplication1\Pages\Panel\Gg_get_sold_items_list.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Pages.Panel.Gg_get_sold_items_listModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication1.Pages.Panel.Gg_get_sold_items_listModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication1.Pages.Panel.Gg_get_sold_items_listModel>)PageContext?.ViewData;
        public WebApplication1.Pages.Panel.Gg_get_sold_items_listModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
