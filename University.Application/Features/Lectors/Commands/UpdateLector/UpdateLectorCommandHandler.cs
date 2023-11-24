using AutoMapper;
using MediatR;
using University.Domain.Contracts.Persistence;
using University.Domain.Entities;

namespace University.Application.Features.Lectors.Commands.UpdateLector
{
    public class UpdateLectorCommandHandler : IRequestHandler<UpdateLectorCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Lector> _lectorRepository;

        public UpdateLectorCommandHandler(IMapper mapper, IAsyncRepository<Lector> lecctorRepository)
        {
            _lectorRepository = lecctorRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateLectorCommand request, CancellationToken cancellationToken)
        {
            var lectorToUpdate = await _lectorRepository.GetByIdAsync(request.Id);

            _mapper.Map(request, lectorToUpdate, typeof(UpdateLectorCommand), typeof(Lector));

            await _lectorRepository.UpdateAsync(lectorToUpdate);

            return Unit.Value;
        }
    }
}
