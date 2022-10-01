using System.ComponentModel.DataAnnotations;

namespace eTicket.Models
{
    public class Producer
    {
        public int Id { get; set; }
        [Display(Name ="Profile Picture")]
        public string ProfilePictureUrl { get; set; }
        [Display(Name ="Name")]
        public string FullName { get; set; }
        [Display(Name ="Biography")]
        public string Bio { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}
