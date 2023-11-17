using MediatR;

namespace University.Application.Features.Subjects.Commands.UpdateSubject
{
    public class UpdateSubjectCommand : IRequest
    {
        public Guid Id { get; set; }
        public string SubjectName { get; set; } = string.Empty;
        public int Rate { get; set; }
        public Guid StudentId { get; set; }
    }
}
