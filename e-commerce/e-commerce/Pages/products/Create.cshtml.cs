using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using e_commerce.Data;
using e_commerce.modals;

namespace e_commerce.Pages.modals
{
    public class CreateModel : PageModel
    {
        private readonly e_commerce.Data.e_commerceContext _context;

        public CreateModel(e_commerce.Data.e_commerceContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public products products { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.products == null || products == null)
            {
                return Page();
            }

            _context.products.Add(products);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
