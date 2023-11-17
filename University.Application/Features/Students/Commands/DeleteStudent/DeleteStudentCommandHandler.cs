using AutoMapper;
using MediatR;
using University.Application.Contracts.Persistence;
using University.Domain.Entities;

namespace University.Application.Features.Students.Commands.DeleteStudent
{
    public class DeleteStudentCommandHandler : IRequestHandler<DeleteStudentCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Student> _studentRepository;

        public DeleteStudentCommandHandler(IMapper mapper, IAsyncRepository<Student> studentRepository)
        {
            _mapper = mapper;
            _studentRepository = studentRepository;
        }

        public async Task<Unit> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            var studentToDelete = await _studentRepository.GetByIdAsync(request.Id);

            await _studentRepository.DeleteAsync(studentToDelete);

            return Unit.Value;
        }
    }
}
