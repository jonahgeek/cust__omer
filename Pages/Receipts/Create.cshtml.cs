using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Cust__omer.Models;

namespace Cust__omer.Pages.Receipts
{
    public class CreateModel : PageModel
    {
        private readonly CustomerContext _context;

        public CreateModel(CustomerContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "EmailAddress");
            return Page();
        }

        [BindProperty]
        public Receipt Receipt { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Receipt.Add(Receipt);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
