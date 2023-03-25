using ConcesionarySolution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionarySolution.Domain.Interfaces.Repositories
{
    public interface IRevisionRepository
    {
        IEnumerable<Revision> GetAllRevisionAsync();
        Revision AddRevisionAsync(Revision revision);
        bool UpdateRevisionAsync(int revisionId, Revision revision);
        bool DeleteRevisionAsync(int revisionId);

    }
}
