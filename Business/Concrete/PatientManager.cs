using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class PatientManger : IPatientService
    {
        private readonly IPatientDal _patientDal;
        public IResult Add(Patient patient)
        {
            _patientDal.Add(patient);
            return new SuccessResult();

        }

        public IDataResult<List<Patient>> GetAll(Expression<Func<Patient, bool>> filter = null)
        {
            return new SuccessDataResult<List<Patient>>(_patientDal.GetAll(filter));
        }

        public IResult Update(Patient patient)
        {
            _patientDal.Update(patient);
            return new SuccessResult();
        }
    }
}
