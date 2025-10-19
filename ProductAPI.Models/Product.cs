using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductAPI.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public int ProductCode { get; set; }
        public string ProductName { get; set; }
        public string? ProductDesc { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ProductCost { get; set; } 
        public string ProductCategory { get; set; }
    }


}
