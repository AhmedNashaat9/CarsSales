using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesCore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class editplateclassmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plate_Cars_CarId",
                table: "Plate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Plate",
                table: "Plate");

            migrationBuilder.RenameTable(
                name: "Plate",
                newName: "plates");

            migrationBuilder.RenameIndex(
                name: "IX_Plate_CarId",
                table: "plates",
                newName: "IX_plates_CarId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_plates",
                table: "plates",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_plates_Cars_CarId",
                table: "plates",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_plates_Cars_CarId",
                table: "plates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_plates",
                table: "plates");

            migrationBuilder.RenameTable(
                name: "plates",
                newName: "Plate");

            migrationBuilder.RenameIndex(
                name: "IX_plates_CarId",
                table: "Plate",
                newName: "IX_Plate_CarId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Plate",
                table: "Plate",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Plate_Cars_CarId",
                table: "Plate",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
