using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPageMahasiswa.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NPM = table.Column<string>(nullable: true),
                    NamaMahasiswa = table.Column<string>(nullable: true),
                    TempatLahir = table.Column<string>(nullable: true),
                    ProgramStudy = table.Column<string>(nullable: true),
                    TanggalLahir = table.Column<DateTime>(nullable: false),
                    JenisKelamin = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Jurusan = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}
