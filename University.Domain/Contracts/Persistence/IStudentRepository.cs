using University.Domain.Entities;

namespace University.Domain.Contracts.Persistence
{
    public interface IStudentRepository : IAsyncRepository<Student>
    {
        Task<List<Student>> GetStudentsWithSubjects();
    }
}
