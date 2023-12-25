using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FormUp.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Geolocations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Geolocations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Translations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Locale = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translations", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Gyms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gyms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gyms_Geolocations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Geolocations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExerciseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkoutId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SetsCount = table.Column<int>(type: "int", nullable: false),
                    RepetitionsCount = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkoutEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Activities_Workouts_WorkoutEntityId",
                        column: x => x.WorkoutEntityId,
                        principalTable: "Workouts",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("18701ace-5927-413a-9393-d9550d5c1221"), new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8490), new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8490), "exercises.bw-squats" },
                    { new Guid("8a0cb85e-1a38-4d86-b33a-2ad5b3cf685a"), new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8490), new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8490), "exercises.push-ups" },
                    { new Guid("b9648b00-a160-414e-b090-ca1a2360f420"), new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8440), new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8480), "exercises.pull-ups" },
                    { new Guid("d2bf04e5-4301-49b9-8912-31cf478dc753"), new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8500), new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8500), "exercises.dips" }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "CreatedAt", "Key", "Locale", "ModifiedAt", "Value" },
                values: new object[,]
                {
                    { new Guid("0043a09c-33c6-4849-aa44-e459da524d47"), new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8600), "exercises.pull-ups", "cs", new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8600), "Shyby" },
                    { new Guid("58a29f76-2cb2-43b2-873b-a9a0b4d8d1d6"), new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8630), "exercises.push-ups", "en", new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8630), "Push ups" },
                    { new Guid("639129eb-9054-4349-b057-be09fa374de4"), new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8600), "exercises.pull-ups", "en", new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8600), "Pull ups" },
                    { new Guid("7d2ee132-7a45-4b96-8226-a1254fb706d8"), new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8610), "exercises.dips", "cs", new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8610), "Dipy" },
                    { new Guid("b02ae724-3a74-4512-af82-839b3788cebc"), new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8630), "exercises.push-ups", "cs", new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8630), "Kliky" },
                    { new Guid("c3f44586-b780-46ab-9b75-7e0a9abb48a9"), new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8610), "exercises.dips", "en", new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8610), "Dips" },
                    { new Guid("cfc6c877-8087-4751-841a-300fdc7bea99"), new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8620), "exercises.bw-squats", "en", new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8630), "Body-weight squats" },
                    { new Guid("eeb0ee76-ea2f-4030-910b-1c9383a90d4b"), new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8620), "exercises.bw-squats", "cs", new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8620), "Dřepy s vlastní vahou" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_ExerciseId",
                table: "Activities",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_WorkoutEntityId",
                table: "Activities",
                column: "WorkoutEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Gyms_LocationId",
                table: "Gyms",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Translations_Locale_Key",
                table: "Translations",
                columns: new[] { "Locale", "Key" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "Gyms");

            migrationBuilder.DropTable(
                name: "Translations");

            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "Workouts");

            migrationBuilder.DropTable(
                name: "Geolocations");
        }
    }
}
