using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class OfferComparison:IEntity
    {
        public int Id { get; set; }
        public int OfferId { get; set; }
        public virtual List<OfferComparisonItem> OfferComparisonItems { get; set; }
        public Offer Offer { get; set; }
    }
}
