using MediatR;

namespace University.Application.Features.Subjects.Queries.GetSubjectDetails
{
    public class GetSubjectDetailsQuery : IRequest<SubjectDetailsVm>
    {
        public Guid Id { get; set; }
    }
}
