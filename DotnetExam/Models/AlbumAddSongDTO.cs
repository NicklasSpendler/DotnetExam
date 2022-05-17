using Newtonsoft.Json;
namespace DotnetExam.Models
{
    public class AlbumAddSongDTO
    {
        public int Id { get; set; }

        public String Name { get; set; }
        [JsonIgnore]
        public List<Song>? Songs { get; set; }
        public int SongId { get; set; }
    }
}
