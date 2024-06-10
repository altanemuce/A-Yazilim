using Core.Entities.Abstract;

namespace Entities.Concrete
{
	public class CurrentLog:IEntity
	{
		public int Id { get; set; }
		public int CurrentId { get; set; }
		public string Action { get; set; }
		public DateTime ActionDate { get; set; }
        public Current Current { get; set; }
    }
}
