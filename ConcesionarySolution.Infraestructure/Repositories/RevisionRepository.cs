using ConcesionarySolution.Domain.Entities;
using ConcesionarySolution.Domain.Interfaces.Repositories;
using ConcesionarySolution.Infraestructure.Persitence;
using Microsoft.EntityFrameworkCore;

namespace ConcesionarySolution.Infraestructure.Repositories
{
    public class RevisionRepository: IRevisionRepository
    {
        private readonly ConsesionaryContext _context;

        public RevisionRepository(ConsesionaryContext context)
        {
            _context = context;
        }

        public Revision AddRevisionAsync(Revision revision)
        {
            _context.Revisions.Add(revision);
            _context.SaveChanges();
            return revision;
        }

        public IEnumerable<Revision> GetAllRevisionAsync()
        {
            try
            {
                var revisions = _context.Revisions
                    .ToList();
                return revisions;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public bool DeleteRevisionAsync(int revisionId)
        {
            var revision = _context.Revisions.FirstOrDefault(x => x.Revisionid == revisionId);
            if (revision == null) 
                return false;
           
            _context.Revisions.Remove(revision);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateRevisionAsync(int revisionId, Revision revision)
        {
            var revisionDb = _context.Revisions.FirstOrDefault(x => x.Revisionid == revisionId);
            if (revisionDb == null)
                return false;

            revisionDb.Quantity = revision.Quantity;
            revisionDb.Filtro = revision.Filtro;
            revisionDb.Oil = revision.Oil;
            revisionDb.Freno = revision.Freno;
            revisionDb.Other = revision.Other;
            _context.SaveChanges();

            return true;
        }
    }
}
