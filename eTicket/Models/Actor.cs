using System.ComponentModel.DataAnnotations;

namespace eTicket.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Profile Picture")]
        [Required(ErrorMessage ="Profile picture is required")]
        public string ProfilePictureUrl { get; set; }

        [Display(Name ="Name")]
        [Required(ErrorMessage ="Name is required")]
        [StringLength(50, MinimumLength =3, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string FullName { get; set; }

        [Display(Name ="Biography")]
        [Required(ErrorMessage ="Biography is required")]
        public string Bio { get; set; }
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
