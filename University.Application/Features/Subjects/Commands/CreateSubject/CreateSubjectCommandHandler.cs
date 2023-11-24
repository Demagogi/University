using AutoMapper;
using MediatR;
using University.Domain.Contracts.Persistence;
using University.Domain.Entities;

namespace University.Application.Features.Subjects.Commands.CreateSubject
{
    public class CreateSubjectCommandHandler : IRequestHandler<CreateSubjectCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Subject> _subjectRepository;

        public CreateSubjectCommandHandler(IMapper mapper, IAsyncRepository<Subject> subjectRepository)
        {
            _mapper = mapper;
            _subjectRepository = subjectRepository;
        }

        public async Task<Guid> Handle(CreateSubjectCommand request, CancellationToken cancellationToken)
        {
            var subject = _mapper.Map<Subject>(request);

            subject = await _subjectRepository.AddAsync(subject);

            return subject.Id;
        }
    }
}
