namespace DotnetExam.Models
{
    public class SongAlbumListDTO
    {
        public Song Song { get; set; }

        public List<int>? AlbumIds { get; set; }
    }
}
