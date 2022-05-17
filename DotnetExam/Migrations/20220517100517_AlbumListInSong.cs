using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotnetExam.Migrations
{
    public partial class AlbumListInSong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Song_Album_albumId",
                table: "Song");

            migrationBuilder.DropIndex(
                name: "IX_Song_albumId",
                table: "Song");

            migrationBuilder.DropColumn(
                name: "albumId",
                table: "Song");

            migrationBuilder.AddColumn<int>(
                name: "AlbumId",
                table: "Album",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AlbumSong",
                columns: table => new
                {
                    SongsId = table.Column<int>(type: "int", nullable: false),
                    albumsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlbumSong", x => new { x.SongsId, x.albumsId });
                    table.ForeignKey(
                        name: "FK_AlbumSong_Album_albumsId",
                        column: x => x.albumsId,
                        principalTable: "Album",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlbumSong_Song_SongsId",
                        column: x => x.SongsId,
                        principalTable: "Song",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Album_AlbumId",
                table: "Album",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_AlbumSong_albumsId",
                table: "AlbumSong",
                column: "albumsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Album_Album_AlbumId",
                table: "Album",
                column: "AlbumId",
                principalTable: "Album",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Album_Album_AlbumId",
                table: "Album");

            migrationBuilder.DropTable(
                name: "AlbumSong");

            migrationBuilder.DropIndex(
                name: "IX_Album_AlbumId",
                table: "Album");

            migrationBuilder.DropColumn(
                name: "AlbumId",
                table: "Album");

            migrationBuilder.AddColumn<int>(
                name: "albumId",
                table: "Song",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Song_albumId",
                table: "Song",
                column: "albumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Song_Album_albumId",
                table: "Song",
                column: "albumId",
                principalTable: "Album",
                principalColumn: "Id");
        }
    }
}
