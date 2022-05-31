#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DotnetExam.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace DotnetExam.Data
{
    public class DotnetExamContext : IdentityDbContext
    {
        public DotnetExamContext (DbContextOptions<DotnetExamContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            UsersSeed(builder);
            SeedSongs(builder);
            SeedArtists(builder);
            SeedComment(builder);
            SeedAlbum(builder);

            builder.Entity<Artist>().HasMany(a => a.Songs).WithOne(s => s.artist).HasForeignKey(s => s.ArtistId).OnDelete(DeleteBehavior.Cascade);
            
            //model.Entity<Post>().HasOne(p => p.Blog).WithMany(b => b.Posts)
            //.HasForeignKey(p => p.BlogId)
            //.OnDelete(DeleteBehavior.Cascade);
        }

        public void SeedSongs(ModelBuilder builder)
        {
            var song1 = new Song {Id = 1, Name = "god Sang" };
            var song2 = new Song {Id = 2, Name = "Dårlig Sang Sang", ArtistId = 1 };
            var song3 = new Song {Id = 3, Name = "Sindsyg Sang", ArtistId = 1};

            builder.Entity<Song>().HasData(song1, song2, song3);
        }

        public void SeedAlbum(ModelBuilder builder)
        {
            var album1 = new Album { Id = 1, Name = "bobs Sange" };

           builder.Entity<Album>().HasData(album1);
        }

        private void SeedArtists(ModelBuilder builder)
        {

            var artist1 = new Artist() { Id = 1, Name = "No Artist" };
            builder.Entity<Artist>().HasData(artist1);
        }

        private void SeedComment(ModelBuilder builder)
        {
            var comment1 = new Comment { CommentId = 1, Text="SeedData :)", TimeStamp = DateTime.Now, SongId = 1, UserId = "1"};


            builder.Entity<Comment>().HasData(comment1);
        }

        private void UsersSeed(ModelBuilder builder)
        {
            var user1 = new IdentityUser
            {
                Id = "1",
                Email = "test1@test.dk",
                EmailConfirmed = true,
                UserName = "Jesper",
            };
            PasswordHasher<IdentityUser> passHash = new PasswordHasher<IdentityUser>();
            user1.PasswordHash = passHash.HashPassword(user1, "Password1#");

            var user2 = new IdentityUser
            {
                Id = "2",
                Email = "test@gmail.dk",
                EmailConfirmed = true,
                UserName = "Nicklas",
            };
            PasswordHasher<IdentityUser> pass2Hash = new PasswordHasher<IdentityUser>();
            user2.PasswordHash = pass2Hash.HashPassword(user2, "P4ssword!");

            builder.Entity<IdentityUser>().HasData(user1, user2);
        }



        public DbSet<DotnetExam.Models.Artist> Artist { get; set; }

        public DbSet<DotnetExam.Models.Album> Album { get; set; }

        public DbSet<DotnetExam.Models.Song> Song { get; set; }

        public DbSet<DotnetExam.Models.Comment>? Comment { get; set; }

        public DbSet<DotnetExam.Models.Event>? Event { get; set; }
    }






}
