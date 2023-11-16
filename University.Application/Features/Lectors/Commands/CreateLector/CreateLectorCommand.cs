using MediatR;

namespace University.Application.Features.Lectors.Commands.CreateLector
{
    public class CreateLectorCommand : IRequest<Guid>
    {
        public string Name { get; set; } = string.Empty;
    }
}
