using System.ComponentModel.DataAnnotations;

namespace Tazaker.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public Guid Id { get; set; }
        public Movie Movie { get; set; }
        public int Amount { get; set; }
        public String ShoppingCartId { get; set;}

    }
}
