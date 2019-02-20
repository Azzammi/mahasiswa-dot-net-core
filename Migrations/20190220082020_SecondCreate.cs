using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPageMahasiswa.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Movie",
                table: "Movie");

            migrationBuilder.RenameTable(
                name: "Movie",
                newName: "Mahasiswa");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mahasiswa",
                table: "Mahasiswa",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Mahasiswa",
                table: "Mahasiswa");

            migrationBuilder.RenameTable(
                name: "Mahasiswa",
                newName: "Movie");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movie",
                table: "Movie",
                column: "ID");
        }
    }
}
