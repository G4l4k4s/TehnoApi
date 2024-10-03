using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechStoreApi.Models
{
    [Table("prders")]
    public class Order
    {
        [Key]
        public int Id { get; set; }

        // Foreign Key
        public int CustomerId { get; set; }

        // Navigation Property
        public Customer Customer { get; set; }

        public DateTime CreationDate { get; set; }

        [Required]
        [MaxLength(20)]
        public string Status { get; set; } // e.g., Pending, Shipped, Delivered

        // Navigation Property
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}