using System.ComponentModel.DataAnnotations;

namespace Tazaker.Models
{
    public class Actor
    {
        [Key]
        public Guid Id { get; set; }
        public string ProfilePictureURL { get; set; } = "";
        public string FullName { get; set; } = "";
        public string Bio { get; set; } = "";
        public ICollection<Actor_Movies> Actor_Movies { get; set; }
    }
}
