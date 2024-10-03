using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechStoreApi.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("names")]
        public string Name { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("phone_number")]
        public string PhoneNumber { get; set; }

        [Column("emails")]
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