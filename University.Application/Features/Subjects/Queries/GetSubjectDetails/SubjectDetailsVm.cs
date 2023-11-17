namespace University.Application.Features.Subjects.Queries.GetSubjectDetails
{
    public class SubjectDetailsVm
    {
        public Guid Id { get; set; }
        public string SubjectName { get; set; } = string.Empty;
        public int Rate { get; set; }
        public StudentDto Student { get; set; } = default!;
        public Guid StudentId { get; set; }
    }
}
