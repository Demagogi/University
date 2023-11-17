using MediatR;

namespace University.Application.Features.Lectors.Queries.GetLector
{
    public class GetLectorQuery : IRequest<LectorVm>
    {
        public Guid Id { get; set; }
    }
}
