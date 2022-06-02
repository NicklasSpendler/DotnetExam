using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotnetExam.Migrations
{
    public partial class freshstart3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Album",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "bobs Sange" },
                    { 2, "Space Jedi" }
                });

            migrationBuilder.InsertData(
                table: "Artist",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "No Artist" },
                    { 2, "Ted Sheeran" },
                    { 3, "Joke Loading..." },
                    { 4, "Dark Mode On" },
                    { 5, "Rubber Duck" },
                    { 6, "Claustrophobic astronaut" },
                    { 7, "Scrum" },
                    { 8, "Noobgrammer" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "5809a232-32e0-40dc-b700-7959625059af", "test1@test.dk", true, false, null, null, null, "AQAAAAEAACcQAAAAEI5IKu3G1TsZ3TFMvHLTYClogv0uDijvhot2eydoLdi3M6AzHHdOA5dBRbZLWhr0XA==", null, false, "b8c3af20-f0e0-4c04-93aa-2fa518fa6fed", false, "Jesper" },
                    { "2", 0, "fe85c753-df72-4b90-ad05-0abfa5214362", "test@gmail.dk", true, false, null, null, null, "AQAAAAEAACcQAAAAECEGe747yQvXcHmV9oXQ9DXTIkBMMiy/IjYXb1x0CJizASF9XiiWlDw7aMU3cVJhAA==", null, false, "a512b7b9-b3ad-478b-b7a4-1861cf6bf672", false, "Nicklas" }
                });

            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "Id", "ArtistId", "Name" },
                values: new object[,]
                {
                    { 1, 6, "Whole lotta Space" },
                    { 2, 6, "Diet - byte sized" },
                    { 3, 6, "JabbaScript" },
                    { 4, 5, "god Sang" },
                    { 5, 4, "Dårlig Sang Sang" },
                    { 6, 3, "Sindsyg Sang" },
                    { 7, 2, "god Sang" },
                    { 8, 2, "Dårlig Sang Sang" },
                    { 9, 3, "Sindsyg Sang" },
                    { 10, 3, "god Sang" },
                    { 11, 4, "Dårlig Sang Sang" },
                    { 12, 6, "Sindsyg Sang" }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "CommentId", "EventId", "SongId", "Text", "TimeStamp", "UserId" },
                values: new object[] { 1, null, 1, "Klaustrfobisk astronaut... Lol!", new DateTime(2022, 6, 2, 13, 3, 22, 970, DateTimeKind.Local).AddTicks(8307), "1" });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "CommentId", "EventId", "SongId", "Text", "TimeStamp", "UserId" },
                values: new object[] { 2, null, 1, "Give the man some SPACE!", new DateTime(2022, 6, 2, 13, 3, 22, 970, DateTimeKind.Local).AddTicks(8342), "2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
