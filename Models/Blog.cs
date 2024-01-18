using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Models
{
    public class Blog
    {
        public int BlogId { get; set; }

        [Required]
        public string BlogSubject { get; set; }

        [Required]
        public string BlogContent { get; set; }

        public DateTime PostedDate { get; set; }

        [Required]
        public string AuthorName { get; set; }

        [Required]
        public string BlogCategory { get; set; }
    }
}