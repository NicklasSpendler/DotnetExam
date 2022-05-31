using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotnetExam.Migrations
{
    public partial class cascadeDeleteSongs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Song_Artist_ArtistId",
                table: "Song");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b00e655e-e98d-454c-bad9-c7d4f5a1cac9", "AQAAAAEAACcQAAAAEOgUCO9mWrs9ZPTrpCy0jI+Wiw1Eq6VsIuu2qXoCBuysspFQXn78adfD6uFuz8cflQ==", "cb28cea6-8177-4320-8cb5-3fb9d4364e6c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d65e67f2-fed0-441e-8e4b-0d123c33b167", "AQAAAAEAACcQAAAAEOEwOGahvjvpgyD9vQpam03gzMYoHl3Km8uFvGuL+xTlBYxUmqdB/lo/eLUZIYYl+w==", "5aebaf74-f23d-4b42-872a-2734f777662c" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 31, 17, 12, 24, 265, DateTimeKind.Local).AddTicks(166));

            migrationBuilder.AddForeignKey(
                name: "FK_Song_Artist_ArtistId",
                table: "Song",
                column: "ArtistId",
                principalTable: "Artist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Song_Artist_ArtistId",
                table: "Song");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0aa2cca6-476f-471b-a81b-2e917d0daf1a", "AQAAAAEAACcQAAAAEJYHRp4yNf5AGFKbgnUrOkUJ2uKiVm9w+4KxbX0E+KRVVbhKZ0ZI6PpND1FIGQPGKg==", "67e42bd8-6611-4c94-967f-2c2ff4fecf47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "645d0486-ba26-4d26-ba3c-9b8c2f3b196b", "AQAAAAEAACcQAAAAECApSBrkb4eEware1cEqJpPwG6hwRiii4yDOxvdXJtpuNeWMMozdULPKlJWv6zf7nw==", "dfe0a6ce-f871-4d88-abc4-e4eb7046703c" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 30, 14, 28, 48, 129, DateTimeKind.Local).AddTicks(5815));

            migrationBuilder.AddForeignKey(
                name: "FK_Song_Artist_ArtistId",
                table: "Song",
                column: "ArtistId",
                principalTable: "Artist",
                principalColumn: "Id");
        }
    }
}
