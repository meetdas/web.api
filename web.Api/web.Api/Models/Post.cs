using System.ComponentModel.DataAnnotations;

namespace web.Api.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Input the title"),Display(Name ="Title")]
        public string  Title { get; set; }

        [Required(ErrorMessage = "Input the description"), Display(Name = "description"), MaxLength]
        public string  Description { get; set; }
        public DateTime CreateDate { get; set; }=DateTime.Now;
    }
}
