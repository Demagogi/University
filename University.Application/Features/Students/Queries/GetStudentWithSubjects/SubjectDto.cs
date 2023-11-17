namespace University.Application.Features.Students.Queries.GetStudentWithSubjects
{
    public class SubjectDto
    {
        public Guid Id { get; set; }
        public string SubjectName { get; set; } = string.Empty;
        public int Rate { get; set; }
    }
}
