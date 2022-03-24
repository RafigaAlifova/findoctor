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
    public class DoctorManager : IDoctorService
    {
        private readonly IDoctorDal _doctorDal;
        public IResult Add(Doctor doctor)
        {
            _doctorDal.Add(doctor);
            return new SuccessResult();

        }

        public IDataResult<List<Doctor>> GetAll(Expression<Func<Doctor, bool>> filter = null)
        {
            return new SuccessDataResult<List<Doctor>>(_doctorDal.GetAll(filter));
        }

        public IResult Update(Doctor doctor)
        {
            _doctorDal.Update(doctor);
            return new SuccessResult();
        }
    }
}
