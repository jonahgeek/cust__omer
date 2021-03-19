using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cust__omer.Models;

namespace Cust__omer.Pages.Customers
{
    public class IndexModel : PageModel
    {
        private readonly CustomerContext _context;

        public IndexModel(CustomerContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customer
                .Include(c => c.Company).ToListAsync();
        }
    }
}
