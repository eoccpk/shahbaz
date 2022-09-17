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
    public class IndexModel : PageModel
    {
        private readonly e_commerce.Data.e_commerceContext _context;

        public IndexModel(e_commerce.Data.e_commerceContext context)
        {
            _context = context;
        }

        public IList<products> products { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.products != null)
            {
                products = await _context.products.ToListAsync();
            }
        }
    }
}
