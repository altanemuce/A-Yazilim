using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class OfferCartItem : IEntity
    {
        public int Id { get; set; }
        public int OfferCartId { get; set; }
        public int StockId { get; set; }
        public int Amount { get; set; }
        public Stock Stock { get; set; }
        public OfferCart OfferCart { get; set; }
    }
}