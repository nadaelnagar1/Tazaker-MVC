using System.ComponentModel.DataAnnotations;

namespace Tazaker.Models
{
    public class Actor
    {
        [Key]
        public Guid Id { get; set; }
        [Display(Name ="Profile Picture")]
        public string ProfilePictureURL { get; set; } = "";
        [Display(Name = "Full Name")]
        public string FullName { get; set; } = "";
        [Display(Name = "Biography")]
        public string Bio { get; set; } = "";
        public ICollection<Actor_Movies> Actor_Movies { get; set; }
    }
}
