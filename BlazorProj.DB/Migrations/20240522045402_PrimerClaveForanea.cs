using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorProj.DB.Migrations
{
    /// <inheritdoc />
    public partial class PrimerClaveForanea : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoDocumentoId",
                table: "Alumnos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Alumnos_TipoDocumentoId",
                table: "Alumnos",
                column: "TipoDocumentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alumnos_TipoDocumentos_TipoDocumentoId",
                table: "Alumnos",
                column: "TipoDocumentoId",
                principalTable: "TipoDocumentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alumnos_TipoDocumentos_TipoDocumentoId",
                table: "Alumnos");

            migrationBuilder.DropIndex(
                name: "IX_Alumnos_TipoDocumentoId",
                table: "Alumnos");

            migrationBuilder.DropColumn(
                name: "TipoDocumentoId",
                table: "Alumnos");
        }
    }
}
