using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Offer:IEntity
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
    }
}
