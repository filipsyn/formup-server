using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FormUp.Api.Migrations
{
    /// <inheritdoc />
    public partial class MakeWorkoutDescriptionNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6d82e9b7-2eef-4ba8-b5a4-eaf63670b35f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("81b7b597-feaf-458d-b7fc-78cc6020c039"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9e69da65-01fb-4cee-b2b9-b2d2101c19fe"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("bca2d0d3-4037-4b92-9e04-ec44faaa1b4d"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("09aa34b1-7147-45f4-9ba9-330f63fadf24"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("20debac7-bd8d-413a-b3e6-4f35d846061b"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("3104dfa3-5703-4d2d-89f3-19a1b9590547"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("370326fc-b38e-4975-a231-ca3e8fc9a123"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("720d57fd-03cb-46bf-855d-3b310b4f1a68"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("9cffa5fb-8d9e-428c-ba57-a149fe38e5e6"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("a5215b48-c7a7-4df6-a40f-9f1b9a0f66ae"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("a9871772-1c83-4399-a798-2c74aa83d231"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("afa832b5-93f7-4148-9fbd-4f7f038bdcd2"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("c464f94c-f90f-4228-a5e9-0839c1c49d10"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("09ae48fa-6e4e-4935-a2af-e66ca7ff561a"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("3be640c2-45cf-4ac6-a039-219bd3800b82"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("54ab8161-1776-4571-8832-7a93b4069c05"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("55a85f1e-fe64-479e-9043-2dce960e0f8e"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("bd588163-bd7a-41a0-b777-9fb130f3cb8a"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("bdd21b3e-0161-47c3-9b04-9c46beef206c"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("e95cf39c-2204-485e-9036-2e1af8cb78a9"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("f70f4e8e-7c47-490a-b897-9b30eab17fe5"));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Workouts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "CreatedAt", "ImageURL", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("30280a70-3209-4254-823f-84c51d5bff40"), new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(590), null, new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(590), "exercises.dips" },
                    { new Guid("3fd892d1-44f0-4328-895b-c06b1608f9ef"), new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(580), null, new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(580), "exercises.push-ups" },
                    { new Guid("5cf77793-620a-4a6e-b142-3290eeb2d424"), new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(590), null, new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(590), "exercises.bw-squats" },
                    { new Guid("8debef06-ec79-4b86-8bc0-ed2985f74305"), new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(580), null, new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(580), "exercises.pull-ups" }
                });

            migrationBuilder.InsertData(
                table: "Gyms",
                columns: new[] { "Id", "CreatedAt", "Latitude", "Longitude", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("11b3af9e-2e4f-4d42-a838-cc71c17f2766"), new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(820), 49.208489226784764, 16.605422062883459, new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(820), "Form Factory Fitness Club Lužánky" },
                    { new Guid("18140b58-51fe-414f-8254-73f9dabc8e99"), new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(800), 49.215051402565855, 16.609402145470618, new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(800), "Hulk Gym" },
                    { new Guid("29209209-6f29-4249-b139-c99c2784df66"), new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(790), 49.177089060496634, 16.606190093594201, new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(790), "AZ Fitness" },
                    { new Guid("392cbf99-8900-4440-8be8-30e4c930f18d"), new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(800), 49.180330210607991, 16.606384581697789, new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(800), "Energy Fitness Club" },
                    { new Guid("5039e69b-071d-466f-ab47-4a78add4ae95"), new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(800), 49.181262112264804, 16.60282245697524, new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(800), "NewPark Gym" },
                    { new Guid("6d3324cb-eacf-4012-86b0-0eeecbdd5c35"), new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(810), 49.190492694739753, 16.617386769256324, new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(810), "Form Factory Fitness Club Vlněna" },
                    { new Guid("70f29ff5-2c14-4b7a-8aa0-c937989c8771"), new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(780), 49.178859520009325, 16.59588166754828, new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(780), "Posilovna Velký Průvan" },
                    { new Guid("a32cd8ff-7380-4dfc-bb1f-bd23ca859d43"), new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(790), 49.179083949535297, 16.596503940037902, new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(790), "Posilovna Malý Průvan" },
                    { new Guid("d68fce2f-8614-41a9-bd7e-ba3dc766b704"), new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(810), 49.218555432690493, 16.624250854578833, new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(810), "Blackfield Gym" },
                    { new Guid("ef4d09a0-cb12-44f2-9a67-6e3dbe66cc0e"), new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(810), 49.212976899683049, 16.609015907373617, new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(810), "Fitness Boby" }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "CreatedAt", "Key", "Locale", "ModifiedAt", "Value" },
                values: new object[,]
                {
                    { new Guid("02daa530-0d15-4e95-9c07-a58c8f3e8178"), new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(720), "exercises.push-ups", "cs", new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(720), "Kliky" },
                    { new Guid("2521b9d7-4a05-43ed-87e5-ed47fceca6b4"), new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(710), "exercises.pull-ups", "en", new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(710), "Pull ups" },
                    { new Guid("25509d7c-f5d9-462a-ba1a-d2722b8646ec"), new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(710), "exercises.dips", "cs", new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(710), "Dipy" },
                    { new Guid("34d30ff9-7a8f-40ec-8e7b-696d138f4586"), new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(710), "exercises.dips", "en", new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(710), "Dips" },
                    { new Guid("715a6e33-487d-441c-adcf-10f047f94ea7"), new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(700), "exercises.pull-ups", "cs", new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(700), "Shyby" },
                    { new Guid("b3c44e54-14ac-4977-83dd-e5dfde8bf7d3"), new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(720), "exercises.bw-squats", "cs", new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(720), "Dřepy s vlastní vahou" },
                    { new Guid("cdee4e4d-bb2c-4be7-bca2-0369d9fa705d"), new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(730), "exercises.push-ups", "en", new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(730), "Push ups" },
                    { new Guid("d03deb57-6a79-4cc9-b169-3492589f1367"), new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(720), "exercises.bw-squats", "en", new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(720), "Body-weight squats" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("30280a70-3209-4254-823f-84c51d5bff40"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3fd892d1-44f0-4328-895b-c06b1608f9ef"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5cf77793-620a-4a6e-b142-3290eeb2d424"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8debef06-ec79-4b86-8bc0-ed2985f74305"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("11b3af9e-2e4f-4d42-a838-cc71c17f2766"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("18140b58-51fe-414f-8254-73f9dabc8e99"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("29209209-6f29-4249-b139-c99c2784df66"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("392cbf99-8900-4440-8be8-30e4c930f18d"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("5039e69b-071d-466f-ab47-4a78add4ae95"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("6d3324cb-eacf-4012-86b0-0eeecbdd5c35"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("70f29ff5-2c14-4b7a-8aa0-c937989c8771"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("a32cd8ff-7380-4dfc-bb1f-bd23ca859d43"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("d68fce2f-8614-41a9-bd7e-ba3dc766b704"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("ef4d09a0-cb12-44f2-9a67-6e3dbe66cc0e"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("02daa530-0d15-4e95-9c07-a58c8f3e8178"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("2521b9d7-4a05-43ed-87e5-ed47fceca6b4"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("25509d7c-f5d9-462a-ba1a-d2722b8646ec"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("34d30ff9-7a8f-40ec-8e7b-696d138f4586"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("715a6e33-487d-441c-adcf-10f047f94ea7"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("b3c44e54-14ac-4977-83dd-e5dfde8bf7d3"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("cdee4e4d-bb2c-4be7-bca2-0369d9fa705d"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("d03deb57-6a79-4cc9-b169-3492589f1367"));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Workouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "CreatedAt", "ImageURL", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("6d82e9b7-2eef-4ba8-b5a4-eaf63670b35f"), new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8340), null, new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8340), "exercises.dips" },
                    { new Guid("81b7b597-feaf-458d-b7fc-78cc6020c039"), new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8330), null, new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8330), "exercises.push-ups" },
                    { new Guid("9e69da65-01fb-4cee-b2b9-b2d2101c19fe"), new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8320), null, new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8320), "exercises.pull-ups" },
                    { new Guid("bca2d0d3-4037-4b92-9e04-ec44faaa1b4d"), new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8330), null, new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8330), "exercises.bw-squats" }
                });

            migrationBuilder.InsertData(
                table: "Gyms",
                columns: new[] { "Id", "CreatedAt", "Latitude", "Longitude", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("09aa34b1-7147-45f4-9ba9-330f63fadf24"), new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8540), 49.177089060496634, 16.606190093594201, new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8540), "AZ Fitness" },
                    { new Guid("20debac7-bd8d-413a-b3e6-4f35d846061b"), new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8550), 49.212976899683049, 16.609015907373617, new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8550), "Fitness Boby" },
                    { new Guid("3104dfa3-5703-4d2d-89f3-19a1b9590547"), new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8540), 49.179083949535297, 16.596503940037902, new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8540), "Posilovna Malý Průvan" },
                    { new Guid("370326fc-b38e-4975-a231-ca3e8fc9a123"), new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8540), 49.181262112264804, 16.60282245697524, new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8540), "NewPark Gym" },
                    { new Guid("720d57fd-03cb-46bf-855d-3b310b4f1a68"), new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8560), 49.190492694739753, 16.617386769256324, new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8560), "Form Factory Fitness Club Vlněna" },
                    { new Guid("9cffa5fb-8d9e-428c-ba57-a149fe38e5e6"), new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8550), 49.180330210607991, 16.606384581697789, new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8550), "Energy Fitness Club" },
                    { new Guid("a5215b48-c7a7-4df6-a40f-9f1b9a0f66ae"), new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8550), 49.215051402565855, 16.609402145470618, new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8550), "Hulk Gym" },
                    { new Guid("a9871772-1c83-4399-a798-2c74aa83d231"), new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8560), 49.208489226784764, 16.605422062883459, new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8560), "Form Factory Fitness Club Lužánky" },
                    { new Guid("afa832b5-93f7-4148-9fbd-4f7f038bdcd2"), new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8530), 49.178859520009325, 16.59588166754828, new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8530), "Posilovna Velký Průvan" },
                    { new Guid("c464f94c-f90f-4228-a5e9-0839c1c49d10"), new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8560), 49.218555432690493, 16.624250854578833, new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8560), "Blackfield Gym" }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "CreatedAt", "Key", "Locale", "ModifiedAt", "Value" },
                values: new object[,]
                {
                    { new Guid("09ae48fa-6e4e-4935-a2af-e66ca7ff561a"), new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8460), "exercises.dips", "en", new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8460), "Dips" },
                    { new Guid("3be640c2-45cf-4ac6-a039-219bd3800b82"), new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8470), "exercises.push-ups", "en", new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8470), "Push ups" },
                    { new Guid("54ab8161-1776-4571-8832-7a93b4069c05"), new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8450), "exercises.dips", "cs", new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8450), "Dipy" },
                    { new Guid("55a85f1e-fe64-479e-9043-2dce960e0f8e"), new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8460), "exercises.bw-squats", "en", new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8460), "Body-weight squats" },
                    { new Guid("bd588163-bd7a-41a0-b777-9fb130f3cb8a"), new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8450), "exercises.pull-ups", "en", new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8450), "Pull ups" },
                    { new Guid("bdd21b3e-0161-47c3-9b04-9c46beef206c"), new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8470), "exercises.push-ups", "cs", new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8470), "Kliky" },
                    { new Guid("e95cf39c-2204-485e-9036-2e1af8cb78a9"), new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8440), "exercises.pull-ups", "cs", new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8440), "Shyby" },
                    { new Guid("f70f4e8e-7c47-490a-b897-9b30eab17fe5"), new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8460), "exercises.bw-squats", "cs", new DateTime(2024, 1, 9, 10, 15, 34, 499, DateTimeKind.Utc).AddTicks(8460), "Dřepy s vlastní vahou" }
                });
        }
    }
}
