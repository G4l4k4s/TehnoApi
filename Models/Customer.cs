using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechStoreApi.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public string Address { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        // Navigation Property
        public ICollection<Order> Orders { get; set; }

        public Customer(string name, string address, string phonenumber, string email)
        {
            Name = name.ToLower().Trim();
            Address = address.ToLower().Trim();
            PhoneNumber = phonenumber.ToLower().Trim();
            Email = email.ToLower().Trim();
        }
    }
}