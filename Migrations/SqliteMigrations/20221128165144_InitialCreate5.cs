using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sistema.Migrations.SqliteMigrations
{
    /// <inheritdoc />
    public partial class InitialCreate5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "REPORTES",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    pagos = table.Column<double>(type: "REAL", nullable: false),
                    deducciones = table.Column<string>(type: "TEXT", nullable: false),
                    retenciones = table.Column<string>(type: "TEXT", nullable: false),
                    horastrabajadas = table.Column<int>(name: "horas_trabajadas", type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_REPORTES", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "REPORTES");
        }
    }
}
