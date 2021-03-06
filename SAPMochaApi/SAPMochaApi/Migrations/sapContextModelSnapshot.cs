// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SAPMochaApi.Models;

namespace SapMochaApi.Migrations
{
    [DbContext(typeof(sapContext))]
    partial class sapContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SapMochaApi.Models.Categorias", b =>
                {
                    b.Property<int>("IdCategorias")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion");

                    b.Property<int>("IdTipoProductores");

                    b.Property<string>("Nombre");

                    b.HasKey("IdCategorias");

                    b.HasIndex("IdTipoProductores");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("SapMochaApi.Models.DetalleCategorias", b =>
                {
                    b.Property<int>("IdDetalleCategorias")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdProductores");

                    b.Property<int>("IdProductos");

                    b.Property<decimal>("PrecioDocena")
                        .HasColumnType("decimal(8,2)");

                    b.Property<decimal>("PrecioUnidad")
                        .HasColumnType("decimal(8,2)");

                    b.Property<int>("Stock");

                    b.HasKey("IdDetalleCategorias");

                    b.HasIndex("IdProductores");

                    b.HasIndex("IdProductos");

                    b.ToTable("DetalleCategorias");
                });

            modelBuilder.Entity("SapMochaApi.Models.Productores", b =>
                {
                    b.Property<int>("IdProductores")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellidos");

                    b.Property<string>("Cargo");

                    b.Property<string>("Cedula");

                    b.Property<string>("Correo");

                    b.Property<string>("DetalleDiscapacidad");

                    b.Property<string>("DetalleOrganizacion");

                    b.Property<string>("Direccion");

                    b.Property<bool>("Discapacidad");

                    b.Property<int>("Edad");

                    b.Property<int>("IdTipoProductores");

                    b.Property<string>("Latitud");

                    b.Property<string>("Longitud");

                    b.Property<string>("Nombres");

                    b.Property<bool>("Organizacion");

                    b.Property<string>("PaginaWeb");

                    b.Property<int>("PorcentajeDiscapacidad");

                    b.Property<string>("Sexo");

                    b.Property<string>("Telefono");

                    b.HasKey("IdProductores");

                    b.HasIndex("IdTipoProductores");

                    b.ToTable("Productores");
                });

            modelBuilder.Entity("SapMochaApi.Models.Productos", b =>
                {
                    b.Property<int>("IdProductos")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion");

                    b.Property<int>("IdCategorias");

                    b.Property<string>("NombreProducto");

                    b.Property<string>("Talla");

                    b.Property<string>("Unidad");

                    b.HasKey("IdProductos");

                    b.HasIndex("IdCategorias");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("SapMochaApi.Models.TipoProductores", b =>
                {
                    b.Property<int>("IdTipoProductores")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.HasKey("IdTipoProductores");

                    b.ToTable("TipoProductores");
                });

            modelBuilder.Entity("SAPMochaApi.Models.Usuarios", b =>
                {
                    b.Property<int>("IdUsuarios")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellidos");

                    b.Property<string>("Cedula");

                    b.Property<string>("Clave");

                    b.Property<string>("Correo");

                    b.Property<string>("Direccion");

                    b.Property<string>("Nombres");

                    b.Property<string>("Telefono");

                    b.Property<string>("Usuario");

                    b.HasKey("IdUsuarios");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("SapMochaApi.Models.Categorias", b =>
                {
                    b.HasOne("SapMochaApi.Models.TipoProductores", "tipoproductores")
                        .WithMany()
                        .HasForeignKey("IdTipoProductores")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SapMochaApi.Models.DetalleCategorias", b =>
                {
                    b.HasOne("SapMochaApi.Models.Productores", "Productores")
                        .WithMany()
                        .HasForeignKey("IdProductores")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SapMochaApi.Models.Productos", "Productos")
                        .WithMany()
                        .HasForeignKey("IdProductos")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SapMochaApi.Models.Productores", b =>
                {
                    b.HasOne("SapMochaApi.Models.TipoProductores", "tipoproductores")
                        .WithMany()
                        .HasForeignKey("IdTipoProductores")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SapMochaApi.Models.Productos", b =>
                {
                    b.HasOne("SapMochaApi.Models.Categorias", "categorias")
                        .WithMany()
                        .HasForeignKey("IdCategorias")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
