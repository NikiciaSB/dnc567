using Microsoft.EntityFrameworkCore;

namespace DNC567.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<User> Users {get;set;}
        public DbSet<Student> Students {get;set;}
        public DbSet<Instructor> Instructors {get;set;}

    }
}