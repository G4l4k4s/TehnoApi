using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TechStoreApi.Models
{
    [Table("products")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ids")]
        public int Id { get; set; }

        [Column("names")]
        public required string Name { get; set; }

        [Column("descriptions")]
        public required string Description { get; set; }

        [Column("prices")]
        public decimal Price { get; set; }

        [Column("quantity_in_invetorys")]
        public int QuantityInInventory { get; set; }

        // Foreign Key
        public int CategoryId { get; set; }

        // Navigation Property
        [JsonIgnore]
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        public Product(string name, string description, decimal price, int quantityininventory)
        {
            Name = name.ToLower().Trim();
            Description = description.ToLower().Trim();
            Price = price;
            QuantityInInventory = quantityininventory;
        }

    }
}