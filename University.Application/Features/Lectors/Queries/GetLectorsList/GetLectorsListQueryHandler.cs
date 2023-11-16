using AutoMapper;
using MediatR;
using University.Application.Contracts.Persistence;
using University.Domain.Entities;

namespace University.Application.Features.Lectors.Queries.GetLectorsList
{
    public class GetLectorsListQueryHandler : IRequestHandler<GetLectorsListQuery, List<LectorListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Lector> _lectorRepository;

        public GetLectorsListQueryHandler(IMapper mapper, IAsyncRepository<Lector> lectorRepository)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _lectorRepository = lectorRepository ?? throw new ArgumentNullException(nameof(lectorRepository));
        }

        public async Task<List<LectorListVm>> Handle(GetLectorsListQuery request, CancellationToken cancellationToken)
        {
            var allLectors = await _lectorRepository.GetAllAsync();
            return _mapper.Map<List<LectorListVm>>(allLectors);
        }
    }
}
