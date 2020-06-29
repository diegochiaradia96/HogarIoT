using Microsoft.EntityFrameworkCore.Migrations;

namespace HogarIoT.Migrations
{
    public partial class HogarIoTContextHogarDataBaseContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dispositivos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 20, nullable: false),
                    Estado = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    Temperatura = table.Column<int>(nullable: true),
                    Modo = table.Column<int>(nullable: true),
                    Grabar = table.Column<bool>(nullable: true),
                    TempHeladera = table.Column<int>(nullable: true),
                    TempFreezer = table.Column<int>(nullable: true),
                    Intensidad = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dispositivos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dispositivos");
        }
    }
}
