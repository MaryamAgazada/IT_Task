using Microsoft.EntityFrameworkCore;
using Task.Models;

namespace Task.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Website Models Section
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<ContactUs> Contacts {  get; set; }

        // One-To-Many Relation Section
        public DbSet<Book> Books { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
    }
}
