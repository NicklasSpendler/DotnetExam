using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DotnetExam.Models;

    public class Comment
    {
        public int CommentId { get; set; }

        [Required(ErrorMessage = "Please fill out title")]
        [MinLength(3, ErrorMessage = "Minimum 3 characters")]
        public string Text { get; set; }
        public DateTime TimeStamp { get; set; }
        public int SongId { get; set; }
        public Song? Song { get; set; }
        public string? UserId { get; set; }
        public IdentityUser? user { get; set; }
    }