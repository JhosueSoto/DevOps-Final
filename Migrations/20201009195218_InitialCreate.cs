using Microsoft.EntityFrameworkCore.Migrations;

namespace Parcial.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "vehiculos",
                columns: table => new
                {
                    vehiculoid = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    placa = table.Column<string>(nullable: true),
                    modelo = table.Column<string>(nullable: true),
                    marca = table.Column<string>(nullable: true),
                    color = table.Column<string>(nullable: true),
                    descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehiculos", x => x.vehiculoid);
                });

            migrationBuilder.CreateTable(
                name: "personas",
                columns: table => new
                {
                    personaid = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nombre = table.Column<string>(nullable: true),
                    apellido = table.Column<string>(nullable: true),
                    lugar = table.Column<string>(nullable: true),
                    vehiculoid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personas", x => x.personaid);
                    table.ForeignKey(
                        name: "FK_personas_vehiculos_vehiculoid",
                        column: x => x.vehiculoid,
                        principalTable: "vehiculos",
                        principalColumn: "vehiculoid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_personas_vehiculoid",
                table: "personas",
                column: "vehiculoid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "personas");

            migrationBuilder.DropTable(
                name: "vehiculos");
        }
    }
}
