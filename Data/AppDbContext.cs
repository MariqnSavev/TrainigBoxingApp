using Microsoft.EntityFrameworkCore;
using TrainigBoxingApp.Models;

namespace TrainigBoxingApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Workout> Workouts { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Примерни данни
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "testuser", Password = "password123" }
            );

            modelBuilder.Entity<Workout>().HasData(
                new Workout
                {
                    Id = 1,
                    Date = DateTime.Now,
                    Type = "Бокс",
                    Duration = 60,
                    Notes = "Интензивна тренировка",
                    Description = "Тренировка за техника",
                    UserId = 1 // Свързване с тестовия потребител
                }
            );
        }
    }
}