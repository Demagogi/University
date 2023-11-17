using MediatR;

namespace University.Application.Features.Students.Commands.UpdateStudent
{
    public class UpdateStudentCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
