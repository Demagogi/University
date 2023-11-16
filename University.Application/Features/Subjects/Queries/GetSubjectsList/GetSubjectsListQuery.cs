using MediatR;

namespace University.Application.Features.Subjects.Queries.GetSubjectsList
{
    public class GetSubjectsListQuery : IRequest<List<SubjectsListVm>>
    {
    }
}
