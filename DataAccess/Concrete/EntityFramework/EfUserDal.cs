using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, RentalDBContex>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new RentalDBContex())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationsClaim in context.UserOperationsClaims
                                 on operationClaim.Id equals userOperationsClaim.OperationClaimId
                             where userOperationsClaim.UserID == user.UserID
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }
    }
}
