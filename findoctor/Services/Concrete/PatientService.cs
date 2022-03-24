using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Entities.Concrete;
using findoctor.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace findoctor.Services.Concrete
{
    public class PatientService : IPatientService
    {
        private readonly Business.Abstract.IPatientService _patientService;

        public PatientService(Business.Abstract.IPatientService patientService)
        {
            _patientService = patientService;
                
        }
        public IResult Add(Patient patient)
        {
            _patientService.Add(patient);
            return new SuccessResult();
        }

        public IResult Delete(Patient patient)
        {
            _patientService.Delete(patient);
            return new SuccessResult();
        }

        public IDataResult<List<Patient>> GetAll(Expression<Func<Patient, bool>> filter = null)
        {
            return _patientService.GetAll(filter);
        }

        public IResult Update(Patient patient)
        {
            _patientService.Update(patient);
            return new SuccessResult();
        }
    }
}
