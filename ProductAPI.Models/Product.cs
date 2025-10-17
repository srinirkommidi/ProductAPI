using System.ComponentModel.DataAnnotations;

namespace ProductAPI.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public int ProductCode { get; set; }
        public string ProductName { get; set; }
        public string? ProductDesc { get; set; }
        public decimal ProductCost { get; set; } = decimal.Zero;
        public string ProductCategory { get; set; }
    }


}
