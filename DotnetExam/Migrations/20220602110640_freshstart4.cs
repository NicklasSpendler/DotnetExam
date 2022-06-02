using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotnetExam.Migrations
{
    public partial class freshstart4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf114cbf-cf32-473a-9af6-3785d6c87d01", "AQAAAAEAACcQAAAAEAeFZd+QqmSUcLvW2Ttbv19rJ+x5N4OJNBn5IOJwXwL0lh4um7NFWGPX3xs15kd/qg==", "5b9f1aae-361d-482a-a9c6-ca5e09160c76" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81f3afcf-4890-4d51-af1d-7e84a7829496", "AQAAAAEAACcQAAAAEIUtIlvJnLhDcBVmxxCYxZYyqwCzfxQvrt0jUFfWV80N8RUJs8Fc497cNMM4viaacw==", "55986278-9186-45d7-ab11-e0792e736ad3" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 2, 13, 6, 40, 94, DateTimeKind.Local).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 2, 13, 6, 40, 94, DateTimeKind.Local).AddTicks(6695));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5809a232-32e0-40dc-b700-7959625059af", "AQAAAAEAACcQAAAAEI5IKu3G1TsZ3TFMvHLTYClogv0uDijvhot2eydoLdi3M6AzHHdOA5dBRbZLWhr0XA==", "b8c3af20-f0e0-4c04-93aa-2fa518fa6fed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe85c753-df72-4b90-ad05-0abfa5214362", "AQAAAAEAACcQAAAAECEGe747yQvXcHmV9oXQ9DXTIkBMMiy/IjYXb1x0CJizASF9XiiWlDw7aMU3cVJhAA==", "a512b7b9-b3ad-478b-b7a4-1861cf6bf672" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 2, 13, 3, 22, 970, DateTimeKind.Local).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 2, 13, 3, 22, 970, DateTimeKind.Local).AddTicks(8342));
        }
    }
}
