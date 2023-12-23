using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FormUp.Api.Migrations
{
    /// <inheritdoc />
    public partial class DefineRelationshipBetweenActivityAndWorkout : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("459c307a-98dc-4591-b55e-de3e359a5269"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5e4ae2f1-afa5-48a0-a5e3-c072790afa99"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9341a66e-dda8-4f26-a02e-01b2565bdb16"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e274ef28-8a34-4321-8cc6-ee89e384713f"));

            migrationBuilder.AddColumn<Guid>(
                name: "WorkoutId",
                table: "Activities",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("045adcda-457e-484b-9bd8-330cd3cefa2f"), new DateTime(2023, 12, 21, 16, 53, 48, 755, DateTimeKind.Local).AddTicks(1740), new DateTime(2023, 12, 21, 16, 53, 48, 755, DateTimeKind.Local).AddTicks(1740), "Dips" },
                    { new Guid("b9d61a45-a182-4644-9362-b197cc9b757d"), new DateTime(2023, 12, 21, 16, 53, 48, 755, DateTimeKind.Local).AddTicks(1660), new DateTime(2023, 12, 21, 16, 53, 48, 755, DateTimeKind.Local).AddTicks(1720), "Pull ups" },
                    { new Guid("da235ed0-2e56-4de8-8ad9-21f9f6be794a"), new DateTime(2023, 12, 21, 16, 53, 48, 755, DateTimeKind.Local).AddTicks(1730), new DateTime(2023, 12, 21, 16, 53, 48, 755, DateTimeKind.Local).AddTicks(1730), "Push ups" },
                    { new Guid("fe1f1617-50d3-4aca-a01a-374ae3847bb2"), new DateTime(2023, 12, 21, 16, 53, 48, 755, DateTimeKind.Local).AddTicks(1740), new DateTime(2023, 12, 21, 16, 53, 48, 755, DateTimeKind.Local).AddTicks(1740), "Body-weight squats" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("045adcda-457e-484b-9bd8-330cd3cefa2f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b9d61a45-a182-4644-9362-b197cc9b757d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("da235ed0-2e56-4de8-8ad9-21f9f6be794a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fe1f1617-50d3-4aca-a01a-374ae3847bb2"));

            migrationBuilder.DropColumn(
                name: "WorkoutId",
                table: "Activities");

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("459c307a-98dc-4591-b55e-de3e359a5269"), new DateTime(2023, 12, 21, 16, 49, 2, 565, DateTimeKind.Local).AddTicks(3990), new DateTime(2023, 12, 21, 16, 49, 2, 565, DateTimeKind.Local).AddTicks(3990), "Dips" },
                    { new Guid("5e4ae2f1-afa5-48a0-a5e3-c072790afa99"), new DateTime(2023, 12, 21, 16, 49, 2, 565, DateTimeKind.Local).AddTicks(3980), new DateTime(2023, 12, 21, 16, 49, 2, 565, DateTimeKind.Local).AddTicks(3980), "Body-weight squats" },
                    { new Guid("9341a66e-dda8-4f26-a02e-01b2565bdb16"), new DateTime(2023, 12, 21, 16, 49, 2, 565, DateTimeKind.Local).AddTicks(3900), new DateTime(2023, 12, 21, 16, 49, 2, 565, DateTimeKind.Local).AddTicks(3970), "Pull ups" },
                    { new Guid("e274ef28-8a34-4321-8cc6-ee89e384713f"), new DateTime(2023, 12, 21, 16, 49, 2, 565, DateTimeKind.Local).AddTicks(3980), new DateTime(2023, 12, 21, 16, 49, 2, 565, DateTimeKind.Local).AddTicks(3980), "Push ups" }
                });
        }
    }
}
