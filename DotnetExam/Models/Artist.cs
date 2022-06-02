using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DotnetExam.Models
{
    public class Artist
    {
        public int Id { get; set; }
        
        [Required]
        [DisplayName("Artist name")] //Added til test i song/details
        public string Name { get; set; }

        [JsonIgnore]
        public List<Song> ?Songs { get; set; }
    }
}
