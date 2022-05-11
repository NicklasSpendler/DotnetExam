using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotnetExam.Migrations
{
    public partial class removedRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Song_Album_albumId",
                table: "Song");

            migrationBuilder.DropForeignKey(
                name: "FK_Song_Artist_artistId",
                table: "Song");

            migrationBuilder.DropIndex(
                name: "IX_Song_albumId",
                table: "Song");

            migrationBuilder.DropIndex(
                name: "IX_Song_artistId",
                table: "Song");

            migrationBuilder.DropColumn(
                name: "albumId",
                table: "Song");

            migrationBuilder.DropColumn(
                name: "artistId",
                table: "Song");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "albumId",
                table: "Song",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "artistId",
                table: "Song",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Song_albumId",
                table: "Song",
                column: "albumId");

            migrationBuilder.CreateIndex(
                name: "IX_Song_artistId",
                table: "Song",
                column: "artistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Song_Album_albumId",
                table: "Song",
                column: "albumId",
                principalTable: "Album",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Song_Artist_artistId",
                table: "Song",
                column: "artistId",
                principalTable: "Artist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
