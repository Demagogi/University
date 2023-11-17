using Microsoft.EntityFrameworkCore;
using University.Domain.Entities;

namespace University.Persistance
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options) : base(options)
        {
            
        }

        public DbSet<Lector> Lectors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UniversityDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
