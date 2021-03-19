using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cust__omer.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Hey, please provide a company name!")]
        [StringLength(20, ErrorMessage = "The name is too long.")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Hey, please provide an address!")]
        public string Address { get; set; }
        [Display(Name = "Number of customers")]
        //Relations
        public List<Customer> Customers { get; set; }

    }
}