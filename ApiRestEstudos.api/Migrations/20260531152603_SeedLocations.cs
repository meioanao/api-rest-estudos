using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiRestEstudos.Api.Migrations
{
    /// <inheritdoc />
    public partial class SeedLocations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Categoria", "Latitude", "Longitude", "Nome" },
                values: new object[,]
                {
                    { 1, "Turismo", -22.951899999999998, -43.210500000000003, "Cristo Redentor" },
                    { 2, "Turismo", -22.948899999999998, -43.157600000000002, "Pao de Acucar" },
                    { 3, "Praia", -22.9711, -43.182299999999998, "Praia de Copacabana" },
                    { 4, "Praia", -22.986799999999999, -43.200600000000001, "Praia de Ipanema" },
                    { 5, "Estadio", -22.912199999999999, -43.230200000000004, "Maracana" },
                    { 6, "Parque", -22.966899999999999, -43.224299999999999, "Jardim Botanico" },
                    { 7, "Parque", -22.9602, -43.210900000000002, "Parque Lage" },
                    { 8, "Praia", -22.9894, -43.191699999999997, "Arpoador" },
                    { 9, "Trilha", -22.997399999999999, -43.2742, "Pedra da Gavea" },
                    { 10, "Parque", -22.9072, -43.223100000000002, "Quinta da Boa Vista" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
