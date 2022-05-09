#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DotnetExam.Models;

namespace DotnetExam.Data
{
    public class DotnetExamContext : DbContext
    {
        public DotnetExamContext (DbContextOptions<DotnetExamContext> options)
            : base(options)
        {
        }

        public DbSet<DotnetExam.Models.Artist> Artist { get; set; }
    }
}
