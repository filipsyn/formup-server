using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FormUp.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddActivitiesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExerciseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SetsCount = table.Column<int>(type: "int", nullable: false),
                    RepetitionsCount = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Activities_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("1271ef8c-7c7b-4d2f-b1ba-63018fe2386a"), new DateTime(2023, 12, 19, 20, 40, 0, 953, DateTimeKind.Local).AddTicks(6380), new DateTime(2023, 12, 19, 20, 40, 0, 953, DateTimeKind.Local).AddTicks(6380), "Push ups" },
                    { new Guid("9e088791-ace2-4255-ab00-ffcc90757f6c"), new DateTime(2023, 12, 19, 20, 40, 0, 953, DateTimeKind.Local).AddTicks(6300), new DateTime(2023, 12, 19, 20, 40, 0, 953, DateTimeKind.Local).AddTicks(6380), "Pull ups" },
                    { new Guid("e9c25fa1-86a1-458c-86b1-2e98d50f9a01"), new DateTime(2023, 12, 19, 20, 40, 0, 953, DateTimeKind.Local).AddTicks(6390), new DateTime(2023, 12, 19, 20, 40, 0, 953, DateTimeKind.Local).AddTicks(6390), "Dips" },
                    { new Guid("efb4bac0-fe28-4d64-8d84-fa67a6f63661"), new DateTime(2023, 12, 19, 20, 40, 0, 953, DateTimeKind.Local).AddTicks(6390), new DateTime(2023, 12, 19, 20, 40, 0, 953, DateTimeKind.Local).AddTicks(6390), "Body-weight squats" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_ExerciseId",
                table: "Activities",
                column: "ExerciseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1271ef8c-7c7b-4d2f-b1ba-63018fe2386a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9e088791-ace2-4255-ab00-ffcc90757f6c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e9c25fa1-86a1-458c-86b1-2e98d50f9a01"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("efb4bac0-fe28-4d64-8d84-fa67a6f63661"));

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
    }
}
