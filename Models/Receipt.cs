using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cust__omer.Models
{
    public class Receipt
    {
        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage = "Please provide full name!")]
        [Display(Name = "Date of Issue")]
        public string DateOfIssue { get; set; }

        [Display(Name = "Amount Due")]
        public int AmountDue { get; set; }

        //Relations
        public virtual Customer Customer { get; set; }
        [Display(Name = "Customer Name")]
        public int CustomerId { get; set; }

    }
}