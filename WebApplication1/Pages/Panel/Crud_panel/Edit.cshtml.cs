using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Pages.Panel.Crud_panel
{
    public class EditModel : PageModel
    {
        private readonly WebApplication1.Models.bitirme_test2_dbContext _context;

        public EditModel(WebApplication1.Models.bitirme_test2_dbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ProductsGg ProductsGg { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ProductsGg = await _context.ProductsGg.FirstOrDefaultAsync(m => m.Id == id);

            if (ProductsGg == null)
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
            ProductsGg.UserName = User.Identity.Name;
            _context.Attach(ProductsGg).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductsGgExists(ProductsGg.Id))
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

        private bool ProductsGgExists(int id)
        {
            return _context.ProductsGg.Any(e => e.Id == id);
        }
    }
}
