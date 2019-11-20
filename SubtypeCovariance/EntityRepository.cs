using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtypeCovariance
{
    public interface IEntityRepository<IEntity>
    
        where IEntity : Entity
            {
                TEntity GetbyID(Guid id);
            }
    
}
