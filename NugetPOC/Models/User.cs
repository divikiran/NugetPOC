using System;
using System.ComponentModel.DataAnnotations;

namespace NugetPOC.Models
{
    public class User
    {
        [Required, MaxLength(20)]
        public string Name { get; set; }

        [Required, EmailAddress]
        public string Address { get; set; }

        public DateTime? CurrentDateTime { get; set; }
    }
}
