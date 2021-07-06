using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages.Panel
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication1.Models.bitirme_test2_dbContext _context;

        public IndexModel(WebApplication1.Models.bitirme_test2_dbContext context)
        {
            _context = context;
        }
        public string message = "";
        public string url= "";

        public void OnGet()
        {
            var Current_api_user =_context.GgUserInfo.FirstOrDefault(x => x.UserName == User.Identity.Name);
            if (Current_api_user != null)
            {

                message = "Please select the operation you want to use on the left menu";
            }
            else
            {
                message = "No User Api Credentials Found. To use our integration panel, the user must add required informations on this panel: ";
                url = "Areas/Identity/Pages/Account/Manage/Api_Integration";
            }
        }
    }
}
