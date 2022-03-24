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
    public class DoctorService : IDoctorService
    {
        private readonly Business.Abstract.IDoctorService _doctorService;

        public DoctorService(Business.Abstract.IDoctorService doctorService)
        {
            _doctorService = doctorService;

        }
        public IResult Add(Doctor doctor)
        {
            _doctorService.Add(doctor);
            return new SuccessResult();
        }

        public IResult Delete(Doctor doctor)
        {
            _doctorService.Delete(doctor);
            return new SuccessResult();
        }

        public IDataResult<List<Doctor>> GetAll(Expression<Func<Doctor, bool>> filter = null)
        {
            return _doctorService.GetAll(filter);
        }

        public IResult Update(Doctor doctor)
        {
            _doctorService.Update(doctor);
            return new SuccessResult();
        }
    }
}
