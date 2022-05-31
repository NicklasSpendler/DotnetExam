using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotnetExam.Migrations
{
    public partial class cascadeDeleteArtist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "daaf0675-5333-42cf-ae6a-069ef0698329", "AQAAAAEAACcQAAAAELIJQOhVcMbX+0KNG2AHBSkDxEEm/l91kMxMO8STMbWWx/QwEBjAooTLx/QWM1HQmA==", "309a8f5d-0f71-419e-977f-083cc16c685c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6dd9f30-ccbc-42e1-b794-40ead3e6fdbc", "AQAAAAEAACcQAAAAECTOFXKVUgx15z09eMWf1ocrK17iTjeiWCQeKgoT6glxCE4YliZa8tFj/kr8WZ+x1Q==", "707df4ba-97d0-4453-ac8d-2d872d8cee77" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 31, 17, 29, 9, 569, DateTimeKind.Local).AddTicks(3083));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
