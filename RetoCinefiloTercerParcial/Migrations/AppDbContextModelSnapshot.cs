// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RetoCinefiloTercerParcial.Data;

namespace RetoCinefiloTercerParcial.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RetoCinefiloTercerParcial.Models.Cinefilo", b =>
                {
                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CalificacionIMDb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CalificacionRottenTomatoes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Curiosidades")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Director")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GalardonesOscars")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NominacionesOscars")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Portada")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Precuelas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Secuelas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sinopsis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tiempo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trailer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Genero");

                    b.ToTable("Cinefilo");
                });
#pragma warning restore 612, 618
        }
    }
}
