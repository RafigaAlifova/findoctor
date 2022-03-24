using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Doctor : IEntity
    {
        public int DoctorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string SpecialityId { get; set; }
        public int HospitalId { get; set; }
        public int PhoneNumber { get; set; }
        public string About { get; set; }
        public int TotalRate { get; set; }
        public int EducationId { get; set; }
    }
}
