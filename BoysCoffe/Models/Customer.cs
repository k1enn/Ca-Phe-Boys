﻿using System.ComponentModel.DataAnnotations;

namespace BoysCoffe.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        public string PhoneNumber { get; set; }
    }

}
