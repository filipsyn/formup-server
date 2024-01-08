using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FormUp.Api.Migrations
{
    /// <inheritdoc />
    public partial class FlattenGymEntity : Migration
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
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "Gyms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gyms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Heights",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Uid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<float>(type: "real", nullable: false),
                    At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heights", x => x.Id);
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
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Uid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Weights",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Uid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<float>(type: "real", nullable: false),
                    At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weights", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Workouts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workouts", x => x.Id);
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
                columns: new[] { "Id", "CreatedAt", "ImageURL", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("43d9f9a4-bf79-4846-a663-d341f0bf6c42"), new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1560), null, new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1560), "exercises.push-ups" },
                    { new Guid("88e7ec78-19ba-488a-ae35-cbe8b73c6b95"), new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1570), null, new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1570), "exercises.dips" },
                    { new Guid("ab678f09-64de-4948-a5cb-4afd89233519"), new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1570), null, new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1570), "exercises.bw-squats" },
                    { new Guid("c6b0fc4b-4bb3-4558-b836-1fb4cffe7f8a"), new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1560), null, new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1560), "exercises.pull-ups" }
                });

            migrationBuilder.InsertData(
                table: "Gyms",
                columns: new[] { "Id", "CreatedAt", "Latitude", "Longitude", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("159d754f-22ac-49ad-8433-a0ca5a9f7eab"), new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1790), 49.179083949535297, 16.596503940037902, new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1790), "Posilovna Malý Průvan" },
                    { new Guid("20f25d9c-202b-4232-b8b9-e2cc6537c5df"), new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1820), 49.208489226784764, 16.605422062883459, new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1820), "Form Factory Fitness Club Lužánky" },
                    { new Guid("56fc3c5a-c7a8-45d2-b62a-2214c55aff05"), new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1800), 49.181262112264804, 16.60282245697524, new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1800), "NewPark Gym" },
                    { new Guid("78756b68-8058-47ce-8d7d-841fa88f7907"), new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1790), 49.178859520009325, 16.59588166754828, new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1790), "Posilovna Velký Průvan" },
                    { new Guid("802a6865-673d-4482-aa01-8cde224812a9"), new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1810), 49.218555432690493, 16.624250854578833, new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1810), "Blackfield Gym" },
                    { new Guid("9f66e191-0334-4f19-a268-4bf6ded24d3f"), new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1800), 49.180330210607991, 16.606384581697789, new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1800), "Energy Fitness Club" },
                    { new Guid("ae27a7ee-cab0-4e34-a216-58bff11c4066"), new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1810), 49.212976899683049, 16.609015907373617, new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1810), "Fitness Boby" },
                    { new Guid("da729ca4-8a99-4bdb-b3e2-f0cbc0ef884a"), new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1800), 49.215051402565855, 16.609402145470618, new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1810), "Hulk Gym" },
                    { new Guid("f0807feb-791b-475c-a1ac-d3ed09a2cae3"), new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1820), 49.190492694739753, 16.617386769256324, new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1820), "Form Factory Fitness Club Vlněna" },
                    { new Guid("fc87cb09-5def-4bfe-b6f9-fcff9b435718"), new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1790), 49.177089060496634, 16.606190093594201, new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1790), "AZ Fitness" }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "CreatedAt", "Key", "Locale", "ModifiedAt", "Value" },
                values: new object[,]
                {
                    { new Guid("3f23de4b-7b98-4bd0-99ef-61710836ba98"), new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1700), "exercises.pull-ups", "cs", new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1700), "Shyby" },
                    { new Guid("44c82199-a689-4a6b-bf63-32263fb0c768"), new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1720), "exercises.push-ups", "en", new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1720), "Push ups" },
                    { new Guid("6a7d0327-0491-433c-8ee5-a5080e037ef9"), new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1720), "exercises.push-ups", "cs", new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1720), "Kliky" },
                    { new Guid("875a290e-51fa-4649-9072-82dc5b9795c6"), new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1720), "exercises.bw-squats", "en", new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1720), "Body-weight squats" },
                    { new Guid("95a4e116-6601-4cbb-9848-3ac6dff30644"), new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1700), "exercises.dips", "cs", new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1700), "Dipy" },
                    { new Guid("a8cd94d5-1d23-42ce-aaa9-c8dc86dd0ae4"), new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1700), "exercises.pull-ups", "en", new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1700), "Pull ups" },
                    { new Guid("b7b237ca-e098-42a6-9b15-dd57eecd8d65"), new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1710), "exercises.bw-squats", "cs", new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1710), "Dřepy s vlastní vahou" },
                    { new Guid("f013a1d3-3fca-4a40-b09a-afb17f176a60"), new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1710), "exercises.dips", "en", new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1710), "Dips" }
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
                name: "IX_Heights_Uid",
                table: "Heights",
                column: "Uid");

            migrationBuilder.CreateIndex(
                name: "IX_Translations_Locale_Key",
                table: "Translations",
                columns: new[] { "Locale", "Key" });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Uid",
                table: "Users",
                column: "Uid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Weights_Uid",
                table: "Weights",
                column: "Uid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "Geolocations");

            migrationBuilder.DropTable(
                name: "Gyms");

            migrationBuilder.DropTable(
                name: "Heights");

            migrationBuilder.DropTable(
                name: "Translations");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Weights");

            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "Workouts");
        }
    }
}
