using AutoMapper;
using MediatR;
using University.Domain.Contracts.Persistence;
using University.Domain.Entities;

namespace University.Application.Features.Subjects.Commands.UpdateSubject
{
    public class UpdateSubjectCommandHandler : IRequestHandler<UpdateSubjectCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Subject> _subjectRepository;

        public UpdateSubjectCommandHandler(IMapper mapper, IAsyncRepository<Subject> subjectRepository)
        {
            _mapper = mapper;
            _subjectRepository = subjectRepository;
        }

        public async Task<Unit> Handle(UpdateSubjectCommand request, CancellationToken cancellationToken)
        {
            var subjectToUpdate = await _subjectRepository.GetByIdAsync(request.Id);

            _mapper.Map(request, subjectToUpdate, typeof(UpdateSubjectCommand), typeof(Subject));

            return Unit.Value;
        }
    }
}
