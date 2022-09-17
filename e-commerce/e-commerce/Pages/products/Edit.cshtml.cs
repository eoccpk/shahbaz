﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using e_commerce.Data;
using e_commerce.modals;

namespace e_commerce.Pages.products
{
    public class EditModel : PageModel
    {
        private readonly e_commerce.Data.e_commerceContext _context;

        public EditModel(e_commerce.Data.e_commerceContext context)
        {
            _context = context;
        }

        [BindProperty]
        public products products { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.products == null)
            {
                return NotFound();
            }

            var products =  await _context.products.FirstOrDefaultAsync(m => m.id == id);
            if (products == null)
            {
                return NotFound();
            }
            products = products;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(products).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!productsExists(products.id))
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

        private bool productsExists(int id)
        {
          return (_context.products?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
