using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotnetExam.Migrations
{
    public partial class addedAblumsIdInSong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Album_Album_AlbumId",
                table: "Album");

            migrationBuilder.DropIndex(
                name: "IX_Album_AlbumId",
                table: "Album");

            migrationBuilder.DropColumn(
                name: "AlbumId",
                table: "Album");

            migrationBuilder.AddColumn<int>(
                name: "albumsId",
                table: "Song",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "albumsId",
                table: "Song");

            migrationBuilder.AddColumn<int>(
                name: "AlbumId",
                table: "Album",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Album_AlbumId",
                table: "Album",
                column: "AlbumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Album_Album_AlbumId",
                table: "Album",
                column: "AlbumId",
                principalTable: "Album",
                principalColumn: "Id");
        }
    }
}
