using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ModeloDB.Migrations
{
    public partial class InicioIESS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Solicitantes",
                columns: table => new
                {
                    SolicitanteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cedula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solicitantes", x => x.SolicitanteId);
                });

            migrationBuilder.CreateTable(
                name: "Aportaciones",
                columns: table => new
                {
                    AportacionesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Salario = table.Column<float>(type: "real", nullable: false),
                    NombreEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RucEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AporteEmpresa = table.Column<float>(type: "real", nullable: false),
                    AporteAfiliado = table.Column<float>(type: "real", nullable: false),
                    FechaAportacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstadoAportacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolicitanteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aportaciones", x => x.AportacionesId);
                    table.ForeignKey(
                        name: "FK_Aportaciones_Solicitantes_SolicitanteId",
                        column: x => x.SolicitanteId,
                        principalTable: "Solicitantes",
                        principalColumn: "SolicitanteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prestamos",
                columns: table => new
                {
                    PrestamoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CantidadAprobada = table.Column<float>(type: "real", nullable: false),
                    MesesPlazo = table.Column<int>(type: "int", nullable: false),
                    Interes = table.Column<float>(type: "real", nullable: false),
                    MontoTotalPagar = table.Column<float>(type: "real", nullable: false),
                    CuotaMensual = table.Column<float>(type: "real", nullable: false),
                    FechaPago = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SolicitanteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestamos", x => x.PrestamoId);
                    table.ForeignKey(
                        name: "FK_Prestamos_Solicitantes_SolicitanteId",
                        column: x => x.SolicitanteId,
                        principalTable: "Solicitantes",
                        principalColumn: "SolicitanteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FondosCesantias",
                columns: table => new
                {
                    FondosCesantiaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PorcentajeFC = table.Column<float>(type: "real", nullable: false),
                    AportacionFC = table.Column<float>(type: "real", nullable: false),
                    AportacionesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FondosCesantias", x => x.FondosCesantiaId);
                    table.ForeignKey(
                        name: "FK_FondosCesantias_Aportaciones_AportacionesId",
                        column: x => x.AportacionesId,
                        principalTable: "Aportaciones",
                        principalColumn: "AportacionesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FondosReservas",
                columns: table => new
                {
                    FondosReservaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PorcentajeFR = table.Column<float>(type: "real", nullable: false),
                    AportacionFR = table.Column<float>(type: "real", nullable: false),
                    AportacionesId = table.Column<int>(type: "int", nullable: true),
                    ApotacionesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FondosReservas", x => x.FondosReservaId);
                    table.ForeignKey(
                        name: "FK_FondosReservas_Aportaciones_AportacionesId",
                        column: x => x.AportacionesId,
                        principalTable: "Aportaciones",
                        principalColumn: "AportacionesId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Garantias",
                columns: table => new
                {
                    GarantiasId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CantidadAportaciones = table.Column<int>(type: "int", nullable: false),
                    TotalGarantias = table.Column<float>(type: "real", nullable: false),
                    AportacionesId = table.Column<int>(type: "int", nullable: true),
                    FondosReservaId = table.Column<int>(type: "int", nullable: true),
                    FondosCesantiaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Garantias", x => x.GarantiasId);
                    table.ForeignKey(
                        name: "FK_Garantias_Aportaciones_AportacionesId",
                        column: x => x.AportacionesId,
                        principalTable: "Aportaciones",
                        principalColumn: "AportacionesId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Garantias_FondosCesantias_FondosCesantiaId",
                        column: x => x.FondosCesantiaId,
                        principalTable: "FondosCesantias",
                        principalColumn: "FondosCesantiaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Garantias_FondosReservas_FondosReservaId",
                        column: x => x.FondosReservaId,
                        principalTable: "FondosReservas",
                        principalColumn: "FondosReservaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aportaciones_SolicitanteId",
                table: "Aportaciones",
                column: "SolicitanteId");

            migrationBuilder.CreateIndex(
                name: "IX_FondosCesantias_AportacionesId",
                table: "FondosCesantias",
                column: "AportacionesId");

            migrationBuilder.CreateIndex(
                name: "IX_FondosReservas_AportacionesId",
                table: "FondosReservas",
                column: "AportacionesId");

            migrationBuilder.CreateIndex(
                name: "IX_Garantias_AportacionesId",
                table: "Garantias",
                column: "AportacionesId");

            migrationBuilder.CreateIndex(
                name: "IX_Garantias_FondosCesantiaId",
                table: "Garantias",
                column: "FondosCesantiaId");

            migrationBuilder.CreateIndex(
                name: "IX_Garantias_FondosReservaId",
                table: "Garantias",
                column: "FondosReservaId");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_SolicitanteId",
                table: "Prestamos",
                column: "SolicitanteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Garantias");

            migrationBuilder.DropTable(
                name: "Prestamos");

            migrationBuilder.DropTable(
                name: "FondosCesantias");

            migrationBuilder.DropTable(
                name: "FondosReservas");

            migrationBuilder.DropTable(
                name: "Aportaciones");

            migrationBuilder.DropTable(
                name: "Solicitantes");
        }
    }
}
