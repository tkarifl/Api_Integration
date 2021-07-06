using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;


namespace WebApplication1.Pages.Panel
{
    public class Gg_insert_and_activate_productModel : PageModel
    {
        private readonly WebApplication1.Models.bitirme_test2_dbContext _context;

        public Gg_insert_and_activate_productModel(WebApplication1.Models.bitirme_test2_dbContext context)
        {
            _context = context;
        }
        private Soap_gg_services service = new Soap_gg_services();
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            string product_price = Request.Form["product_price"];
            string product_id = Request.Form["product_id"];
            if(product_price!=null&& product_id != null)
            {
                var Current_api_user = _context.GgUserInfo.FirstOrDefault(x => x.UserName == User.Identity.Name);
                var stock_product=_context.ProductsGg.FirstOrDefault(x => x.Id == Int32.Parse(product_id));
                if (stock_product != null)
                {
                    var result=service.Insert_Product(Current_api_user.RoleUsername, Current_api_user.RolePassword, Current_api_user.ApiKey, Current_api_user.SecretKey,
                    stock_product.Title, stock_product.Description, stock_product.ImageUrl, product_price);
                    _context.ProductsGg.Remove(stock_product);
                    _context.SaveChanges();
                    return RedirectToPage("./successfully_inserted");
                }
            }
            return RedirectToPage("./insertion_error");
        }
    }
}
