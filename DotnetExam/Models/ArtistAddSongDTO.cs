using Newtonsoft.Json;
namespace DotnetExam.Models
{
    public class ArtistAddSongDTO
    {
        public Artist ?Artist { get; set; }
        public int ?SongId { get; set; }
    }
}
