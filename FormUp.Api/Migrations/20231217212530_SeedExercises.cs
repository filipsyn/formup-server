using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FormUp.Api.Migrations
{
    /// <inheritdoc />
    public partial class SeedExercises : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("7212ec52-61a5-4991-9136-4d29d05df68b"), new DateTime(2023, 12, 17, 22, 25, 30, 49, DateTimeKind.Local).AddTicks(9880), new DateTime(2023, 12, 17, 22, 25, 30, 49, DateTimeKind.Local).AddTicks(9880), "Dips" },
                    { new Guid("748b67de-d561-4bdd-8b20-b1a84bbc9907"), new DateTime(2023, 12, 17, 22, 25, 30, 49, DateTimeKind.Local).AddTicks(9830), new DateTime(2023, 12, 17, 22, 25, 30, 49, DateTimeKind.Local).AddTicks(9870), "Pull ups" },
                    { new Guid("750af971-a137-4b4a-833e-201e709309f7"), new DateTime(2023, 12, 17, 22, 25, 30, 49, DateTimeKind.Local).AddTicks(9870), new DateTime(2023, 12, 17, 22, 25, 30, 49, DateTimeKind.Local).AddTicks(9870), "Push ups" },
                    { new Guid("eba7fc5f-f872-40b4-8388-471f0ddd9124"), new DateTime(2023, 12, 17, 22, 25, 30, 49, DateTimeKind.Local).AddTicks(9880), new DateTime(2023, 12, 17, 22, 25, 30, 49, DateTimeKind.Local).AddTicks(9880), "Body-weight squats" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7212ec52-61a5-4991-9136-4d29d05df68b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("748b67de-d561-4bdd-8b20-b1a84bbc9907"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("750af971-a137-4b4a-833e-201e709309f7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("eba7fc5f-f872-40b4-8388-471f0ddd9124"));
        }
    }
}
