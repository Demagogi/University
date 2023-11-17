using University.Domain.Entities;

namespace University.Application.Contracts.Persistence
{
    public interface ISubjectRepository : IAsyncRepository<Subject>
    {
        Task<IEnumerable<Subject>> GetByStudentId(Guid StudentId);
    }
}
