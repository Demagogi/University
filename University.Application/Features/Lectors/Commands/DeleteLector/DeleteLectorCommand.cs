using MediatR;

namespace University.Application.Features.Lectors.Commands.DeleteLector
{
    public class DeleteLectorCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
