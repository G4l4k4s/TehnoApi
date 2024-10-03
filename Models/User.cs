using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechStoreApi.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("user_name")]
        public string UserName { get; set; }

        [Column("password_hash")]
        public byte[] PasswordHash { get; set; }

        [Column("pasword_salt")]
        public byte[] PasswordSalt { get; set; }

        [Column("role")]
        public string Role { get; set; } // e.g., Administrator, Employee

        public User(string username, byte[] passwordhash, byte[] passwordsalt)
        {
            UserName = username.ToLower().Trim();
            PasswordHash = passwordhash;
            PasswordSalt = passwordsalt;
        }
    }
}