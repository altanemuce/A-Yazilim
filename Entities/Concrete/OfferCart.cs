using Core.Entities.Abstract;
using Core.Entities.Concrete;

namespace Entities.Concrete
{
    public class OfferCart:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual List<OfferCartItem> OfferCartItems { get; set; }
        public AppUser AppUser { get; set; }
    }
}
