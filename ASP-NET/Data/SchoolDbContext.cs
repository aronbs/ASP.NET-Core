using ASP_NET.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace ASP_NET.Data
{
    public class SchoolDbContext : DbContext
    {
        public DbSet<Mark> Marks { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SchoolDB");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Group g1 = new Group { GroupId = 1, Name = "H22-FK1" };
            Group g2 = new Group { GroupId = 2, Name = "H22-FK2" };
            Group g3 = new Group { GroupId = 3, Name = "H22-FK3" };

            modelBuilder.Entity<Group>().HasData(g1);
            modelBuilder.Entity<Group>().HasData(g2);
            modelBuilder.Entity<Group>().HasData(g3);

            Subject s1 = new Subject { SubjectId = 1, Title = "Forritun" };
            Subject s2 = new Subject { SubjectId = 2, Title = "Hönnun" };
            Subject s3 = new Subject { SubjectId = 3, Title = "Gagnagrunnur" };

            modelBuilder.Entity<Subject>().HasData(s1);
            modelBuilder.Entity<Subject>().HasData(s2);
            modelBuilder.Entity<Subject>().HasData(s3);

            Student st1 = new Student { StudentId = 1, FirstName = "Arnar", LastName = "asdf1", GroupId = 1 };
            Student st2 = new Student { StudentId = 2, FirstName = "Björn", LastName = "asdf2", GroupId = 2 };
            Student st3 = new Student { StudentId = 3, FirstName = "Helga", LastName = "asdf3", GroupId = 3 };

            modelBuilder.Entity<Student>().HasData(st1);
            modelBuilder.Entity<Student>().HasData(st2);
            modelBuilder.Entity<Student>().HasData(st3);

            Teacher t1 = new Teacher { TeacherId = 1, FirstName = "Hjörtur", LastName = "Pálmi" };


            Teacher t2 = new Teacher { TeacherId = 2, FirstName = "Fannar", LastName = "asdfasdf" };
            modelBuilder.Entity<Teacher>().HasData(t2);
            modelBuilder.Entity<Teacher>().HasData(t1);
        }


    }
}
