using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using e_commerce_web.Data;
using e_commerce_web.models;

namespace e_commerce_web.Pages.product
{
    public class IndexModel : PageModel
    {
        private readonly e_commerce_web.Data.e_commerce_webContext _context;

        public IndexModel(e_commerce_web.Data.e_commerce_webContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Product != null)
            {
                Product = await _context.Product.ToListAsync();
            }
        }
    }
}
