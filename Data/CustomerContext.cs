using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cust__omer.Models;

    public class CustomerContext : DbContext
    {
        public CustomerContext (DbContextOptions<CustomerContext> options)
            : base(options)
        {
        }

        public DbSet<Cust__omer.Models.Customer> Customer { get; set; }

        public DbSet<Cust__omer.Models.Company> Company { get; set; }

        public DbSet<Cust__omer.Models.Receipt> Receipt { get; set; }

        public DbSet<Cust__omer.Models.User> User { get; set; }
    }
