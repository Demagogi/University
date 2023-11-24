using AutoMapper;
using MediatR;
using University.Domain.Contracts.Persistence;
using University.Domain.Entities;

namespace University.Application.Features.Students.Queries.GetStudentWithSubjects
{
    public class GetStudentWithSubjectsQueryCommand : IRequestHandler<GetStudentWIthSubjectsQuery, StudentWithSubjectsVm>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Student> _studentRepository;
        private readonly ISubjectRepository _subjectRepository;

        public GetStudentWithSubjectsQueryCommand(IMapper mapper, IAsyncRepository<Student> studentRepository, ISubjectRepository subjectRepository)
        {
            _mapper = mapper;
            _studentRepository = studentRepository;
            _subjectRepository = subjectRepository;

        }

        public async Task<StudentWithSubjectsVm> Handle(GetStudentWIthSubjectsQuery request, CancellationToken cancellationToken)
        {
            var student = await _studentRepository.GetByIdAsync(request.Id);

            var studentSubjects = await _subjectRepository.GetByStudentId(student.Id);

            var subjectDtos = _mapper.Map<List<SubjectDto>>(studentSubjects);

            var studentVm = _mapper.Map<StudentWithSubjectsVm>(student);

            studentVm.Subjects = subjectDtos;

            return studentVm;
        }
    }
}
