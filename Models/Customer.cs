using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cust__omer.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter your name.")]
        [DataType(DataType.Text)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
        [Display(Name = "Physical Address")]
        public string PhysicalAddress { get; set; }
        
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        // Relations
        public virtual Company Company { get; set; }
        [Display(Name = "Company Name")]
        public int CompanyId { get; set; }

        public List<Receipt> Receipts { get; set; }
    }
}