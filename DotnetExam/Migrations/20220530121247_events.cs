using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotnetExam.Migrations
{
    public partial class events : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Comment",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Enddate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Endtime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    artistId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Event_Artist_artistId",
                        column: x => x.artistId,
                        principalTable: "Artist",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Event_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Comment_EventId",
                table: "Comment",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_artistId",
                table: "Event",
                column: "artistId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_UserId",
                table: "Event",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Event_EventId",
                table: "Comment",
                column: "EventId",
                principalTable: "Event",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Event_EventId",
                table: "Comment");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropIndex(
                name: "IX_Comment_EventId",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Comment");

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
