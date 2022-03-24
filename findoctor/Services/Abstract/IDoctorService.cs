using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace findoctor.Services.Abstract
{
    public interface IDoctorService
    {
        IDataResult<List<Doctor>> GetAll(Expression<Func<Doctor, bool>> filter = null);
        IResult Add(Doctor doctor);
        IResult Update(Doctor doctor);
        IResult Delete(Doctor doctor);
    }
}
