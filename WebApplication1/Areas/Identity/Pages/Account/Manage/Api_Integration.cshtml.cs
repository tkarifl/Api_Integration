using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Areas.Identity.Pages.Account.Manage
{
    public class Api_IntegrationModel : PageModel
    {
        private readonly WebApplication1.Models.bitirme_test2_dbContext _context;

        public Api_IntegrationModel(WebApplication1.Models.bitirme_test2_dbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public GgUserInfo GgUserInfo { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var Current_api_user = _context.GgUserInfo.FirstOrDefault(x => x.UserName == User.Identity.Name);
            if (Current_api_user != null)
            {
                GgUserInfo.UserName = User.Identity.Name;
                _context.Entry(Current_api_user).CurrentValues.SetValues(GgUserInfo);
            }
            else
            {
                GgUserInfo.UserName = User.Identity.Name;
                _context.GgUserInfo.Add(GgUserInfo);
            }
            await _context.SaveChangesAsync();
            return RedirectToPage("./Success");
        }
    }
}
