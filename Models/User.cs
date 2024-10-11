using System.ComponentModel.DataAnnotations;

namespace TrainigBoxingApp.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Имейлът е задължителен.")]
        [EmailAddress(ErrorMessage = "Невалиден имейл адрес.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Името е задължително.")]
        public string FullName { get; set; } // Име на свойството
    }
}