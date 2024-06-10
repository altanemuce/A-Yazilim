using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class OfferLog:IEntity
    {
        public int Id { get; set; }
        public int OfferId { get; set; }
        public string Action { get; set; }
        public DateTime ActionDate { get; set; }
        public Offer Offer { get; set; }
    }
}
