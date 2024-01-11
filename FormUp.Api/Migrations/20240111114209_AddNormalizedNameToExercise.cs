using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FormUp.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddNormalizedNameToExercise : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "NormalizedName",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "CreatedAt", "Description", "ImageURL", "ModifiedAt", "Name", "NormalizedName", "VideoURL" },
                values: new object[,]
                {
                    { new Guid("7ea7ecc2-6944-438e-b57a-f1ad55023d6c"), new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8410), null, null, new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8410), "exercises.bw-squats", "", null },
                    { new Guid("b8d9d6ff-bb61-4628-b3a3-a29d4971fc92"), new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8410), null, null, new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8410), "exercises.dips", "", null },
                    { new Guid("c736c63d-5e6f-4307-9b90-656d5d64b3c3"), new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8400), null, null, new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8400), "exercises.pull-ups", "", null },
                    { new Guid("e07c5410-88a9-4318-806d-c2aee77817a3"), new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8410), null, null, new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8410), "exercises.push-ups", "", null }
                });

            migrationBuilder.InsertData(
                table: "Gyms",
                columns: new[] { "Id", "CreatedAt", "Latitude", "Longitude", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("0976c9ee-20e7-44ff-b1dd-74112046c7e2"), new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8680), 49.179083949535297, 16.596503940037902, new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8680), "Posilovna Malý Průvan" },
                    { new Guid("11bb796a-9761-457f-83b5-70d06987d3e0"), new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8710), 49.208489226784764, 16.605422062883459, new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8710), "Form Factory Fitness Club Lužánky" },
                    { new Guid("2f3b7bc1-82b5-4783-a283-2f2a9f69374b"), new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8680), 49.178859520009325, 16.59588166754828, new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8680), "Posilovna Velký Průvan" },
                    { new Guid("39dbdf04-2863-4262-8827-717ef0ff97c2"), new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8700), 49.212976899683049, 16.609015907373617, new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8700), "Fitness Boby" },
                    { new Guid("51424e15-5d63-47a3-b10b-a861cef60301"), new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8690), 49.181262112264804, 16.60282245697524, new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8690), "NewPark Gym" },
                    { new Guid("66fe4507-f845-4a3a-8051-bd6640a228df"), new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8700), 49.215051402565855, 16.609402145470618, new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8700), "Hulk Gym" },
                    { new Guid("91227f27-25f3-4b91-adcd-2cb949993f36"), new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8700), 49.218555432690493, 16.624250854578833, new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8700), "Blackfield Gym" },
                    { new Guid("a505f0c1-d8a9-4682-8f31-01ac2303575b"), new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8690), 49.177089060496634, 16.606190093594201, new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8690), "AZ Fitness" },
                    { new Guid("ca57925c-e92a-4e29-8aa9-bc2aea4a0f4d"), new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8690), 49.180330210607991, 16.606384581697789, new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8690), "Energy Fitness Club" },
                    { new Guid("fe7b87b2-51bf-43cf-a5ac-06c7d31e7c03"), new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8710), 49.190492694739753, 16.617386769256324, new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8710), "Form Factory Fitness Club Vlněna" }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "CreatedAt", "Key", "Locale", "ModifiedAt", "Value" },
                values: new object[,]
                {
                    { new Guid("2507a663-82c7-4a0d-9d87-df7043b164a5"), new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8590), "exercises.dips", "en", new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8590), "Dips" },
                    { new Guid("28bf2b28-b46c-489e-bb8d-15c5b99924b1"), new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8600), "exercises.bw-squats", "en", new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8600), "Body-weight squats" },
                    { new Guid("3f4f3373-2982-4fa5-81fa-13445a727fe0"), new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8590), "exercises.dips", "cs", new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8590), "Dipy" },
                    { new Guid("611dc512-d7c4-4491-a623-613c4c38efeb"), new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8580), "exercises.pull-ups", "cs", new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8580), "Shyby" },
                    { new Guid("6987fafb-9595-4a39-b2a2-ac771b71689c"), new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8590), "exercises.pull-ups", "en", new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8590), "Pull ups" },
                    { new Guid("919a188c-e23a-4ae1-94bf-8d818c29b0f6"), new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8600), "exercises.push-ups", "cs", new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8600), "Kliky" },
                    { new Guid("a3842947-c873-443c-a659-9563a1045b96"), new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8610), "exercises.push-ups", "en", new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8610), "Push ups" },
                    { new Guid("ffba584d-7934-4e86-b6da-5bb17a4d9b59"), new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8600), "exercises.bw-squats", "cs", new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8600), "Dřepy s vlastní vahou" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7ea7ecc2-6944-438e-b57a-f1ad55023d6c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b8d9d6ff-bb61-4628-b3a3-a29d4971fc92"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c736c63d-5e6f-4307-9b90-656d5d64b3c3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e07c5410-88a9-4318-806d-c2aee77817a3"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("0976c9ee-20e7-44ff-b1dd-74112046c7e2"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("11bb796a-9761-457f-83b5-70d06987d3e0"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("2f3b7bc1-82b5-4783-a283-2f2a9f69374b"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("39dbdf04-2863-4262-8827-717ef0ff97c2"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("51424e15-5d63-47a3-b10b-a861cef60301"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("66fe4507-f845-4a3a-8051-bd6640a228df"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("91227f27-25f3-4b91-adcd-2cb949993f36"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("a505f0c1-d8a9-4682-8f31-01ac2303575b"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("ca57925c-e92a-4e29-8aa9-bc2aea4a0f4d"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("fe7b87b2-51bf-43cf-a5ac-06c7d31e7c03"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("2507a663-82c7-4a0d-9d87-df7043b164a5"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("28bf2b28-b46c-489e-bb8d-15c5b99924b1"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("3f4f3373-2982-4fa5-81fa-13445a727fe0"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("611dc512-d7c4-4491-a623-613c4c38efeb"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("6987fafb-9595-4a39-b2a2-ac771b71689c"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("919a188c-e23a-4ae1-94bf-8d818c29b0f6"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("a3842947-c873-443c-a659-9563a1045b96"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("ffba584d-7934-4e86-b6da-5bb17a4d9b59"));

            migrationBuilder.DropColumn(
                name: "NormalizedName",
                table: "Exercises");

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
    }
}
