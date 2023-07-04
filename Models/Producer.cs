using System.ComponentModel.DataAnnotations;
using Tazaker.Data.Repository.Generic;

namespace Tazaker.Models
{
    public class Producer : IEntityBase
    {
        [Key]
        public Guid Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "profile picture is required")]
        public string ProfilePictureURL { get; set; } = "";
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "fullname is required")]
        public string FullName { get; set; } = "";

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Bio is required")]

        public string Bio { get; set; } = "";
        public ICollection<Movie>? Movies { get; set; }
    }
}
