namespace University.Domain.Entities
{
    public class Subject
    {
        public Guid Id { get; set; }
        public string SubjectName { get; set; } = string.Empty;
        public int Rate { get; set; }
        public Student Student { get; set; } = default!;
        public Guid StudentId { get; set; }
    }
}
