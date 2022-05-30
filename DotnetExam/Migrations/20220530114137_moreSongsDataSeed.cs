using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotnetExam.Migrations
{
    public partial class moreSongsDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "Id", "ArtistId", "Name" },
                values: new object[,]
                {
                    { 2, 1, "Dårlig Sang Sang" },
                    { 3, 1, "Sindsyg Sang" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0fc41b8-caed-4e73-996f-df67341758c5", "AQAAAAEAACcQAAAAEILCVUrGntoGuRsBANXPpdwcjMLcYiJWmeDyGK7l9m+TaOC+pa5U7lcse7aF2S80Xw==", "d1b4c3d5-76a1-4596-bea0-e563c8a3d666" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98c55da6-66fc-4fca-a755-90e134df3af3", "AQAAAAEAACcQAAAAEFKuDrsEoGGGHjn9J0Xtt4RYaHJX9PAIaHAMzqTF43qx2cxDvx0TVDvyPTVnkjbiew==", "241f227d-bb46-464a-9b90-16abfe42c9a1" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 30, 13, 36, 20, 452, DateTimeKind.Local).AddTicks(3515));
        }
    }
}
