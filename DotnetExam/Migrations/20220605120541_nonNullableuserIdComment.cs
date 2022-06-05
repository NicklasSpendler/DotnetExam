using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotnetExam.Migrations
{
    public partial class nonNullableuserIdComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_AspNetUsers_UserId",
                table: "Comment");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Comment",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d497ac46-b919-43f8-94f4-1e7150d84936", "AQAAAAEAACcQAAAAEO8rKCoBq3Gz9rchLEgUEXQXoVu/VDrtPkLHXjAkdT0femByH/N/bvjgz5bBSO6IJg==", "0693721b-9fd8-4e77-8233-a218985a6bf4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3161ba9-8568-4d17-9978-e6fda7cf8d5a", "AQAAAAEAACcQAAAAEAAv25oz2+cXcXd6V7JV4RKtWrDDbTbKXDConyCdMgBv129WOiOH1LdpuKUEDVTO4A==", "05151657-dae3-4d93-ab5d-42d565683f0b" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 5, 14, 5, 41, 699, DateTimeKind.Local).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 5, 14, 5, 41, 699, DateTimeKind.Local).AddTicks(759));

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_AspNetUsers_UserId",
                table: "Comment",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_AspNetUsers_UserId",
                table: "Comment");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Comment",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16960df1-89f0-4e3c-bb07-68458fe76966", "AQAAAAEAACcQAAAAEGmX6kVWTYcTQwKCXHCbcVWaRCQkI79NfHBt43KhyznNEFOSyhr41wI3ScCqdbf7Vg==", "3e276130-9d74-47ea-bf22-49b1eff5c9aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d571a07-70d4-4c61-8660-bfaed84d63db", "AQAAAAEAACcQAAAAEN8hhK/eiWfUqUk1pWrb81Cwcxnh7GptwGfKLsW/gnu/P6oweq2ZOLnHtZsjGpU6OA==", "da8486d0-eed8-4e86-936e-bc29f158fd57" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 5, 14, 3, 27, 560, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 5, 14, 3, 27, 560, DateTimeKind.Local).AddTicks(1415));

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_AspNetUsers_UserId",
                table: "Comment",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
