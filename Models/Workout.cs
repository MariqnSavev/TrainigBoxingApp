namespace TrainigBoxingApp.Models
{
    public class Workout
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } // Дата на тренировката
        public string Type { get; set; } = string.Empty; // Тип на тренировката
        public int Duration { get; set; } // Продължителност в минути
        public string Notes { get; set; } = string.Empty; // Допълнителни бележки
        public string Description { get; set; } = string.Empty; // Описание на тренировката
        public int UserId { get; set; } // ID на потребителя
        public User User { get; set; } // Връзка с модела User
    }
}
