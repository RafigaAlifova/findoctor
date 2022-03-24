using Core.Entities.Concrete;
using DataAccess.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, findoctorContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new findoctorContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaims in context.UserOperationClaims
                             on operationClaim.Id equals userOperationClaims.OperationClaimId
                             where userOperationClaims.UserId == user.Id
                             select new OperationClaim
                             {
                                 Id = operationClaim.Id,
                                 Name = operationClaim.Name
                             };
                return result.ToList();
            }
        }
    }
}
