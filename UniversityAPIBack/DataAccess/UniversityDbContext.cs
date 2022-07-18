using Microsoft.EntityFrameworkCore;
using UniversityAPIBack.Models.DataModel;

namespace UniversityAPIBack.DataAccess
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options) : base(options)
        {

        }

        //To do Add DbSets
        public DbSet<User>? Users { get; set; }

        public DbSet<Course>? Courses { get; set; }

        public DbSet<Category>? Categories { get; set; }

        public DbSet<Student>? Students { get; set; }

        public DbSet<Chapter>? Chapters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 

        }

    }
}
