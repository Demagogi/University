using AutoMapper;
using MediatR;
using University.Domain.Contracts.Persistence;
using University.Domain.Entities;

namespace University.Application.Features.Subjects.Queries.GetSubjectsList
{
    public class GetSubjectsListQueryHandler : IRequestHandler<GetSubjectsListQuery, List<SubjectsListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Subject> _subjectRepository;

        public GetSubjectsListQueryHandler(IMapper mapper, IAsyncRepository<Subject> subjectRepository)
        {
            _subjectRepository = subjectRepository;
            _mapper = mapper;
        }

        public async Task<List<SubjectsListVm>> Handle(GetSubjectsListQuery request, CancellationToken cancellationToken)
        {
            var subjects = await _subjectRepository.GetAllAsync();

            return _mapper.Map<List<SubjectsListVm>>(subjects);
        }
    }
}
