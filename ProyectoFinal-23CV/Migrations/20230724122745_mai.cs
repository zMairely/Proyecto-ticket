using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace ProyectoFinal_23CV.Migrations
{
    public partial class mai : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    PkProducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NombreProducto = table.Column<string>(type: "text", nullable: false),
                    PrecioProducto = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.PkProducto);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    PkRol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.PkRol);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    PkUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    FkRol = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.PkUsuario);
                    table.ForeignKey(
                        name: "FK_Usuarios_Roles_FkRol",
                        column: x => x.FkRol,
                        principalTable: "Roles",
                        principalColumn: "PkRol",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    PkVenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Total = table.Column<double>(type: "double", nullable: false),
                    FechaVenta = table.Column<DateTime>(type: "datetime", nullable: false),
                    Subtotal = table.Column<double>(type: "double", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Iva = table.Column<double>(type: "double", nullable: false),
                    FkVendedor = table.Column<int>(type: "int", nullable: true),
                    FkProducto = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.PkVenta);
                    table.ForeignKey(
                        name: "FK_Ventas_Productos_FkProducto",
                        column: x => x.FkProducto,
                        principalTable: "Productos",
                        principalColumn: "PkProducto",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ventas_Usuarios_FkVendedor",
                        column: x => x.FkVendedor,
                        principalTable: "Usuarios",
                        principalColumn: "PkUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetallesVenta",
                columns: table => new
                {
                    PkDetalleVenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    FkVenta = table.Column<int>(type: "int", nullable: false),
                    VentaPkVenta = table.Column<int>(type: "int", nullable: false),
                    FkProducto = table.Column<int>(type: "int", nullable: false),
                    ProductoPkProducto = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesVenta", x => x.PkDetalleVenta);
                    table.ForeignKey(
                        name: "FK_DetallesVenta_Productos_ProductoPkProducto",
                        column: x => x.ProductoPkProducto,
                        principalTable: "Productos",
                        principalColumn: "PkProducto",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetallesVenta_Ventas_VentaPkVenta",
                        column: x => x.VentaPkVenta,
                        principalTable: "Ventas",
                        principalColumn: "PkVenta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetallesVenta_ProductoPkProducto",
                table: "DetallesVenta",
                column: "ProductoPkProducto");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesVenta_VentaPkVenta",
                table: "DetallesVenta",
                column: "VentaPkVenta");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_FkRol",
                table: "Usuarios",
                column: "FkRol");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_FkProducto",
                table: "Ventas",
                column: "FkProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_FkVendedor",
                table: "Ventas",
                column: "FkVendedor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetallesVenta");

            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
