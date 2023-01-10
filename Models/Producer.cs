using System.ComponentModel.DataAnnotations;
using Tazaker.Data.Repository.Generic;

namespace Tazaker.Models
{
    public class Producer:IEntityBase
    {
        [Key]
        public Guid Id { get; set; }
        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; } = "";
        [Display(Name = "Full Name")]
        public string FullName { get; set; } = "";
        [Display(Name = "Biography")]
        public string Bio { get; set; } = "";
        public ICollection<Movie> Movies { get; set; }
    }
}
