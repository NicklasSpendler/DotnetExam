//using Microsoft.AspNetCore.Identity;
//using System.ComponentModel.DataAnnotations;

//namespace DotnetExam.Models
//{
//    public class Event
//    {
//        public int Id { get; set; }
//        [Required]
//        [MinLength(3, ErrorMessage = "Title must be minimum 3 characters long.")]
//        public string Title { get; set; }
//        [Required]
//        [MinLength(10)]
//        public string? Text { get; set; }
//        [Required]
//        [DisplayFormat = "{0:d}"]
//        public DateTime StartDate { get; set; }
//        [Required]
//        [DisplayFormat = "{0:d}"]
//        public DateTime Enddate { get; set; }
//        [Required]
//        public string StartTime { get; set; }
//        [Required]
//        public string Endtime { get; set; }
//        [Required]
//        [MinLength(3, ErrorMessage ="Location must be at least 3 characters long.")]
//        public String Location { get; set; }
//        public Artist? artist { get; set; }
//        public EventStatus Status { get; set; }

//        public List<Comment> Comments { get; set; }

//        public string UserId { get; set; }
//        public IdentityUser? User { get; set; }

//    }
//}
