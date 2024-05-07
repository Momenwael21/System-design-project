namespace System_design_project.Models
{
    public class Products
    {
        public int Id { get; set; }
        public required string ProductName { get; set; }
        public required string ProductDescription { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
       
    }
}
