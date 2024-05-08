using System.ComponentModel.DataAnnotations;

namespace System_design_project.Models
{
    public class Products
    {
        public int Id { get; set; }
        
        [Required]
        public string ProductName { get; set; }
        
        [Required]
        [StringLength(1000)]
        public string ProductDescription { get; set; }

        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal Price { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }
       
    }
}
