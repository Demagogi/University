﻿using AutoMapper;
using MediatR;
using University.Domain.Contracts.Persistence;
using University.Domain.Entities;

namespace University.Application.Features.Lectors.Commands.DeleteLector
{
    public class DeleteLectorCommandHandler : IRequestHandler<DeleteLectorCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Lector> _lectorRepository;

        public DeleteLectorCommandHandler(IMapper mapper, IAsyncRepository<Lector> lecctorRepository)
        {
            _lectorRepository = lecctorRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteLectorCommand request, CancellationToken cancellationToken)
        {
            var lectorToDelete = await _lectorRepository.GetByIdAsync(request.Id);

            await _lectorRepository.DeleteAsync(lectorToDelete);

            return Unit.Value;
        }
    }
}
