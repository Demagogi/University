using MediatR;

namespace University.Application.Features.Subjects.Commands.CreateSubject
{
    public class CreateSubjectCommand : IRequest<Guid>
    {
        public string SubjectName { get; set; } = string.Empty;
        public int Rate { get; set; }
        public Guid StudentId { get; set; }

        public override string ToString()
        {
            return $"Student: {StudentId}\nSubject Name: {SubjectName}\nRate: {Rate}";
        }
    }
}
