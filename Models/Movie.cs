using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tazaker.Data.Enums;
using Tazaker.Data.Repository.Generic;

namespace Tazaker.Models
{
    public class Movie :IEntityBase
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public double Price { get; set; }
        public string ImageURL { get; set; } = "";
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }
        public ICollection<Actor_Movies> Actor_Movies { get; set; }
        public Guid CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema? Cinema { get; set; }

        public Guid ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer? Producer { get; set; }


    }
}
