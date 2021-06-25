using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapMochaApi.Migrations
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoProductores",
                columns: table => new
                {
                    IdTipoProductores = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoProductores", x => x.IdTipoProductores);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUsuarios = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cedula = table.Column<string>(nullable: true),
                    Nombres = table.Column<string>(nullable: true),
                    Apellidos = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    Correo = table.Column<string>(nullable: true),
                    Usuario = table.Column<string>(nullable: true),
                    Clave = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUsuarios);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    IdCategorias = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    IdTipoProductores = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.IdCategorias);
                    table.ForeignKey(
                        name: "FK_Categorias_TipoProductores_IdTipoProductores",
                        column: x => x.IdTipoProductores,
                        principalTable: "TipoProductores",
                        principalColumn: "IdTipoProductores",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Productores",
                columns: table => new
                {
                    IdProveedores = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cedula = table.Column<string>(nullable: true),
                    Nombres = table.Column<string>(nullable: true),
                    Apellidos = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    Longitud = table.Column<string>(nullable: true),
                    Latitud = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    Correo = table.Column<string>(nullable: true),
                    Edad = table.Column<int>(nullable: false),
                    Sexo = table.Column<string>(nullable: true),
                    PaginaWeb = table.Column<string>(nullable: true),
                    Cargo = table.Column<string>(nullable: true),
                    Organizacion = table.Column<bool>(nullable: false),
                    DetalleOrganizacion = table.Column<string>(nullable: true),
                    Discapacidad = table.Column<bool>(nullable: false),
                    DetalleDiscapacidad = table.Column<string>(nullable: true),
                    PorcentajeDiscapacidad = table.Column<int>(nullable: false),
                    IdTipoProductores = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productores", x => x.IdProveedores);
                    table.ForeignKey(
                        name: "FK_Productores_TipoProductores_IdTipoProductores",
                        column: x => x.IdTipoProductores,
                        principalTable: "TipoProductores",
                        principalColumn: "IdTipoProductores",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    IdProductos = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreProducto = table.Column<string>(nullable: true),
                    Unidad = table.Column<string>(nullable: true),
                    Stock = table.Column<int>(nullable: false),
                    PrecioUnidad = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    PrecioDocena = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    Talla = table.Column<string>(nullable: true),
                    IdCategorias = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.IdProductos);
                    table.ForeignKey(
                        name: "FK_Productos_Categorias_IdCategorias",
                        column: x => x.IdCategorias,
                        principalTable: "Categorias",
                        principalColumn: "IdCategorias",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categorias_IdTipoProductores",
                table: "Categorias",
                column: "IdTipoProductores");

            migrationBuilder.CreateIndex(
                name: "IX_Productores_IdTipoProductores",
                table: "Productores",
                column: "IdTipoProductores");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_IdCategorias",
                table: "Productos",
                column: "IdCategorias");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productores");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "TipoProductores");
        }
    }
}
