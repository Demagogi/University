using AutoMapper;
using MediatR;
using University.Domain.Contracts.Persistence;
using University.Domain.Entities;

namespace University.Application.Features.Lectors.Commands.CreateLector
{
    public class CreateLectorCommandHandler : IRequestHandler<CreateLectorCommand, Guid>
    {
        public readonly ILectorRepository _lectorRepository;
        public readonly IMapper _mapper;

        public CreateLectorCommandHandler(IMapper mapper, ILectorRepository lectorRepository)
        {
            _mapper = mapper;
            _lectorRepository = lectorRepository;
        }

        public async Task<Guid> Handle(CreateLectorCommand request, CancellationToken cancellationToken)
        {
            var lector = _mapper.Map<Lector>(request);

            lector = await _lectorRepository.AddAsync(lector); // how this works??

            return lector.Id;
        }
    }
}
