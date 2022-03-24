using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class DoctorValidator : AbstractValidator<Doctor>
    {
        public DoctorValidator()
        {
            RuleFor(c => c.DoctorId).NotEmpty();
            RuleFor(c => c.FirstName).NotEmpty();
            RuleFor(c => c.FirstName).Length(2,25);
            RuleFor(c => c.LastName).NotEmpty();
            RuleFor(c => c.LastName).Length(2, 35);
            RuleFor(c => c.Gender).NotEmpty(); 
            RuleFor(c => c.SpecialityId).NotEmpty();
            RuleFor(c => c.HospitalId).NotEmpty();
            RuleFor(c => c.PhoneNumber).NotEmpty();
            RuleFor(c => c.About).NotEmpty();
            RuleFor(c => c.TotalRate).NotEmpty();
            RuleFor(c => c.EducationId).NotEmpty();
            //RuleFor(c => c.ColorId).NotEmpty();
            //RuleFor(c => c.CarName).NotEmpty();
            //RuleFor(c => c.CarName).MinimumLength(2);
            //RuleFor(c => c.DailyPrice).NotEmpty();
            //RuleFor(c => c.DailyPrice).GreaterThan(0);
            //RuleFor(c => c.Description).NotEmpty();
            //RuleFor(c => c.Description).MinimumLength(2);
            //RuleFor(c => c.ModelYear).NotEmpty();
            //RuleFor(c => c.ModelYear).GreaterThan(0);
        }
    }
}
