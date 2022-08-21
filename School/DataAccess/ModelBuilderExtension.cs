using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using School.Models.DbModels;

namespace School.DataAccess
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            SeedRoles(modelBuilder);
            SeedUsers(modelBuilder);

            SeedUserRoles(modelBuilder);
        }

        static Guid userId = Guid.NewGuid();
        static Guid roleId = Guid.NewGuid();

      
        private static void SeedUsers(ModelBuilder builder)
        {
            AppUser user = new AppUser()
            {
                Id = userId.ToString(),
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                EmailConfirmed = true,
                ConcurrencyStamp = "avadvd",
                Email = "admin@gmail.com",
                LockoutEnabled = false,
                TwoFactorEnabled = false,
                SecurityStamp = "avebgdfvs",
                PhoneNumber = "1234567890",
                FirstName = "Admin",
                LastName = "Adminov"
            };

            PasswordHasher<AppUser> passwordHasher = new PasswordHasher<AppUser>();
            var str = passwordHasher.HashPassword(user, "2732011Qw!");
            user.PasswordHash = str;
            builder.Entity<AppUser>().HasData(user);
        }

        private static void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole()
                {
                    Id = roleId.ToString(),
                    Name = "Admin",
                    ConcurrencyStamp = "1",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Teacher",
                    ConcurrencyStamp = "2",
                    NormalizedName = "TEACHER"
                },
                new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Pupil",
                    ConcurrencyStamp = "3",
                    NormalizedName = "PUPIL"
                },
                new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Parent",
                    ConcurrencyStamp = "4",
                    NormalizedName = "PARENT"
                });
        }

        private static void SeedUserRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>()
                {
                    RoleId = roleId.ToString(),
                    UserId = userId.ToString()
                });
        }
    }

}
