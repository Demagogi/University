using MediatR;

namespace University.Application.Features.Lectors.Queries.GetLectorsList
{
    public class GetLectorsListQuery : IRequest<List<LectorListVm>>
    {
    }
}
