using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebstersPracticalTest.Models
{
    public class Fine
    {
        [Key]
        public int Fineid { get; set; }
        [Required]
        public string FineName { get; set; }
        [Required]
        public string FineCharges { get; set; }

    }
}