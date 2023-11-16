namespace University.Application.Features.Students.Queries.GetStudentWithSubjectsList
{
    public class StudentWithSubjectsDto
    {
        public Guid Id { get; set; }
        public string SubjectName { get; set; } = string.Empty;
        public int Rate { get; set; }
        public Guid StudentId { get; set; }
    }
}