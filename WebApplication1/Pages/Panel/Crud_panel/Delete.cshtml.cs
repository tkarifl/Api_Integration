using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Pages.Panel.Crud_panel
{
    public class DeleteModel : PageModel
    {
        private readonly WebApplication1.Models.bitirme_test2_dbContext _context;

        public DeleteModel(WebApplication1.Models.bitirme_test2_dbContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ProductsGg = await _context.ProductsGg.FindAsync(id);

            if (ProductsGg != null)
            {
                _context.ProductsGg.Remove(ProductsGg);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
