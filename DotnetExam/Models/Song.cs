﻿using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DotnetExam.Models
{
    public class Song
    {
        public int Id { get; set; }

        [Required]
        public String Name { get; set; }
        [DisplayName("Artist")]
        public Artist ?artist { get; set; }

        [JsonIgnore]
        public List<Album> ?albums { get; set; }

        public List<Comment>? comments { get; set; }
        
    }
}
