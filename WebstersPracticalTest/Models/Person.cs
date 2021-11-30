using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebstersPracticalTest.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        [Required]
        public string PersonName { get; set; }
    }
}