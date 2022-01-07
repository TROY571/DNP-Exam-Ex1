using Microsoft.EntityFrameworkCore.Migrations;

namespace VolumeWebService.Migrations
{
    public partial class vol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VolumeResults",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    type = table.Column<string>(type: "TEXT", nullable: true),
                    height = table.Column<double>(type: "REAL", nullable: false),
                    radius = table.Column<double>(type: "REAL", nullable: false),
                    volume = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VolumeResults", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VolumeResults");
        }
    }
}
