using MediatR;

namespace University.Application.Features.Students.Queries.GetStudentWithSubjects
{
    public class GetStudentWIthSubjectsQuery: IRequest<StudentWithSubjectsVm>
    {
        public Guid Id { get; set; }
    }
}
