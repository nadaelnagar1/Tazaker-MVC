using System.ComponentModel.DataAnnotations;
using Tazaker.Data.Repository.Generic;

namespace Tazaker.Models
{
    public class Cinema:IEntityBase
    {
        [Key]
        public Guid Id { get; set; }
        [Display(Name ="Cinema Logo")]
        [Required (ErrorMessage ="cinema logo is required")]
        public string Logo { get; set; } = "";
        [Display(Name = "Name")]
        [Required(ErrorMessage = "cinema Name is required")]
        public string Name { get; set; } = "";

        [Display(Name = "Description")]
        [Required(ErrorMessage = "cinema description is required")]
        public string Description { get; set; } = "";

        public ICollection<Movie>? Movies { get; set; }
    }
}
