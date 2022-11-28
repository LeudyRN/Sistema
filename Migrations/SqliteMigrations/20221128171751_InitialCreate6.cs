using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sistema.Migrations.SqliteMigrations
{
    /// <inheritdoc />
    public partial class InitialCreate6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "total",
                table: "REPORTES",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "valor",
                table: "REPORTES",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "total",
                table: "REPORTES");

            migrationBuilder.DropColumn(
                name: "valor",
                table: "REPORTES");
        }
    }
}
