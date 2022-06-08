using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetExam.Models
{
    public class Song
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Song Name")]
        public string Name { get; set; }
        
        [DisplayName("Artist")]
        
        public Artist? artist { get; set; }
        public int? ArtistId { get; set; }

        
        [DisplayName("On Number(s) of Albums")]
        public List<Album>? albums { get; set; }
        [DisplayName("Comment(s)")]
        public List<Comment>? comments { get; set; }
        
    }
}
