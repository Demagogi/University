using MediatR;

namespace University.Application.Features.Students.Queries.GetStudentWithSubjectsList
{
    public class GetStudentsWithSubjectsListQuery : IRequest<List<StudentWithSubjectsListVm>>
    {
    }
}
