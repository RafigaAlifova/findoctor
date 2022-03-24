using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;
        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public IResult Add(Comment comment)
        {
            _commentDal.Add(comment);
            return new SuccessResult();

        }

        public IDataResult<List<Comment>> GetAll(Expression<Func<Comment, bool>> filter = null)
        {
            return new SuccessDataResult<List<Comment>>(_commentDal.GetAll(filter));

        }

        public IResult Update(Comment comment)
        {
            _commentDal.Update(comment);
            return new SuccessResult();
        }
    }
}
