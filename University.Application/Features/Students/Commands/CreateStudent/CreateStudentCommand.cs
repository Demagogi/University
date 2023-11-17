using MediatR;

namespace University.Application.Features.Students.Commands.CreateStudent
{
    public class CreateStudentCommand : IRequest<Guid>
    {
        public string Name { get; set; } = string.Empty;
    }
}
