using AutoMapper;
using MediatR;
using University.Domain.Contracts.Persistence;
using University.Domain.Entities;

namespace University.Application.Features.Lectors.Queries.GetLector
{
    public class GetLectorQueryHandler : IRequestHandler<GetLectorQuery, LectorVm>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Lector> _lectorRepository;

        public GetLectorQueryHandler(IMapper mapper, IAsyncRepository<Lector> lectorRepository)
        {
            _mapper = mapper;
            _lectorRepository = lectorRepository;
        }

        public async Task<LectorVm> Handle(GetLectorQuery request, CancellationToken cancellationToken)
        {
            var lector = await _lectorRepository.GetByIdAsync(request.Id);

            return _mapper.Map<LectorVm>(lector);
        }
    }
}
