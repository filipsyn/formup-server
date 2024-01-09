using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FormUp.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddVerifiedAtGymId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("43d9f9a4-bf79-4846-a663-d341f0bf6c42"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("88e7ec78-19ba-488a-ae35-cbe8b73c6b95"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ab678f09-64de-4948-a5cb-4afd89233519"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c6b0fc4b-4bb3-4558-b836-1fb4cffe7f8a"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("159d754f-22ac-49ad-8433-a0ca5a9f7eab"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("20f25d9c-202b-4232-b8b9-e2cc6537c5df"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("56fc3c5a-c7a8-45d2-b62a-2214c55aff05"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("78756b68-8058-47ce-8d7d-841fa88f7907"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("802a6865-673d-4482-aa01-8cde224812a9"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("9f66e191-0334-4f19-a268-4bf6ded24d3f"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("ae27a7ee-cab0-4e34-a216-58bff11c4066"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("da729ca4-8a99-4bdb-b3e2-f0cbc0ef884a"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("f0807feb-791b-475c-a1ac-d3ed09a2cae3"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("fc87cb09-5def-4bfe-b6f9-fcff9b435718"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("3f23de4b-7b98-4bd0-99ef-61710836ba98"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("44c82199-a689-4a6b-bf63-32263fb0c768"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("6a7d0327-0491-433c-8ee5-a5080e037ef9"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("875a290e-51fa-4649-9072-82dc5b9795c6"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("95a4e116-6601-4cbb-9848-3ac6dff30644"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("a8cd94d5-1d23-42ce-aaa9-c8dc86dd0ae4"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("b7b237ca-e098-42a6-9b15-dd57eecd8d65"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("f013a1d3-3fca-4a40-b09a-afb17f176a60"));

            migrationBuilder.AddColumn<Guid>(
                name: "VerifiedAtGymId",
                table: "Workouts",
                type: "uniqueidentifier",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "VerifiedAtGymId",
                table: "Workouts");

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
        }
    }
}
