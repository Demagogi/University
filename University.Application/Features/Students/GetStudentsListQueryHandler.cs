using AutoMapper;
using MediatR;
using University.Application.Contracts.Persistence;
using University.Domain.Entities;

namespace University.Application.Features.Students
{
    internal class GetStudentsListQueryHandler : IRequestHandler<GetStudentsListQuery, List<StudentsListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Student> _studentRepository;

        public GetStudentsListQueryHandler(IMapper mapper, IAsyncRepository<Student> studentRepository)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _studentRepository = studentRepository ?? throw new ArgumentNullException(nameof(studentRepository));
        }

        public async Task<List<StudentsListVm>> Handle(GetStudentsListQuery request, CancellationToken cancellationToken)
        {
            var allStudents = await _studentRepository.GetAllAsync();
            return _mapper.Map<List<StudentsListVm>>(allStudents);
        }
    }
}
