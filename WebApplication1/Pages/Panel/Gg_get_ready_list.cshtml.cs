using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;

namespace WebApplication1.Pages.Panel
{
    public class Gg_get_ready_listModel : PageModel
    {
        private readonly WebApplication1.Models.bitirme_test2_dbContext _context;

        public Gg_get_ready_listModel(WebApplication1.Models.bitirme_test2_dbContext context)
        {
            _context = context;
        }
        private Soap_gg_services service = new Soap_gg_services();
        public Return getProduct;
        public void OnGet()
        {
            var Current_api_user = _context.GgUserInfo.FirstOrDefault(x => x.UserName == User.Identity.Name);
            if (Current_api_user != null)
            {
                getProduct = service.Get_Products(Current_api_user.RoleUsername, Current_api_user.RolePassword, Current_api_user.ApiKey, Current_api_user.SecretKey,"L");
            }
            else
            {
                RedirectToPage("./Index");
            }
        }
    }
}
