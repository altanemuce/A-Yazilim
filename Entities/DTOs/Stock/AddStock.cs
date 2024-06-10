namespace Entities.DTOs.Stock
{
    public class AddStock
    {
        public string StockCode { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
    }
}
