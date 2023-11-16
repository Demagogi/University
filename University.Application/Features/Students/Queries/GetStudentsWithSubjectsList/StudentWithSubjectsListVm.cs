namespace University.Application.Features.Students.Queries.GetStudentWithSubjectsList
{
    public class StudentWithSubjectsListVm
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<StudentWithSubjectsDto>? Subjects { get; set; }
    }
}