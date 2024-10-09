namespace TrainigBoxingApp.Models
{
    public class Workout
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public ICollection<Workout> Workouts { get; set; }
    }
}
