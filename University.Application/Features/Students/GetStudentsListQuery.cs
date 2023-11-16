using MediatR;

namespace University.Application.Features.Students
{
    public class GetStudentsListQuery : IRequest<List<StudentsListVm>>
    {
    }
}
