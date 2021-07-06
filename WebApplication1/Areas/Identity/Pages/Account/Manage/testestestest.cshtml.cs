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
    public class testestestestModel : PageModel
    {
        private readonly WebApplication1.Models.bitirme_test2_dbContext _context;

        public testestestestModel(WebApplication1.Models.bitirme_test2_dbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public GgUserInfo GgUserInfo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            GgUserInfo = await _context.GgUserInfo.FirstOrDefaultAsync(m => m.Id == id);

            if (GgUserInfo == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(GgUserInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GgUserInfoExists(GgUserInfo.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool GgUserInfoExists(int id)
        {
            return _context.GgUserInfo.Any(e => e.Id == id);
        }
    }
}
