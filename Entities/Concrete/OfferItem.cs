using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class OfferItem:IEntity
    {
        public int Id { get; set; }
        public int OfferId { get; set; }
        public int StockId { get; set; }
        public int Amount { get; set; }
        public decimal UnitPrice  { get; set; }
        public Stock Stock { get; set; }
        public Offer Offer { get; set; }
    }
}
