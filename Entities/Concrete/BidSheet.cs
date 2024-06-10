using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class BidSheet:IEntity
    {
        public int Id { get; set; }
        public int OfferId { get; set; }
        public string CompanyName { get; set; }
        public decimal TotalPrice { get; set; }
        public Offer Offer { get; set; }
    }
}
