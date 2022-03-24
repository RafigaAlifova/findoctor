using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace findoctor.Services.Abstract
{
    public interface IPatientService
    {
        IDataResult<List<Patient>> GetAll(Expression<Func<Patient, bool>> filter = null);
        IResult Add(Patient patient);
        IResult Update(Patient patient);
        IResult Delete(Patient patient);

    }
}
