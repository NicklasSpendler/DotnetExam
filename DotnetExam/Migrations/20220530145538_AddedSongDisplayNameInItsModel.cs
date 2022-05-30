using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotnetExam.Migrations
{
    public partial class AddedSongDisplayNameInItsModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5047817-d03b-4d0a-9e27-466dbe4f2594", "AQAAAAEAACcQAAAAEKm5W9WbP0YkLrBb3Ka3vQ4l44suSOjqcZgwrfC4utq9f/2iDIMJ/QdodrKA9+cb0g==", "2fa78d61-fdf3-41c1-85d3-b7aebcaf79bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1f3ec11-aa5f-4de9-8a47-77fc132af5fb", "AQAAAAEAACcQAAAAEEd5m5N6KETcl4gD2aggL9LugOCaGNF6WE+YmqXzgczwhYu26D3vwy8Xzw+3aM7xBg==", "b770d186-1671-40f3-a9fa-18e8cee2b4a9" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 30, 16, 55, 38, 279, DateTimeKind.Local).AddTicks(5982));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
