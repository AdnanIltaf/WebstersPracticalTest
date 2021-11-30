using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebstersPracticalTest.Models
{
    public class Payments
    {
        [Key]
        public int PaymentId { get; set; }
        public int Fineid { get; set; }
        public int ViolatorsId { get; set; }
        public DateTime? PaymentDate { get; set; }

    }
}