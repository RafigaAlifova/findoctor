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
    public class CommentService : ICommentService
    {
        private readonly Business.Abstract.ICommentService _commentService;

        public CommentService(Business.Abstract.ICommentService commentService)
        {
            _commentService = commentService;

        }
        public IResult Add(Comment comment)
        {
            _commentService.Add(comment);
            return new SuccessResult();
        }

        public IResult Delete(Comment comment)
        {
            _commentService.Delete(comment);
            return new SuccessResult();
        }

        public IDataResult<List<Comment>> GetAll(Expression<Func<Comment, bool>> filter = null)
        {
            return _commentService.GetAll(filter);
        }

        public IResult Update(Comment comment)
        {
            _commentService.Update(comment);
            return new SuccessResult();
        }
    }
}
