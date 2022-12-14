using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesCore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addguidvalueincontracttable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsuranceDate",
                table: "insuranceContracts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 6, 13, 48, 31, 140, DateTimeKind.Local).AddTicks(4611),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 6, 13, 41, 48, 565, DateTimeKind.Local).AddTicks(4431));

            migrationBuilder.AlterColumn<Guid>(
                name: "InsuranceNumber",
                table: "insuranceContracts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("dc22a97d-75c9-4417-ab34-3d225330cd10"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsuranceDate",
                table: "insuranceContracts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 6, 13, 41, 48, 565, DateTimeKind.Local).AddTicks(4431),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 6, 13, 48, 31, 140, DateTimeKind.Local).AddTicks(4611));

            migrationBuilder.AlterColumn<Guid>(
                name: "InsuranceNumber",
                table: "insuranceContracts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("dc22a97d-75c9-4417-ab34-3d225330cd10"));
        }
    }
}
