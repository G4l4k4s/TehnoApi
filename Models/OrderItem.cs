using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TechStoreApi.Models
{
    public class OrderItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("quantits")]
        public int Quantity { get; set; }

        // Foreign Keys
        [Column("order_ids")]
        public int OrderId { get; set; }

        [Column("product_ids")]
        public int ProductId { get; set; }

        // Navigation Properties
        [JsonIgnore]
        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        [JsonIgnore]
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}