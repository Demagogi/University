using AutoMapper;
using MediatR;
using University.Domain.Contracts.Persistence;

namespace University.Application.Features.Students.Queries.GetStudentWithSubjectsList
{
    public class GetStudentSubjectsListQueryHandler : IRequestHandler<GetStudentsWithSubjectsListQuery, List<StudentWithSubjectsListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IStudentRepository _studentRepository;

        public GetStudentSubjectsListQueryHandler(IMapper mapper, IStudentRepository studentRepository)
        {
            _mapper = mapper;
            _studentRepository = studentRepository;
        }

        public async Task<List<StudentWithSubjectsListVm>> Handle(GetStudentsWithSubjectsListQuery request, CancellationToken cancellationToken)
        {

            var students = await _studentRepository.GetStudentsWithSubjects();
       
            return _mapper.Map<List<StudentWithSubjectsListVm>>(students);


        }
    }
}
