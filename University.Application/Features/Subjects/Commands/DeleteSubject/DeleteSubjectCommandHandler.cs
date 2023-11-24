using AutoMapper;
using MediatR;
using University.Domain.Contracts.Persistence;
using University.Domain.Entities;

namespace University.Application.Features.Subjects.Commands.DeleteSubject
{
    public class DeleteSubjectCommandHandler : IRequestHandler<DeleteSubjectCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Subject> _subjectRepository;

        public DeleteSubjectCommandHandler(IMapper mapper, IAsyncRepository<Subject> subjectRepository)
        {
            _mapper = mapper;
            _subjectRepository = subjectRepository;
        }

        public async Task<Unit> Handle(DeleteSubjectCommand request, CancellationToken cancellationToken)
        {
            var eventToDelete = await _subjectRepository.GetByIdAsync(request.Id);

            await _subjectRepository.DeleteAsync(eventToDelete);

            return Unit.Value;
        }
    }
}
