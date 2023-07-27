using System.ComponentModel.DataAnnotations;
using Tazaker.Data.Enums;

namespace Tazaker.Models
{
    public class NewMovieVM
    {

        public Guid Id { get; set; }

        [Display(Name = "Movie name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = "";

        [Display(Name = "Movie Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; } = "";

        [Display(Name = "Movie Price")]
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }

        [Display(Name = "Movie ImageURL")]
        [Required(ErrorMessage = "ImageURL is required")]
        public string ImageURL { get; set; } = "";

        [Display(Name = "Movie Start Date")]
        [Required(ErrorMessage = "Start Date is required")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Movie End Date")]
        [Required(ErrorMessage = "End Date is required")]
        public DateTime EndDate { get; set; }

        [Display(Name = "select a category")]
        [Required(ErrorMessage = "Movie Category is required")]
        public MovieCategory MovieCategory { get; set; }

        [Display(Name = "select actor(s)")]
        [Required(ErrorMessage = "Movie actor(s) is required")]
        public ICollection<Guid> ActorIds { get; set; }

        [Display(Name = "Select a cinema")]
        [Required(ErrorMessage = "Movie cinema is required")]
        public Guid CinemaId { get; set; }

        [Display(Name = "Select a producer")]
        [Required(ErrorMessage = "Movie Producer is required")]
        public Guid ProducerId { get; set; }
  
    }
}
