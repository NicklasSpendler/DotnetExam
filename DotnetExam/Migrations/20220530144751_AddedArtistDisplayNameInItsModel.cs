using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotnetExam.Migrations
{
    public partial class AddedArtistDisplayNameInItsModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c3f0dee-4843-4886-ab77-ee74e9630542", "AQAAAAEAACcQAAAAEF18rz+mPb5g2p0IBCw9TdtRgaBGWWONsnwxNVddT+P/vzEg7IJ6HdTaoavfOarVpA==", "8776cb17-f1f5-44d6-b65a-a3c4d118afd9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0ac6ece-32f3-47a5-9076-d593086951b8", "AQAAAAEAACcQAAAAEFdIb6valv8nLapKvNtY/42B+l7HLoo0C9zWv7hXor9CrThU5ZKliI84WgdrQc76wQ==", "d79fc239-d264-4b54-9c49-11cadcf17ec2" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 30, 16, 47, 50, 891, DateTimeKind.Local).AddTicks(5873));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
