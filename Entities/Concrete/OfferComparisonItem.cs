using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class OfferComparisonItem : IEntity
    {
        public int Id { get; set; }
        public int OfferComparisonId { get; set; }
        public int StockId { get; set; }
        public decimal Price { get; set; }
        public string CompanyName { get; set; }
        public Stock Stock { get; set; }
        public OfferComparison OfferComparison { get; set; }
    }
}