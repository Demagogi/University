using MediatR;

namespace University.Application.Features.Lectors.Commands.UpdateLector
{
    public class UpdateLectorCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
