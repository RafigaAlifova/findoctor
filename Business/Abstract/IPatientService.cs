using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IPatientService
    {
        IDataResult<List<Patient>> GetAll(Expression<Func<Patient, bool>> filter = null);
        IResult Add(Patient patient);
        IResult Update(Patient patient);


    }
}
