using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Hospital : IEntity
    {
        public int HospitalId { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }

    }
}
