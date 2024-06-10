using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Stock : IEntity
    {
        public int Id { get; set; }
        public string StockCode { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public virtual List<StockPrice> StockPrices { get; set; }
    }
}
