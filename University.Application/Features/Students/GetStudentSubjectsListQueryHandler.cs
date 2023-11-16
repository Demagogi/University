using AutoMapper;
using MediatR;
using University.Application.Contracts.Persistence;
using University.Domain.Entities;

namespace University.Application.Features.Students
{
    public class GetStudentSubjectsListQueryHandler : IRequestHandler<GetStudentSubjectsListQuery, List<StudentSubjectsListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Student> _studentRepository;
        private readonly IAsyncRepository<Subject> _subjectRepository;

        public GetStudentSubjectsListQueryHandler(IMapper mapper, IAsyncRepository<Student> studentRepository, IAsyncRepository<Subject> subjectRepository)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _studentRepository = studentRepository ?? throw new ArgumentNullException(nameof(_studentRepository));
            _subjectRepository = subjectRepository ?? throw new ArgumentNullException(nameof(_subjectRepository));
        }

        public async Task<List<StudentSubjectsListVm>> Handle(GetStudentSubjectsListQuery request, CancellationToken cancellationToken)
        {

            var student = await _studentRepository.GetByIdAsync(request.Id);
            var subjects = student.Subjects; // აქ ესე დავტოვო, თუ რამე სხვანაირად ვქნა, მაგალითად რეპოზიტორიაში ჩავამატო რამე მეთოდი

            return _mapper.Map<List<StudentSubjectsListVm>>(subjects);


        }
    }
}
