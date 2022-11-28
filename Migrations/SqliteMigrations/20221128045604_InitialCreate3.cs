using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sistema.Migrations.SqliteMigrations
{
    /// <inheritdoc />
    public partial class InitialCreate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NOMINA",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    sueldo = table.Column<double>(type: "REAL", nullable: false),
                    beneficio = table.Column<double>(type: "REAL", nullable: false),
                    bonos = table.Column<double>(type: "REAL", nullable: false),
                    impuestos = table.Column<double>(type: "REAL", nullable: false),
                    salarioFinal = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NOMINA", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NOMINA");
        }
    }
}
