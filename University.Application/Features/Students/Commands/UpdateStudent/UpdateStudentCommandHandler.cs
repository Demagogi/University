using AutoMapper;
using MediatR;
using University.Domain.Contracts.Persistence;
using University.Application.Features.Lectors.Commands.UpdateLector;
using University.Domain.Entities;

namespace University.Application.Features.Students.Commands.UpdateStudent
{
    public class UpdateStudentCommandHandler : IRequestHandler<UpdateStudentCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Student> _studentReposiotry;

        public UpdateStudentCommandHandler(IMapper mapper, IAsyncRepository<Student> studentReposiotry)
        {
            _mapper = mapper;
            _studentReposiotry = studentReposiotry;
        }

        public async Task<Unit> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            var studentToUpdate = await _studentReposiotry.GetByIdAsync(request.Id);

            _mapper.Map(request, studentToUpdate, typeof(UpdateLectorCommand), typeof(Student));

            await _studentReposiotry.UpdateAsync(studentToUpdate);
            
            return Unit.Value;
        }
    }
}
