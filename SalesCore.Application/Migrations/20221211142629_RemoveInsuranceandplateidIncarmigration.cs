using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesCore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemoveInsuranceandplateidIncarmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_plates_Cars_CarId",
                table: "plates");

            migrationBuilder.DropIndex(
                name: "IX_plates_CarId",
                table: "plates");

            migrationBuilder.DropColumn(
                name: "InsuranceNumber",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "PlateId",
                table: "Cars");

            migrationBuilder.AlterColumn<int>(
                name: "CarId",
                table: "plates",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_plates_CarId",
                table: "plates",
                column: "CarId",
                unique: true);

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

            migrationBuilder.DropIndex(
                name: "IX_plates_CarId",
                table: "plates");

            migrationBuilder.AlterColumn<int>(
                name: "CarId",
                table: "plates",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<Guid>(
                name: "InsuranceNumber",
                table: "Cars",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlateId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_plates_CarId",
                table: "plates",
                column: "CarId",
                unique: true,
                filter: "[CarId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_plates_Cars_CarId",
                table: "plates",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id");
        }
    }
}
