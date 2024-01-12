using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FormUp.Api.Migrations
{
    /// <inheritdoc />
    public partial class RemoveGeolocationEntity : Migration
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
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.Id);
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
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VerifiedAtGymId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                        name: "FK_Activities_Workouts_WorkoutId",
                        column: x => x.WorkoutId,
                        principalTable: "Workouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "CreatedAt", "Description", "ImageURL", "ModifiedAt", "Name", "NormalizedName", "VideoURL" },
                values: new object[,]
                {
                    { new Guid("2a0e76a3-9fe8-4257-a248-ebb0e939dd0c"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2220), "exercises.dead-lift.description", "https://miro.medium.com/v2/resize:fit:1024/0*UkQCo1eLsXjoXn4v.jpg", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2220), "exercises.dead-lift.name", "exercises.dead-lift.normalized-name", null },
                    { new Guid("33eab256-b60e-4636-9ae8-708b6939ce0c"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2240), "exercises.bench-press.description", "https://caliberstrong.com/wp-content/uploads/2020/04/how-to-bench-press.jpg", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2240), "exercises.bench-press.name", "exercises.bench-press.normalized-name", null },
                    { new Guid("3c5d332c-696e-4611-a592-cb13bb087401"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2240), "exercises.push-up.description", "https://www.fitnesseducation.edu.au/wp-content/uploads/2017/03/Pushups.jpg", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2240), "exercises.push-up.name", "exercises.push-up.normalized-name", null },
                    { new Guid("514321a0-5d0d-4cfb-857f-6b8679fce0fe"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2240), "exercises.lunge.description", "https://hortonbarbell.com/wp-content/uploads/2022/05/Dumbbell-Lunge.png", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2240), "exercises.lunge.name", "exercises.lunge.normalized-name", null },
                    { new Guid("5cb97205-9e18-4fdc-b8d5-489983f60595"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2230), "exercises.shoulder-press.description", "https://legionathletics.com/wp-content/uploads/2023/10/Dumbbell-Shoulder-Press-before-after.png", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2230), "exercises.shoulder-press.name", "exercises.shoulder-press.normalized-name", null },
                    { new Guid("888d4c00-f2cf-410f-8904-809c8ce88d3a"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2230), "exercises.dip.description", "https://www.muscleandfitness.com/wp-content/uploads/2018/07/1109-dip.jpg?w=800&quality=86&strip=all", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2230), "exercises.dip.name", "exercises.dip.normalized-name", null },
                    { new Guid("8aa97653-ca11-4875-8e66-517b0f2f63fa"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2250), "exercises.curl.description", "https://hortonbarbell.com/wp-content/uploads/2023/01/How-To-Do-Tempo-Bicep-Curls.png", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2250), "exercises.curl.name", "exercises.curl.normalized-name", null },
                    { new Guid("c0c54c39-69eb-421e-ac62-b418a622647a"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2230), "exercises.pull-up.description", "https://hips.hearstapps.com/hmg-prod/images/mh0418-fit-pul-01-1558551798.jpg?crop=0.749xw:1.00xh;0.251xw,0&resize=1200:*", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2230), "exercises.pull-up.name", "exercises.pull-up.normalized-name", null },
                    { new Guid("ebc4c6aa-fe13-4a7d-8c8e-c0f1ccc0c70c"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2220), "exercises.squat.description", "https://legionathletics.com/wp-content/uploads/2019/05/arnold-squat.jpg", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2220), "exercises.squat.name", "exercises.squat.normalized-name", null }
                });

            migrationBuilder.InsertData(
                table: "Gyms",
                columns: new[] { "Id", "CreatedAt", "Latitude", "Longitude", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("11921590-5343-4584-9b94-c916c1ec2709"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2670), 49.208489226784764, 16.605422062883459, new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2670), "Form Factory Fitness Club Lužánky" },
                    { new Guid("24be6dca-1ab2-4e3e-bb49-8bce3ef60096"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2670), 49.190492694739753, 16.617386769256324, new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2670), "Form Factory Fitness Club Vlněna" },
                    { new Guid("26179dee-1502-4fe7-a8e3-a724aada497b"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2660), 49.215051402565855, 16.609402145470618, new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2660), "Hulk Gym" },
                    { new Guid("4b97dd29-10f4-4d2b-8849-54102503e434"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2640), 49.178859520009325, 16.59588166754828, new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2640), "Posilovna Velký Průvan" },
                    { new Guid("5f9c4a54-6d29-4a53-be86-2f4074e4a372"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2670), 49.218555432690493, 16.624250854578833, new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2670), "Blackfield Gym" },
                    { new Guid("714924be-bbcd-4bb2-86d8-e3477eab393d"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2650), 49.177089060496634, 16.606190093594201, new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2650), "AZ Fitness" },
                    { new Guid("a3356ec3-32db-4f24-a71a-a81389f65823"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2660), 49.180330210607991, 16.606384581697789, new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2660), "Energy Fitness Club" },
                    { new Guid("b87145da-4706-403e-9a49-744300b1a99a"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2660), 49.212976899683049, 16.609015907373617, new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2660), "Fitness Boby" },
                    { new Guid("bea87b4f-6620-408c-bec7-cbdc677d2fd6"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2650), 49.181262112264804, 16.60282245697524, new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2650), "NewPark Gym" },
                    { new Guid("ee0b7080-7fdc-48c3-a15c-3a6274daa266"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2650), 49.179083949535297, 16.596503940037902, new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2650), "Posilovna Malý Průvan" }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "CreatedAt", "Key", "Locale", "ModifiedAt", "Value" },
                values: new object[,]
                {
                    { new Guid("08c10cb8-8b3a-4932-85f0-0cb3726f0f52"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2400), "exercises.dead-lift.normalized-name", "en", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2400), "DEADLIFT" },
                    { new Guid("0eae7af6-b3e2-47c4-84fa-c2d463945995"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2370), "exercises.squat.name", "cs", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2370), "Dřep" },
                    { new Guid("1d07f874-1c66-418b-ac4e-43a7a756ead4"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2550), "exercises.curl.normalized-name", "cs", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2550), "BICEPSOVYZDVIH" },
                    { new Guid("1e0dfc24-4439-493a-948d-b35a37f3d51b"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2480), "exercises.bench-press.name", "cs", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2480), "Bench press" },
                    { new Guid("1ec6665d-590c-4ca1-988c-c8d95bc1aac0"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2490), "exercises.bench-press.normalized-name", "cs", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2490), "BENCHPRESS" },
                    { new Guid("201b7530-b784-4d71-a42b-2d92d288ac50"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2380), "exercises.squat.normalized-name", "en", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2380), "SQUAT" },
                    { new Guid("22d7f88f-ffce-4a94-823b-cfdc0779b6ee"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2490), "exercises.bench-press.description", "cs", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2490), "Bench-press je klasický cvik pro posílení hrudníku, tricepse a delt. " },
                    { new Guid("28b30fc1-5beb-4133-a4c1-6eb1b76619d6"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2400), "exercises.dead-lift.normalized-name", "cs", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2400), "MRTVYTAH" },
                    { new Guid("2a021daa-4e28-4ddd-8112-a3158e5eb20e"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2390), "exercises.squat.description", "cs", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2390), "Dřep posiluje dolní část těla, především nohy, hamstrings a hýždě. Vykonává se stáním s váhou na ramenou a poklesem do pravého úhlu v kolenou." },
                    { new Guid("2d958181-3461-498d-9129-5039fc74717b"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2390), "exercises.squat.description", "en", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2390), "A fundamental lower body exercise targeting the legs, hamstrings, and glutes. Stand with feet shoulder-width apart, lower your body by bending your knees, and return to the starting position." },
                    { new Guid("2e8c3810-1f95-4815-aef2-da0c9a94ecd1"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2560), "exercises.curl.description", "cs", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2560), "Bicepsový zdvih cílí na posílení bicepsů a vykonává se zdvihem váhy směrem k ramenům při ohnutí v loktech." },
                    { new Guid("31e92d13-aa34-460c-8835-427cc10a43d9"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2450), "exercises.dip.name", "en", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2450), "Dip" },
                    { new Guid("369f8fde-40c1-4afb-91a8-ee64cafdf701"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2370), "exercises.squat.name", "en", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2370), "Squat" },
                    { new Guid("39b355cc-d43d-4e9d-bd5c-4bb725a961c3"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2440), "exercises.pull-up.normalized-name", "en", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2440), "PULLUP" },
                    { new Guid("440a2c65-497e-457a-827b-e141e3859acf"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2540), "exercises.curl.name", "cs", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2540), "Bicepsový zdvih" },
                    { new Guid("4688fbb1-18d8-47b2-af3b-d919e4060f7d"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2490), "exercises.bench-press.description", "en", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2490), "A classic chest exercise focusing on the pectoral muscles. Lie on a bench, lower and lift a barbell or dumbbells to and from your chest." },
                    { new Guid("47aacc71-9c5c-4396-8cef-b4e37b4b0c07"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2510), "exercises.lunge.description", "en", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2510), "A lower body exercise targeting the legs and glutes. Take a step forward with one leg, lower your body until both knees form right angles, then return to the starting position." },
                    { new Guid("4af29b43-e24a-4e1c-a904-265dcf05d1f7"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2450), "exercises.pull-up.description", "en", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2450), "An effective upper body exercise primarily targeting the back and biceps. Hang from a bar with palms facing away, pull your body up until your chin passes the bar, and lower back down." },
                    { new Guid("4b6332f5-de73-47b0-857c-55d147ee4c44"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2510), "exercises.lunge.normalized-name", "cs", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2510), "VYPAD" },
                    { new Guid("56c31c65-bf72-4e37-a8e7-d9c588ea2579"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2480), "exercises.bench-press.normalized-name", "en", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2480), "BENCHPRESS" },
                    { new Guid("6bb28e4b-8e7b-452c-aae9-002063fac5b5"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2470), "exercises.dip.description", "cs", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2470), "Kliky na bradlech posilují horní část těla, zejména hrudník, tricepsy a deltové svaly." },
                    { new Guid("70922f74-f991-4457-a476-7599b30478ce"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2470), "exercises.dip.description", "en", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2470), "An isolation exercise for the triceps and chest. Support yourself on parallel bars, lower your body by bending your elbows, and push back up." },
                    { new Guid("7803a748-208f-498c-8a46-633b17b7c742"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2500), "exercises.lunge.name", "cs", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2500), "Výpad" },
                    { new Guid("79f3b8e9-2776-4093-812d-9c2ad89acbf2"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2440), "exercises.pull-up.normalized-name", "cs", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2440), "SHYB" },
                    { new Guid("7d210988-6868-46de-8ebe-83d1c051a144"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2530), "exercises.push-up.description", "cs", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2530), "Kliky jsou cvik na posílení horní části těla, zvláště hrudníku, tricepsů a deltových svalů. Provádí se opakováním zvedání a spouštění těla, kdy se opíráte o ruce na zemi a tlačíte se nahoru a dolů." },
                    { new Guid("84620e58-4de4-48d3-92d1-01bceb1efe36"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2550), "exercises.curl.normalized-name", "en", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2550), "BICEPCURL" },
                    { new Guid("89e64ff6-d0d3-4e13-b177-6e6a441a6531"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2510), "exercises.lunge.description", "cs", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2510), "Výpad je cvik na dolní část těla, střídavým krokem dopředu a poklesem kolena k zemi." },
                    { new Guid("8e081f4c-9ab2-4e02-b900-504d419ba5b8"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2470), "exercises.bench-press.name", "en", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2470), "Bench press" },
                    { new Guid("9302ba8e-7311-4efe-a22f-5ee11cd2f22f"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2550), "exercises.curl.description", "en", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2550), "An isolation exercise for the biceps. Stand with weights in hand, palms facing forward, and curl the weights towards your shoulders by bending at the elbows." },
                    { new Guid("96647b23-c657-44b0-a4c2-09c9ad98a879"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2460), "exercises.dip.normalized-name", "en", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2460), "DIP" },
                    { new Guid("9a384f16-736b-485a-9e9c-84f0433b3d8d"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2470), "exercises.dip.normalized-name", "cs", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2470), "KLIKNABRADLECH" },
                    { new Guid("a16a04ea-d22b-4041-a463-92a9ceef8b20"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2430), "exercises.pull-up.name", "en", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2430), "Pull up" },
                    { new Guid("a3a59ae6-2479-4c97-b78d-70d9ba4b708d"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2520), "exercises.push-up.name", "en", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2520), "Push up" },
                    { new Guid("a8f2b9cb-c9d3-4e49-a204-1986d7e55442"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2520), "exercises.push-up.normalized-name", "en", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2520), "PUSHUP" },
                    { new Guid("ab09082e-16c3-4a5b-8546-1390d06f459d"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2460), "exercises.dip.name", "cs", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2460), "Klik na bradlech" },
                    { new Guid("ae78df6c-9c2a-43e5-92af-bd835d34e392"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2410), "exercises.shoulder-press.name", "en", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2410), "Shoulder press" },
                    { new Guid("b05d3652-edc4-4d82-8e9e-500f036e1574"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2500), "exercises.lunge.normalized-name", "en", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2500), "LUNGE" },
                    { new Guid("b718b5fe-e32c-4a19-85d9-e8a2945ce2d5"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2530), "exercises.push-up.description", "en", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2530), "A versatile exercise engaging the chest, shoulders, and triceps. Start in a plank position, lower your body to the ground, and push back up." },
                    { new Guid("bb668781-8f2b-402f-a357-f9984a225c61"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2430), "exercises.shoulder-press.description", "en", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2430), "An upper body exercise concentrating on shoulder muscles. Whether sitting or standing, press weights or other resistance overhead, emphasizing controlled movements." },
                    { new Guid("bce3da81-fe47-4dc4-b04e-4b4309d09165"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2450), "exercises.pull-up.description", "cs", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2450), "Shyb je izolovaný cvik pro tricepsy, provádí se zvedáním váhy pomocí prodloužení paže." },
                    { new Guid("be5f8ad5-9286-4636-a7c2-b7f184520ba4"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2420), "exercises.shoulder-press.normalized-name", "cs", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2420), "TLAKNARAMENA" },
                    { new Guid("c11973b5-6fc9-4a9b-816d-6a7f969e61bc"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2390), "exercises.dead-lift.name", "en", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2390), "Dead-lift" },
                    { new Guid("c38c015c-2933-40e5-9f62-4a522aa6c6cc"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2490), "exercises.lunge.name", "en", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2500), "Lunge" },
                    { new Guid("c44d3c9c-7871-41d8-aefe-b4ad525822cc"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2410), "exercises.dead-lift.description", "cs", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2410), "Mrtvý tah je cvik na posílení zad, hýždí a hamstringů, provedený ohnutím v pase a zdvihem váhy z podlahy s udržením rovné páteře." },
                    { new Guid("c6ba98e8-d907-4e67-a56e-57f5a5b92bb0"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2410), "exercises.dead-lift.description", "en", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2410), "A compound exercise for overall strength, focusing on the back, glutes, hamstrings, and lower back. Start with the weight on the ground, hinge at the hips, lift the weight by straightening your hips and knees." },
                    { new Guid("d067c66d-4b4e-4966-97ee-c3d37752c82f"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2380), "exercises.squat.normalized-name", "cs", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2380), "DREP" },
                    { new Guid("d8abf6e6-bc1c-4cdf-b39f-7574e4fbaaa1"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2400), "exercises.dead-lift.name", "cs", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2400), "Mrtvý tah" },
                    { new Guid("dc26ce0e-557a-4b71-83cc-e05b27bfc2ef"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2430), "exercises.shoulder-press.description", "cs", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2430), "Tlaky na ramena zaměřují se na posílení ramenních svalů a vykonávají se tlačením činek nad hlavu." },
                    { new Guid("dd90983d-0f7e-4249-9a2a-a62043b0478b"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2420), "exercises.shoulder-press.name", "cs", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2420), "Tlak na ramena" },
                    { new Guid("e5711465-7973-4c66-ba58-c0f6159c745d"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2520), "exercises.push-up.name", "cs", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2520), "Klik" },
                    { new Guid("e6289d08-c06b-4d1e-ac0c-35b909feaa1a"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2420), "exercises.shoulder-press.normalized-name", "en", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2420), "SHOULDERPRESS" },
                    { new Guid("ef50e405-89e6-4343-b1a2-a6e1a298a642"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2530), "exercises.push-up.normalized-name", "cs", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2530), "KLIK" },
                    { new Guid("f1895f23-cb15-4439-aa0a-1bf4963464b7"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2540), "exercises.curl.name", "en", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2540), "Bicep curl" },
                    { new Guid("fe2bc350-e7a0-41c3-98ac-3413236317ff"), new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2440), "exercises.pull-up.name", "cs", new DateTime(2024, 1, 12, 17, 42, 12, 780, DateTimeKind.Utc).AddTicks(2440), "Shyb" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_ExerciseId",
                table: "Activities",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_WorkoutId",
                table: "Activities",
                column: "WorkoutId");

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
