using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Patient : IEntity
    {
        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
    }
}
