using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotnetExam.Migrations
{
    public partial class noArtistSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "No Artist");

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
                value: new DateTime(2022, 5, 30, 14, 21, 24, 50, DateTimeKind.Local).AddTicks(3456));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Bob");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b43fdf0a-dfe4-49b8-8870-01ba8c6d872b", "AQAAAAEAACcQAAAAEN1yKYiar0nxe2epISD2g/Z0Z4SOgiO8zweEiU8j+W0Core1cw6g5HJ/6/gjW2GE2Q==", "6c75f031-4045-4117-af12-aa9b928605bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95f2f836-cfbe-41a6-aa12-213dbda9e1d5", "AQAAAAEAACcQAAAAELljsdHZTdw0HsJewZp8l+qtdP2bu3HdZSOUy3hXpFSSOgOKAIsbc1TGS1Kugi/L0A==", "dc3a8b87-f2c7-4bc0-8153-fe3cb051044c" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 30, 13, 41, 37, 256, DateTimeKind.Local).AddTicks(6150));
        }
    }
}
