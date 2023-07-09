using System.ComponentModel.DataAnnotations;
using Tazaker.Data.Repository.Generic;

namespace Tazaker.Models
{
    public class Cinema:IEntityBase
    {
        [Key]
        public Guid Id { get; set; }
        [Display(Name ="Cinema Logo")]
        public string Logo { get; set; } = "";
        [Display(Name = "Name")]
        public string Name { get; set; } = "";
        [Display(Name = "Description")]
        public string Description { get; set; } = "";

        public ICollection<Movie> Movies { get; set; }
    }
}
