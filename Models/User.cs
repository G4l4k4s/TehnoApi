using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechStoreApi.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }

        [Required]
        public byte[] PasswordHash { get; set; }

        [Required]
        public byte[] PasswordSalt { get; set; }

        [Required]
        [MaxLength(20)]
        public string Role { get; set; } // e.g., Administrator, Employee

        public User(string username, byte[] passwordhash, byte[] passwordsalt)
        {
            UserName = username.ToLower().Trim();
            PasswordHash = passwordhash;
            PasswordSalt = passwordsalt;
        }
    }
}