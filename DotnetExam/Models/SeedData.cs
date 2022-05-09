using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DotnetExam.Data;
using System;
using System.Linq;

namespace DotnetExam.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DotnetExamContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DotnetExamContext>>()))
            {
                // Look for any movies.
                if (context.Artist.Any())
                {
                    return;   // DB has been seeded
                }

                context.Artist.AddRange(
                    new Artist
                    {
                        Name = "Bob"
                    },

                    new Artist
                    {
                        Name = "Henning"
                    },

                    new Artist
                    {
                        Name = "Bente"
                    },

                    new Artist
                    {
                        Name = "Jørgen"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}