using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Current : IEntity
    {
        public int Id { get; set; }
        public string CurrentCode { get; set; }
        public string Name { get; set; }
        public string TaxNo { get; set; }
        public virtual List<Address> Addresses { get; set; }
    }
}
