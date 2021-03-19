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
    public class IndexModel : PageModel
    {
        private readonly CustomerContext _context;

        public IndexModel(CustomerContext context)
        {
            _context = context;
        }

        public IList<Receipt> Receipt { get;set; }

        public async Task OnGetAsync()
        {
            Receipt = await _context.Receipt
                .Include(r => r.Customer).ToListAsync();
        }
    }
}
