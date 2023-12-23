using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FormUp.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddWorkoutsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<Guid>(
                name: "WorkoutEntityId",
                table: "Activities",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Workouts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workouts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("35fb6cd8-3f39-4928-adf3-5f86407272b4"), new DateTime(2023, 12, 21, 12, 26, 46, 450, DateTimeKind.Local).AddTicks(9280), new DateTime(2023, 12, 21, 12, 26, 46, 450, DateTimeKind.Local).AddTicks(9280), "Body-weight squats" },
                    { new Guid("93436d4a-4b0d-4724-8d19-f4976d0cbf03"), new DateTime(2023, 12, 21, 12, 26, 46, 450, DateTimeKind.Local).AddTicks(9210), new DateTime(2023, 12, 21, 12, 26, 46, 450, DateTimeKind.Local).AddTicks(9270), "Pull ups" },
                    { new Guid("c61abd0f-8031-4fdd-9773-1e4a3ed46432"), new DateTime(2023, 12, 21, 12, 26, 46, 450, DateTimeKind.Local).AddTicks(9280), new DateTime(2023, 12, 21, 12, 26, 46, 450, DateTimeKind.Local).AddTicks(9290), "Dips" },
                    { new Guid("ddbfbad7-c919-43a8-a4f5-4e848e4c166e"), new DateTime(2023, 12, 21, 12, 26, 46, 450, DateTimeKind.Local).AddTicks(9270), new DateTime(2023, 12, 21, 12, 26, 46, 450, DateTimeKind.Local).AddTicks(9280), "Push ups" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_WorkoutEntityId",
                table: "Activities",
                column: "WorkoutEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Workouts_WorkoutEntityId",
                table: "Activities",
                column: "WorkoutEntityId",
                principalTable: "Workouts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Workouts_WorkoutEntityId",
                table: "Activities");

            migrationBuilder.DropTable(
                name: "Workouts");

            migrationBuilder.DropIndex(
                name: "IX_Activities_WorkoutEntityId",
                table: "Activities");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("35fb6cd8-3f39-4928-adf3-5f86407272b4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("93436d4a-4b0d-4724-8d19-f4976d0cbf03"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c61abd0f-8031-4fdd-9773-1e4a3ed46432"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ddbfbad7-c919-43a8-a4f5-4e848e4c166e"));

            migrationBuilder.DropColumn(
                name: "WorkoutEntityId",
                table: "Activities");

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
        }
    }
}
