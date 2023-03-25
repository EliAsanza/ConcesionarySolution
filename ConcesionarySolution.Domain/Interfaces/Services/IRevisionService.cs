using ConcesionarySolution.Domain.Entities;

namespace ConcesionarySolution.Domain.Interfaces.Services
{
    public interface IRevisionService
    {
        IEnumerable<Revision> GetAllRevisionsAsync();
        Revision AddRevisionAsync(Revision revision);
        bool UpdateRevisionAsync(int revisionId, Revision revision);
        bool DeleteRevisionAsync(int revisionId);

    }
}
