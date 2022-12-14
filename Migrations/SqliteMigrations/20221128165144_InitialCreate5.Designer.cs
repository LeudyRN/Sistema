// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Sistema.Migrations.SqliteMigrations
{
    [DbContext(typeof(REPORTESContext))]
    [Migration("20221128165144_InitialCreate5")]
    partial class InitialCreate5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("REPORTES", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("deducciones")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("horas_trabajadas")
                        .HasColumnType("INTEGER");

                    b.Property<double>("pagos")
                        .HasColumnType("REAL");

                    b.Property<string>("retenciones")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("REPORTES");
                });
#pragma warning restore 612, 618
        }
    }
}
