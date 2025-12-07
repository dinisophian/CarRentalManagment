using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagment.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Naem",
                table: "Make",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "VevicleId",
                table: "Booking",
                newName: "VehicleId");

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DrivingLicense = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 5, 2, 25, 42, 605, DateTimeKind.Local).AddTicks(2517), new DateTime(2025, 12, 5, 2, 25, 42, 605, DateTimeKind.Local).AddTicks(2528), "Black", "System" },
                    { 2, "System", new DateTime(2025, 12, 5, 2, 25, 42, 605, DateTimeKind.Local).AddTicks(2530), new DateTime(2025, 12, 5, 2, 25, 42, 605, DateTimeKind.Local).AddTicks(2531), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 5, 2, 25, 42, 605, DateTimeKind.Local).AddTicks(2680), new DateTime(2025, 12, 5, 2, 25, 42, 605, DateTimeKind.Local).AddTicks(2681), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 12, 5, 2, 25, 42, 605, DateTimeKind.Local).AddTicks(2682), new DateTime(2025, 12, 5, 2, 25, 42, 605, DateTimeKind.Local).AddTicks(2683), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 5, 2, 25, 42, 605, DateTimeKind.Local).AddTicks(2742), new DateTime(2025, 12, 5, 2, 25, 42, 605, DateTimeKind.Local).AddTicks(2742), "i4", "System" },
                    { 2, "System", new DateTime(2025, 12, 5, 2, 25, 42, 605, DateTimeKind.Local).AddTicks(2744), new DateTime(2025, 12, 5, 2, 25, 42, 605, DateTimeKind.Local).AddTicks(2744), "X5", "System" },
                    { 3, "System", new DateTime(2025, 12, 5, 2, 25, 42, 605, DateTimeKind.Local).AddTicks(2746), new DateTime(2025, 12, 5, 2, 25, 42, 605, DateTimeKind.Local).AddTicks(2746), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 12, 5, 2, 25, 42, 605, DateTimeKind.Local).AddTicks(2747), new DateTime(2025, 12, 5, 2, 25, 42, 605, DateTimeKind.Local).AddTicks(2749), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Make",
                newName: "Naem");

            migrationBuilder.RenameColumn(
                name: "VehicleId",
                table: "Booking",
                newName: "VevicleId");
        }
    }
}
