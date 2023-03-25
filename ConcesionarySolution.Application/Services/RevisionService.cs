using ConcesionarySolution.Domain.Entities;
using ConcesionarySolution.Domain.Interfaces.Repositories;
using ConcesionarySolution.Domain.Interfaces.Services;

namespace ConcesionarySolution.Application.Services
{
    public class RevisionService: IRevisionService
    {
        private readonly IRevisionRepository _revisionRepository;
        public RevisionService(IRevisionRepository revisionRepository)
        { 
            _revisionRepository = revisionRepository;
        }
        public Revision AddRevisionAsync(Revision revision)
        {
            return _revisionRepository.AddRevisionAsync(revision);
        }

        public bool DeleteRevisionAsync(int revisionId)
        {
            return _revisionRepository.DeleteRevisionAsync(revisionId);
        }

        public IEnumerable<Revision> GetAllRevisionsAsync()
        {
            var revisions = _revisionRepository.GetAllRevisionAsync();  
            return revisions;
        }

        public bool UpdateRevisionAsync(int revisionId, Revision revision)
        {
            return _revisionRepository.UpdateRevisionAsync(revisionId, revision);   
        }
    }
}
