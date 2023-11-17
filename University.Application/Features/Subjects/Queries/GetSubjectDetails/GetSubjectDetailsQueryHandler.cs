using AutoMapper;
using MediatR;
using University.Application.Contracts.Persistence;
using University.Domain.Entities;

namespace University.Application.Features.Subjects.Queries.GetSubjectDetails
{
    public class GetSubjectDetailsQueryHandler : IRequestHandler<GetSubjectDetailsQuery, SubjectDetailsVm>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Subject> _subjectRepository;
        private readonly IAsyncRepository<Student> _studentRepository;

        public GetSubjectDetailsQueryHandler(IMapper mapper, IAsyncRepository<Subject> subjectRepository, IAsyncRepository<Student> studentRepository)
        {
            _mapper = mapper;
            _subjectRepository = subjectRepository;
            _studentRepository = studentRepository;
        }

        public async Task<SubjectDetailsVm> Handle(GetSubjectDetailsQuery request, CancellationToken cancellationToken)
        {
            var subject = await _subjectRepository.GetByIdAsync(request.Id);
            var subjectDto = _mapper.Map<SubjectDetailsVm>(subject);

            var student = await _studentRepository.GetByIdAsync(subject.StudentId);
            subjectDto.Student = _mapper.Map<StudentDto>(student);

            return subjectDto;
        }
    }
}
