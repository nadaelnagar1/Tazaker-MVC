using System.ComponentModel.DataAnnotations;

namespace Tazaker.Models
{
    public class Producer
    {
        [Key]
        public Guid Id { get; set; }
        public string ProfilePictureURL { get; set; } = "";
        public string FullName { get; set; } = "";
        public string Bio { get; set; } = "";
        public ICollection<Movie> Movies { get; set; }
    }
}
