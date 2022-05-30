using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotnetExam.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Endtime",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "Event");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Endtime",
                table: "Event",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StartTime",
                table: "Event",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fd4fedd-55b2-46cc-b894-214bbb0a1d6e", "AQAAAAEAACcQAAAAEP1Az5cJwb4SqhRnrRYtW2TVrjPHv+f6r/Ym34LoZ28LDPtIHucAA9K9L19ffvGcJQ==", "811d1222-b561-4656-ba6d-4698f859b1e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81208ff4-f6b4-4ad7-ad82-c08e415d6736", "AQAAAAEAACcQAAAAEGStSgjcSqiloFiBq6BlrMVD9fRj/XSznPjbG2noabBtNJzRohPbqmz3gKV/S8kBBA==", "cef50818-81f6-40da-904b-f7107e779452" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 30, 14, 12, 47, 701, DateTimeKind.Local).AddTicks(5691));
        }
    }
}
