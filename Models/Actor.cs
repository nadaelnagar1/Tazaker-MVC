﻿using System.ComponentModel.DataAnnotations;

namespace Tazaker.Models
{
    public class Actor
    {
        [Key]
        public Guid? Id { get; set; }
        [Display(Name ="Profile Picture")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string ProfilePictureURL { get; set; } = "";
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Full Name must be between 3 and 50 letters")]
        public string FullName { get; set; } = "";
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; } = "";
        public ICollection<Actor_Movies>? Actor_Movies { get; set; }
    }
}
