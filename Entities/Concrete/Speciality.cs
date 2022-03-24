using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Speciality : IEntity
    {
        public int SpecialityId { get; set; }
        public string Name { get; set; }
    }
}
