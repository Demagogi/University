using MediatR;

namespace University.Application.Features.Students.Commands.DeleteStudent
{
    public class DeleteStudentCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
