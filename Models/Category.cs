using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechStoreApi.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }


        public string Name { get; set; }

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