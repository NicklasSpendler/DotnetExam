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
        public DotnetExamContext (DbContextOptions<DotnetExamContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedSongs(builder);
            SeedArtists(builder);
            SeedComment(builder);
            SeedAlbum(builder);
            UsersSeed(builder);
        }

        public void SeedSongs(ModelBuilder builder)
        {
            var song1  = new Song { Id = 1,  Name = "Whole lotta Space", ArtistId = 6};
            var song2  = new Song { Id = 2,  Name = "Diet - byte sized", ArtistId = 6};
            var song3  = new Song { Id = 3,  Name = "JabbaScript", ArtistId = 6};
            var song4  = new Song { Id = 4,  Name = "Dress: Code", ArtistId = 5};
            var song5  = new Song { Id = 5,  Name = "Language: Sí++", ArtistId = 4 };
            var song6  = new Song { Id = 6,  Name = "Refuse to Comment", ArtistId = 3 };
            var song7  = new Song { Id = 7,  Name = "Señor Developer", ArtistId = 2 };
            var song8  = new Song { Id = 8,  Name = "Blind people cant C#", ArtistId = 2 };
            var song9  = new Song { Id = 9,  Name = "Not pro, just Grammer", ArtistId = 3 }; 
            var song10 = new Song { Id = 10, Name = "Table for 1 - But you are 2?!", ArtistId = 3 };
            var song11 = new Song { Id = 11, Name = "Light mode attracts Bugs", ArtistId = 4 };
            var song12 = new Song { Id = 12, Name = "Problems committing", ArtistId = 6};

            /*, albums = new List<Album>() { new Album() { Id = 2 } } */


            builder.Entity<Song>().HasData(song1, song2, song3, song4, song5, song6, song7, song8, song9, song10, song11, song12);
        }

        public void SeedAlbum(ModelBuilder builder)
        {
            var album1 = new Album { Id = 1, Name = "bobs Sange" };
            var album2 = new Album { Id = 2, Name = "Space Jedi" };

            builder.Entity<Album>().HasData(album1, album2);
        }

        private void SeedArtists(ModelBuilder builder)
        {

            var artist1 = new Artist() { Id = 1, Name = "No Artist" };
            var artist2 = new Artist() { Id = 2, Name = "Ted Sheeran" };
            var artist3 = new Artist() { Id = 3, Name = "Joke Loading..." };
            var artist4 = new Artist() { Id = 4, Name = "Dark Mode On" };
            var artist5 = new Artist() { Id = 5, Name = "Rubber Duck" };
            var artist6 = new Artist() { Id = 6, Name = "Claustrophobic astronaut" };
            var artist7 = new Artist() { Id = 7, Name = "Scrum" };
            var artist8 = new Artist() { Id = 8, Name = "Noobgrammer" };

            builder.Entity<Artist>().HasData(artist1, artist2, artist3, artist4, artist5, artist6, artist7, artist8);
        }

        private void SeedComment(ModelBuilder builder)
        {
            var comment1 = new Comment { CommentId = 1, Text="Klaustrfobisk astronaut... Lol!", TimeStamp = DateTime.Now, SongId = 1, UserId = "1"};
            var comment2 = new Comment { CommentId = 2, Text = "Give the man some SPACE!", TimeStamp = DateTime.Now, SongId = 1, UserId = "2" };


            builder.Entity<Comment>().HasData(comment1, comment2);
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
