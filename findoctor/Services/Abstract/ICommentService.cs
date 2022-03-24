using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace findoctor.Services.Abstract
{
    public interface ICommentService
    {
        IDataResult<List<Comment>> GetAll(Expression<Func<Comment, bool>> filter = null);
        IResult Add(Comment comment);
        IResult Update(Comment comment);
        IResult Delete(Comment comment);
    }
}
