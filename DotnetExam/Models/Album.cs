using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace DotnetExam.Models
{
    public class Album
    {
        public int Id { get; set; }

        public String Name { get; set; }

        [JsonIgnore]
        public List<Song> ?Songs { get; set; }

    }

}
