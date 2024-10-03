using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TechStoreApi.Models
{
    [Table("orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("customer_ids")]
        // Foreign Key
        public int CustomerId { get; set; }

        [Column("creation_dates")]
        public DateTime CreationDate { get; set; }

        [Column("status")]
        public string Status { get; set; } // e.g., Pending, Shipped, Delivered

        // Navigation Property
        [JsonIgnore]
        [ForeignKey("CategoryId")]
        public Customer Customer { get; set; }



        // Navigation Property
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}