using Core.Entities;

namespace Entities.Concrete
{
    public class UserOperationClaim:IEntity
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public int OperationClaimId { get; set; }
    }
}
