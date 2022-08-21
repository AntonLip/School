using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using School.Models.DbModels;

namespace School.DataAccess
{
    public class DbContext : IdentityDbContext<AppUser, IdentityRole, string>
    {
        public DbContext(DbContextOptions<DbContext> options)
                : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Timetable> Timetable { get; set; }
        public DbSet<Grade> Grades{ get; set; }
        public DbSet<Discipline>Disciplines { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}
