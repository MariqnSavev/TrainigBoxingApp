namespace TrainigBoxingApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty; // Инициализация
        public string Password { get; set; } = string.Empty; // Инициализация
        public ICollection<Workout> Workouts { get; set; } = new List<Workout>(); // Инициализация
    }
}
