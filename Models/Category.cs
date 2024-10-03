using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechStoreApi.Models
{
    [Table("categorys")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("names")]
        public string Name { get; set; }

        [Column("descriptions")]
        public string Description { get; set; }

        // Navigation Property
        public ICollection<Product> Products { get; set; }


        public Category(string name, string description)
        {
            Name = name.ToLower().Trim();
            Description = description.ToLower().Trim();
        }
    }
}