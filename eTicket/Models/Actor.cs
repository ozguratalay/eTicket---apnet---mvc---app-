using System.ComponentModel.DataAnnotations;

namespace eTicket.Models
{
    public class Actor
    {
        public int Id { get; set; }

        [Display(Name ="Profile Picture")]
        [Required(ErrorMessage ="Profile picture is required")]
        public string ProfilePictureUrl { get; set; }

        [Display(Name ="Full Name")]
        [Required(ErrorMessage ="Full Name is required")]
        [StringLength(50, MinimumLength =3, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string FullName { get; set; }

        [Display(Name ="Biography")]
        [Required(ErrorMessage ="Biography is required")]
        public string Bio { get; set; }
        public ICollection<Actor_Movie> Actor_Movies { get; set; }
    }
}
