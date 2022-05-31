using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotnetExam.Migrations
{
    public partial class changedPositionOfEnumEventStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d630583-51d5-4d8e-ac68-fe99a98ece7b", "AQAAAAEAACcQAAAAEC3VpwNQLmTIcGgaRED8fymVtACt8fPr8oyYUb3L9WSYUJpWmLMebAQk2hG6/JUAaQ==", "50e39d36-206a-4d44-b53d-d5962e028776" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98fcb9d9-1f02-4e93-b9ea-873a342afe23", "AQAAAAEAACcQAAAAECLBOVmbDX81p8cjSjQ/sb5gcjlE4ij21otgofRur1uphXOWY8wweZmoQ7hIXLdI8A==", "7b35bca9-2490-46c6-9c76-c208d06b8399" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 30, 14, 28, 48, 129, DateTimeKind.Local).AddTicks(5815));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f28248da-3972-4617-9c88-2ffdb8f68086", "AQAAAAEAACcQAAAAEPlCmKso44xOCll7MLJsycTYvZkob5Gv7Oz5wj9VILcv/p5RtTqWxpWrPZK/17VmjA==", "e65b7d5e-762a-4785-b9f7-e328e218534e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e06e7083-b70d-4d04-95f7-9d49eefe0072", "AQAAAAEAACcQAAAAEAgXwU9Fn0QIlCCzGcE+3l1i3LMA6Rc+8XcRv64hZWOijVgiTbRYsvj+pC3rxUpQxQ==", "08b482e7-c7d4-4fac-b7ae-47de908c8929" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 30, 14, 23, 58, 325, DateTimeKind.Local).AddTicks(8763));
        }
    }
}
