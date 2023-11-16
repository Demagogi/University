using MediatR;

namespace University.Application.Features.Students.Queries.GetStudentsList
{
    public class GetStudentsListQuery : IRequest<List<StudentsListVm>>
    {
    }
}
