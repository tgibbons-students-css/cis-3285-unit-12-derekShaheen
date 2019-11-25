using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// @author Derek Shaheen
/// @date 11/24/2019
/// @description Assignment code used for implementing the EntityRepository
/// </summary>
namespace SubtypeCovariance
{
    public interface IEntityRepository<TEntity>
        where TEntity : Entity
    {
        TEntity GetByID(Guid id);
    }
}
