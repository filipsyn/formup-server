using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FormUp.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreInfoToExercise : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoURL",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "CreatedAt", "Description", "ImageURL", "ModifiedAt", "Name", "VideoURL" },
                values: new object[,]
                {
                    { new Guid("4937552e-83fd-4d2d-95fd-25a56305d24c"), new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3640), null, null, new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3640), "exercises.dips", null },
                    { new Guid("77b333d4-6c32-4cf1-aa07-22f927a3d0d1"), new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3640), null, null, new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3640), "exercises.bw-squats", null },
                    { new Guid("78e85903-1db1-4d60-804c-c6607cc71ade"), new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3630), null, null, new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3640), "exercises.push-ups", null },
                    { new Guid("90eae3ff-9ea6-4fa9-aeec-dcf7022a5cc9"), new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3630), null, null, new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3630), "exercises.pull-ups", null }
                });

            migrationBuilder.InsertData(
                table: "Gyms",
                columns: new[] { "Id", "CreatedAt", "Latitude", "Longitude", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("26621dd4-e217-4261-b9bb-6c3b5a281cb1"), new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3900), 49.190492694739753, 16.617386769256324, new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3900), "Form Factory Fitness Club Vlněna" },
                    { new Guid("48812fd6-a76f-4315-9b21-fc07956b3d02"), new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3890), 49.218555432690493, 16.624250854578833, new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3890), "Blackfield Gym" },
                    { new Guid("5bbdfd2a-697d-42a3-aa5d-76feadacc38f"), new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3880), 49.180330210607991, 16.606384581697789, new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3880), "Energy Fitness Club" },
                    { new Guid("673d44f3-d314-4e97-916b-5494a833f9e1"), new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3900), 49.208489226784764, 16.605422062883459, new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3900), "Form Factory Fitness Club Lužánky" },
                    { new Guid("96d34bb6-b2a4-4af6-9f66-ab0b1561bbda"), new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3870), 49.178859520009325, 16.59588166754828, new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3870), "Posilovna Velký Průvan" },
                    { new Guid("9e2741de-6168-4e61-9b23-63d96afcbc3d"), new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3890), 49.215051402565855, 16.609402145470618, new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3890), "Hulk Gym" },
                    { new Guid("b083e8b5-e651-4031-af44-a07c2a3c1386"), new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3880), 49.181262112264804, 16.60282245697524, new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3880), "NewPark Gym" },
                    { new Guid("cc67c780-0bdd-4b7f-86f6-068fc72da085"), new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3890), 49.212976899683049, 16.609015907373617, new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3890), "Fitness Boby" },
                    { new Guid("eb3e7dbe-c884-4597-9724-1c3ad5d123d3"), new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3880), 49.177089060496634, 16.606190093594201, new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3880), "AZ Fitness" },
                    { new Guid("ed26e15e-acfd-4412-bac3-8d41ef697632"), new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3870), 49.179083949535297, 16.596503940037902, new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3870), "Posilovna Malý Průvan" }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "CreatedAt", "Key", "Locale", "ModifiedAt", "Value" },
                values: new object[,]
                {
                    { new Guid("0407ba5c-70b7-41a1-a157-9dd6ae7c188a"), new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3770), "exercises.pull-ups", "en", new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3770), "Pull ups" },
                    { new Guid("49b1a5c6-d6dc-469f-9cd8-bab4afc9990d"), new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3770), "exercises.pull-ups", "cs", new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3770), "Shyby" },
                    { new Guid("4bea092f-d94f-4907-bda5-93863376f89b"), new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3790), "exercises.bw-squats", "en", new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3790), "Body-weight squats" },
                    { new Guid("a73a0573-3339-4b93-b41d-863959bbfd17"), new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3770), "exercises.dips", "cs", new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3780), "Dipy" },
                    { new Guid("a889f3d2-ce9a-4e60-8bf7-e1a821dbc0f3"), new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3780), "exercises.dips", "en", new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3780), "Dips" },
                    { new Guid("b29d716d-3e91-4afe-8bef-afa871e54440"), new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3780), "exercises.bw-squats", "cs", new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3780), "Dřepy s vlastní vahou" },
                    { new Guid("ecadd1a5-496a-4ce9-ae48-720381df7718"), new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3790), "exercises.push-ups", "cs", new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3790), "Kliky" },
                    { new Guid("fe74adc9-a66f-4dd1-b0d5-dac004f74093"), new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3790), "exercises.push-ups", "en", new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3790), "Push ups" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4937552e-83fd-4d2d-95fd-25a56305d24c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("77b333d4-6c32-4cf1-aa07-22f927a3d0d1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("78e85903-1db1-4d60-804c-c6607cc71ade"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("90eae3ff-9ea6-4fa9-aeec-dcf7022a5cc9"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("26621dd4-e217-4261-b9bb-6c3b5a281cb1"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("48812fd6-a76f-4315-9b21-fc07956b3d02"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("5bbdfd2a-697d-42a3-aa5d-76feadacc38f"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("673d44f3-d314-4e97-916b-5494a833f9e1"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("96d34bb6-b2a4-4af6-9f66-ab0b1561bbda"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("9e2741de-6168-4e61-9b23-63d96afcbc3d"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("b083e8b5-e651-4031-af44-a07c2a3c1386"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("cc67c780-0bdd-4b7f-86f6-068fc72da085"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("eb3e7dbe-c884-4597-9724-1c3ad5d123d3"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("ed26e15e-acfd-4412-bac3-8d41ef697632"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("0407ba5c-70b7-41a1-a157-9dd6ae7c188a"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("49b1a5c6-d6dc-469f-9cd8-bab4afc9990d"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("4bea092f-d94f-4907-bda5-93863376f89b"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("a73a0573-3339-4b93-b41d-863959bbfd17"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("a889f3d2-ce9a-4e60-8bf7-e1a821dbc0f3"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("b29d716d-3e91-4afe-8bef-afa871e54440"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("ecadd1a5-496a-4ce9-ae48-720381df7718"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("fe74adc9-a66f-4dd1-b0d5-dac004f74093"));

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "VideoURL",
                table: "Exercises");

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
    }
}
