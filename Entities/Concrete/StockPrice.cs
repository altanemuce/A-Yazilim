using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class StockPrice:IEntity
    {
        public int Id { get; set; }
        public int StockId { get; set; }
        public decimal Price { get; set; }
        public Stock Stock { get; set; }
    }
}
