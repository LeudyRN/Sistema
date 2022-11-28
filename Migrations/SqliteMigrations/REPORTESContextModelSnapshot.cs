﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Sistema.Migrations.SqliteMigrations
{
    [DbContext(typeof(REPORTESContext))]
    partial class REPORTESContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("total")
                        .HasColumnType("INTEGER");

                    b.Property<int>("valor")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("REPORTES");
                });
#pragma warning restore 612, 618
        }
    }
}