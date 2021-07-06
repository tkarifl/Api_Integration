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
    public class IndexModel : PageModel
    {
        private readonly WebApplication1.Models.bitirme_test2_dbContext _context;

        public IndexModel(WebApplication1.Models.bitirme_test2_dbContext context)
        {
            _context = context;
        }

        public IList<ProductsGg> ProductsGg { get;set; }

        public async Task OnGetAsync()
        {
            ProductsGg = await _context.ProductsGg.ToListAsync();
        }
    }
}
