namespace University.Domain.Entities
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Subject> Subjects { get; set; } = new List<Subject>();
    }
}
