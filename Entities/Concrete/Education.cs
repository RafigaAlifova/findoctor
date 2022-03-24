using Core.Entities.Abstract;
using System;

namespace Entities.Concrete
{
    public class Education : IEntity
    {
        public int EducationId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Degree { get; set; }
        public string InstitutionName { get; set; }
        public string AreaOfStudy { get; set; }
    }
}
