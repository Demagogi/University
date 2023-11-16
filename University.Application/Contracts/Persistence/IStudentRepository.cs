using University.Domain.Entities;

namespace University.Application.Contracts.Persistence
{
    public interface IStudentRepository : IAsyncRepository<Student>
    {
        Task<List<Student>> GetStudentsWithSubjects();
    }
}
