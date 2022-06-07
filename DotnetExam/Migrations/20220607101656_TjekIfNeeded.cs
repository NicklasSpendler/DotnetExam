using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotnetExam.Migrations
{
    public partial class TjekIfNeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef3d33b3-b124-4608-85a9-3c7a7f6e57ac", "AQAAAAEAACcQAAAAED9WJqnpiyZ1A690H1WnkX493YbJmMnCj1UsAn/7v/CcCddVQmjDUgXeZcjBvigm0g==", "1400f75c-2ea2-448e-b227-af4bc578e39a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fd678b2-b39c-45a2-a156-cf1640f32375", "AQAAAAEAACcQAAAAEALEqr8i5QLvLn18/N51PVkcL8t04UbYkP7rJ0Ykc3/fsrWLycmdUwe9mgwRejFC8w==", "f2831156-5def-45e0-8f50-5f76a4fdd93d" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 7, 12, 16, 56, 294, DateTimeKind.Local).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 7, 12, 16, 56, 294, DateTimeKind.Local).AddTicks(841));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fbd46e0a-dc77-462a-bdc2-25e1a6f08290", "AQAAAAEAACcQAAAAEPsX/YIZDh5Xwbi6zcvkU30EJ/dW0I1HCb/TosTB0R97tBfr6KXupMTKUGzp3d73cg==", "9e9d4130-b2f7-4959-ae0f-9bbbee63574e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0021494b-1aa2-4869-a420-7f44dc4b0c43", "AQAAAAEAACcQAAAAEL3Hq87/vuqT8m0zlOywk3JpKlCJaVniripgEyWKBXvWEkCrwhwMVJDNzePz1CcLQQ==", "69ab7edd-5d2d-47d2-acc6-33b04f337f81" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 6, 13, 34, 2, 511, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 6, 13, 34, 2, 511, DateTimeKind.Local).AddTicks(3485));
        }
    }
}
