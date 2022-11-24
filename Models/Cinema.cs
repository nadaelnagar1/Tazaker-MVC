using System.ComponentModel.DataAnnotations;

namespace Tazaker.Models
{
    public class Cinema
    {
        [Key]
        public Guid Id { get; set; }
        public string Logo { get; set; } = "";
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";

        public ICollection<Movie> Movies { get; set; }
    }
}
