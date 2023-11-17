using AutoMapper;
using MediatR;
using University.Application.Contracts.Persistence;
using University.Domain.Entities;

namespace University.Application.Features.Students.Commands.CreateStudent
{
    public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly IStudentRepository _studentRepository;

        public CreateStudentCommandHandler(IMapper mapper, IStudentRepository studentRepository)
        {
            _mapper = mapper;
            _studentRepository = studentRepository;
        }

        public async Task<Guid> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            var student = _mapper.Map<Student>(request);

            student = await _studentRepository.AddAsync(student);

            return student.Id;
        }
    }
}
