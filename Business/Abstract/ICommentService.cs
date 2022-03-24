using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICommentService
    {
        IDataResult<List<Comment>> GetAll(Expression<Func<Comment, bool>> filter = null);
        IResult Add(Comment comment);
        IResult Update(Comment comment);


    }
}
