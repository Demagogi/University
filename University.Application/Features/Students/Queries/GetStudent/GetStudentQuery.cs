using MediatR;

namespace University.Application.Features.Students.Queries.GetStudent
{
    public class GetStudentQuery: IRequest<StudentVm>
    {
        public Guid Id { get; set; }
    }
}
