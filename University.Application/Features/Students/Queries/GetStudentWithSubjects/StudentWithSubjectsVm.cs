using University.Application.Features.Students.Queries.GetStudentWithSubjectsList;

namespace University.Application.Features.Students.Queries.GetStudentWithSubjects
{
    public class StudentWithSubjectsVm
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<SubjectDto>? Subjects { get; set; }
    }
}
