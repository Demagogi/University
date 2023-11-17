using MediatR;

namespace University.Application.Features.Subjects.Commands.DeleteSubject
{
    public class DeleteSubjectCommand: IRequest
    {
        public Guid Id { get; set; }
    }
}
