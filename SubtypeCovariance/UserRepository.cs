using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// @author Derek Shaheen
/// @date 11/17/2019
/// @description Assignment code used for returning a user object
/// </summary>
namespace SubtypeCovariance
{
    public class UserRepository : IEntityRepository<User>
    {
        //public override Entity GetByID(Guid id)
        public User GetByID(Guid id)
        {
            return new User(id);
        }
    }
}
