using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IDoctorService
    {
        IDataResult<List<Doctor>> GetAll(Expression<Func<Doctor, bool>> filter = null);
        IResult Add(Doctor doctor);
        IResult Update(Doctor doctor);
  
      
    }
}
