using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aspnet_core_mvc_scaffold.Migrations
{
    /// <inheritdoc />
    public partial class BancoInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoriasTB",
                columns: table => new
                {
                    CategoriaID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriasTB", x => x.CategoriaID);
                });

            migrationBuilder.CreateTable(
                name: "ClientesTB",
                columns: table => new
                {
                    ClienteID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientesTB", x => x.ClienteID);
                });

            migrationBuilder.CreateTable(
                name: "ProdutosTB",
                columns: table => new
                {
                    ProdutoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estoque = table.Column<int>(type: "int", nullable: false),
                    CategoriaID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutosTB", x => x.ProdutoID);
                    table.ForeignKey(
                        name: "FK_ProdutosTB_CategoriasTB_CategoriaID",
                        column: x => x.CategoriaID,
                        principalTable: "CategoriasTB",
                        principalColumn: "CategoriaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProdutosTB_CategoriaID",
                table: "ProdutosTB",
                column: "CategoriaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientesTB");

            migrationBuilder.DropTable(
                name: "ProdutosTB");

            migrationBuilder.DropTable(
                name: "CategoriasTB");
        }
    }
}
