using Microsoft.AspNetCore.Identity;

namespace DotnetExam.Models;

    public class Comment
    {
        public int CommentId { get; set; }
        public string Text { get; set; }
        public DateTime TimeStamp { get; set; }
        public int SongId { get; set; }
        public Song Song { get; set; }
        public string UserId { get; set; }
        public IdentityUser? user { get; set; }
        
    }

