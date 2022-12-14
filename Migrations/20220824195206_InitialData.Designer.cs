// <auto-generated />
using System;
using EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityFramework.Migrations
{
    [DbContext(typeof(TareasContext))]
    [Migration("20220824195206_InitialData")]
    partial class InitialData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EntityFramework.Models.Categoria", b =>
                {
                    b.Property<Guid>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Peso")
                        .HasColumnType("int");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categoria", (string)null);

                    b.HasData(
                        new
                        {
                            CategoriaId = new Guid("89d9dacc-e2a6-4ac0-af03-7f3a542a0107"),
                            Nombre = "Actividades Pendientes",
                            Peso = 20
                        },
                        new
                        {
                            CategoriaId = new Guid("89d9dacc-e2a6-4ac0-af03-7f3a542a0102"),
                            Nombre = "Actividades Personales",
                            Peso = 50
                        });
                });

            modelBuilder.Entity("EntityFramework.Models.Tarea", b =>
                {
                    b.Property<Guid>("TareaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CateogoriaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("PrioridadTarea")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("TareaId");

                    b.HasIndex("CateogoriaId");

                    b.ToTable("Tarea", (string)null);

                    b.HasData(
                        new
                        {
                            TareaId = new Guid("89d9dacc-e2a6-4ac0-af03-7f3a542a0110"),
                            CateogoriaId = new Guid("89d9dacc-e2a6-4ac0-af03-7f3a542a0107"),
                            FechaCreacion = new DateTime(2022, 8, 24, 14, 52, 6, 438, DateTimeKind.Local).AddTicks(8253),
                            PrioridadTarea = 1,
                            Titulo = "Pagos de servicios publicos"
                        },
                        new
                        {
                            TareaId = new Guid("89d9dacc-e2a6-4ac0-af03-7f3a542a0111"),
                            CateogoriaId = new Guid("89d9dacc-e2a6-4ac0-af03-7f3a542a0102"),
                            FechaCreacion = new DateTime(2022, 8, 24, 14, 52, 6, 438, DateTimeKind.Local).AddTicks(8287),
                            PrioridadTarea = 0,
                            Titulo = "Terminar de ver pelicula en netflix"
                        });
                });

            modelBuilder.Entity("EntityFramework.Models.Tarea", b =>
                {
                    b.HasOne("EntityFramework.Models.Categoria", "Categoria")
                        .WithMany("Tareas")
                        .HasForeignKey("CateogoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("EntityFramework.Models.Categoria", b =>
                {
                    b.Navigation("Tareas");
                });
#pragma warning restore 612, 618
        }
    }
}
