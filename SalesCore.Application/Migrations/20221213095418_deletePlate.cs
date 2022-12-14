using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesCore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class deletePlate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_plates_CarId",
                table: "plates");

            migrationBuilder.DropIndex(
                name: "IX_insuranceContracts_CarId",
                table: "insuranceContracts");

            migrationBuilder.CreateIndex(
                name: "IX_plates_CarId",
                table: "plates",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_insuranceContracts_CarId",
                table: "insuranceContracts",
                column: "CarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_plates_CarId",
                table: "plates");

            migrationBuilder.DropIndex(
                name: "IX_insuranceContracts_CarId",
                table: "insuranceContracts");

            migrationBuilder.CreateIndex(
                name: "IX_plates_CarId",
                table: "plates",
                column: "CarId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_insuranceContracts_CarId",
                table: "insuranceContracts",
                column: "CarId",
                unique: true);
        }
    }
}
