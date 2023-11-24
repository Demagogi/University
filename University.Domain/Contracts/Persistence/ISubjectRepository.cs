using University.Domain.Entities;

namespace University.Domain.Contracts.Persistence
{
    public interface ISubjectRepository : IAsyncRepository<Subject>
    {
        Task<IEnumerable<Subject>> GetByStudentId(Guid StudentId);
    }
}
