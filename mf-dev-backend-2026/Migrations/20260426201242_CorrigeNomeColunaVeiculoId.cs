using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mf_dev_backend_2026.Migrations
{
    /// <inheritdoc />
    public partial class CorrigeNomeColunaVeiculoId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consumos_Veiculos_VeiculoId",
                table: "Consumos");

            migrationBuilder.RenameColumn(
                name: "VeiculoId",
                table: "Consumos",
                newName: "VeiculoId");

            migrationBuilder.RenameIndex(
                name: "IX_Consumos_VeiculoId",
                table: "Consumos",
                newName: "IX_Consumos_VeiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consumos_Veiculos_VeiculoId",
                table: "Consumos",
                column: "VeiculoId",
                principalTable: "Veiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consumos_Veiculos_VeiculoId",
                table: "Consumos");

            migrationBuilder.RenameColumn(
                name: "VeiculoId",
                table: "Consumos",
                newName: "VeiculoId");

            migrationBuilder.RenameIndex(
                name: "IX_Consumos_VeiculoId",
                table: "Consumos",
                newName: "IX_Consumos_VeiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consumos_Veiculos_VeiculoId",
                table: "Consumos",
                column: "VeiculoId",
                principalTable: "Veiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
