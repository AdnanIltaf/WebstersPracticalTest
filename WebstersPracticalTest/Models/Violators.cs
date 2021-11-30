using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebstersPracticalTest.Models
{
    public class Violators
    {
        [Key]
        public int ViolatorsId { get; set; }
        public int Fineid { get; set; }
        public int PersonId { get; set; }
        [Required]
        public string ViolatorName { get; set; }
        [Required]
        public string Location { get; set; }
    }
}