using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cust__omer.Models;

namespace Cust__omer.Pages.Receipts
{
    public class DetailsModel : PageModel
    {
        private readonly CustomerContext _context;

        public DetailsModel(CustomerContext context)
        {
            _context = context;
        }

        public Receipt Receipt { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Receipt = await _context.Receipt
                .Include(r => r.Customer).FirstOrDefaultAsync(m => m.Id == id);

            if (Receipt == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
