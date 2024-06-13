using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorProj.DB.Migrations
{
    /// <inheritdoc />
    public partial class DeleteBehavior_Changed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alumnos_TipoDocumentos_TipoDocumentoId",
                table: "Alumnos");

            migrationBuilder.DropForeignKey(
                name: "FK_Cooperadoras_Alumnos_AlumnoId",
                table: "Cooperadoras");

            migrationBuilder.DropForeignKey(
                name: "FK_Departamentos_Provincias_ProvinciaId",
                table: "Departamentos");

            migrationBuilder.AddForeignKey(
                name: "FK_Alumnos_TipoDocumentos_TipoDocumentoId",
                table: "Alumnos",
                column: "TipoDocumentoId",
                principalTable: "TipoDocumentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cooperadoras_Alumnos_AlumnoId",
                table: "Cooperadoras",
                column: "AlumnoId",
                principalTable: "Alumnos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Departamentos_Provincias_ProvinciaId",
                table: "Departamentos",
                column: "ProvinciaId",
                principalTable: "Provincias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alumnos_TipoDocumentos_TipoDocumentoId",
                table: "Alumnos");

            migrationBuilder.DropForeignKey(
                name: "FK_Cooperadoras_Alumnos_AlumnoId",
                table: "Cooperadoras");

            migrationBuilder.DropForeignKey(
                name: "FK_Departamentos_Provincias_ProvinciaId",
                table: "Departamentos");

            migrationBuilder.AddForeignKey(
                name: "FK_Alumnos_TipoDocumentos_TipoDocumentoId",
                table: "Alumnos",
                column: "TipoDocumentoId",
                principalTable: "TipoDocumentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cooperadoras_Alumnos_AlumnoId",
                table: "Cooperadoras",
                column: "AlumnoId",
                principalTable: "Alumnos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departamentos_Provincias_ProvinciaId",
                table: "Departamentos",
                column: "ProvinciaId",
                principalTable: "Provincias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
