using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using e_commerce.Data;
using e_commerce.modals;

namespace e_commerce.Pages.products
{
    public class DetailsModel : PageModel
    {
        private readonly e_commerce.Data.e_commerceContext _context;

        public DetailsModel(e_commerce.Data.e_commerceContext context)
        {
            _context = context;
        }

      public products products { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.products == null)
            {
                return NotFound();
            }

            var products = await _context.products.FirstOrDefaultAsync(m => m.id == id);
            if (products == null)
            {
                return NotFound();
            }
            else 
            {
                products = products;
            }
            return Page();
        }
    }
}
