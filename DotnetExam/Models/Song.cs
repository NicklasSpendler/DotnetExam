namespace DotnetExam.Models
{
    public class Song
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public Artist artist { get; set; }
    }
}
