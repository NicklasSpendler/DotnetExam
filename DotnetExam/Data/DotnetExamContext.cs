#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DotnetExam.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DotnetExam.Data
{
    public class DotnetExamContext : IdentityDbContext
    {
        public DotnetExamContext (DbContextOptions<DotnetExamContext> options)
            : base(options)
        {
        }

        public DbSet<DotnetExam.Models.Artist> Artist { get; set; }

        public DbSet<DotnetExam.Models.Album> Album { get; set; }

        public DbSet<DotnetExam.Models.Song> Song { get; set; }

        public DbSet<DotnetExam.Models.Comment>? Comment { get; set; }
    }
}
