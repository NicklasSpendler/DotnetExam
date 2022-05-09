using System.ComponentModel.DataAnnotations;

namespace DotnetExam.Models
{
    public class Artist
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
    }
}
