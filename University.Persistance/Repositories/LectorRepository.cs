using University.Domain.Contracts.Persistence;
using University.Domain.Entities;

namespace University.Persistance.Repositories
{
    public class LectorRepository : AsyncRepository<Lector>, ILectorRepository
    {
        public LectorRepository(UniversityDbContext dbContext) : base(dbContext)
        {
        }
    }
}
