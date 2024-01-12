using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FormUp.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddWorkoutBackingFieldToActivity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Workouts_WorkoutEntityId",
                table: "Activities");

            migrationBuilder.DropIndex(
                name: "IX_Activities_WorkoutEntityId",
                table: "Activities");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0a544b9f-cb83-4dd5-a6e6-3d7dafd1c3f9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3402086c-4353-4e4d-b1c0-8a9da1888d96"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("47bad8bd-6116-4824-b20a-970555533098"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6eeb8a04-3209-4e17-bc4e-52349e1b9678"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("85d567ed-2ecf-4ccd-acab-0110c838bbc9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("cb68be57-94ce-4149-8d0e-7db6c7706b5a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ea176a07-39e4-439c-a3be-08a1ffee51c8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f478d873-d2e7-4deb-8f15-6d5bfdde550b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fe7e5db1-ae3c-4087-bd0d-4da92193ea93"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("02a0d371-de5a-4f6f-80e6-8c8a04e8cafb"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("06ede792-e5b9-4575-9c25-37d6095e6871"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("10e4b565-bc4e-49ef-bdb4-a528d7d65f39"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("2064c892-395c-4806-a005-5a3cbe2607c2"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("3e9fefef-6515-44c7-b2e4-e12d7df7ac5f"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("40fc84f3-a907-44fd-8a3f-b00829aff78d"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("42994c66-5a02-45b7-8545-e3323db1120c"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("a80750cf-e4b1-4838-9a8b-3376b7cde476"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("d69c2bbf-052d-4088-9729-f7ea854e0d47"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("e64f70fc-fffe-42ea-8ae1-43cc5ce5c9a0"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("00ca0392-333d-42a7-a545-4c6212e087ef"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("0283691f-f64a-44f2-bedb-2c63b5a397ef"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("05674422-29af-4c8d-b20c-26468fb934af"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("09a168f6-cab3-4dd1-858f-ebc5c0cb7307"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("1253c3b7-c89b-46ab-9fd4-c4b5c74ed251"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("16eeb543-fea1-4d58-98b9-424b44f72213"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("17a20bbe-1ddd-4b9a-953f-cc791455169d"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("1e131325-e252-4fcb-93f4-666730d508ef"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("1f56a490-7552-47e0-824a-acd6fcf61234"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("284039c9-06df-4839-b7d9-b83e69f76542"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("2ea6cd3d-e8f4-4528-9099-201f2e5f34fe"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("30c045cb-c334-4376-abe8-e65f6d58c729"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("34b6ec59-5a9e-43f6-b3a9-038e089479c9"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("437b14d0-8577-4a34-964c-d04204273c46"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("4415e57c-4073-4f52-82be-7e8142753193"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("47b71aa7-2419-4778-8c93-a9894805150e"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("4ef6bc65-b7d6-444a-8995-5e99dd0d7f0d"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("5221f95f-6dd3-48f3-9a13-ff7650da4ad8"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("541fd8cf-65e4-453d-93a5-9c54102ba8dd"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("55189d16-106d-4389-ba7e-5c3e430e4d14"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("57d7b225-8944-4867-a5dc-74be46bbbe17"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("58e24599-6323-4590-8b4e-e9121f9f41b9"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("5dca569b-666b-4e05-b1ba-64b2e7ea2e20"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("5ef99cf2-e0d9-4967-8485-8a725d7a21f6"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("60234e5a-3b4f-49df-b42b-8728f0cfe510"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("62cf4746-16a7-4a00-9ffd-3cb473639b06"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("65f525eb-bb17-4f57-ae5f-547997207968"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("7ae636ba-4c52-4305-b5c9-dfb08aa166ee"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("8bff3351-c3e9-4974-b72b-ad3224d69a54"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("925de2bd-1da0-4d49-b3da-19243d38579c"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("94365bd2-9438-4da4-bc93-55932180e023"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("9d20c4b6-28f6-4bb1-955d-aa402710a289"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("9d8e69e7-6db6-4c49-9ca1-a3439c710e3d"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("a19baf8e-bd04-4007-b108-f3ec64cc8ab7"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("a3eca4f8-4e5d-48fb-9813-7f6a943950c7"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("aa4d6373-3fb4-4f48-b22c-958ac6d9e2fe"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("abac62f5-bc79-4292-a6af-98ea017c202c"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("b3be6085-abf3-47b8-a779-6b3dc7715104"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("b488bfdc-1cfc-43db-b21b-2b58db2293a3"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("b685fb3a-5350-450a-bdba-b94dabb76e9e"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("b7f6ecf4-b1fb-42c3-a818-8b152b96aab4"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("bef35816-9774-4e2c-829d-08412d305bdf"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("d2307913-6d46-4be2-91fc-3951843da8b7"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("d2900632-94ec-4c75-851f-3c77e125b0a3"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("d6e3977b-87d8-49c8-b6b5-67f2357a2328"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("de8d7db2-1afa-4729-a529-5c36ef8d09d5"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("e1dbb834-c08b-488f-804c-bc5f59fe0ede"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("e5031a4e-cc45-4429-b9a4-1ed358ba3398"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("e6293cb6-b37d-4e56-9e42-b3a112f41499"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("ec96b70d-088e-495b-bf7e-a0dc449a2a86"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("f61878f3-2e99-4e80-8e6e-619775dbf9a9"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("f8de1c34-0797-4396-9b00-3be2d28bffad"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("fd30a84a-1874-49e5-b1be-7bfe1f722d9c"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("fe76252d-c198-4ddf-8292-d6f72416e548"));

            migrationBuilder.DropColumn(
                name: "WorkoutEntityId",
                table: "Activities");

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "CreatedAt", "Description", "ImageURL", "ModifiedAt", "Name", "NormalizedName", "VideoURL" },
                values: new object[,]
                {
                    { new Guid("2239df6e-9146-410d-927a-a2368ad82188"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(410), "exercises.bench-press.description", "https://caliberstrong.com/wp-content/uploads/2020/04/how-to-bench-press.jpg", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(410), "exercises.bench-press.name", "exercises.bench-press.normalized-name", null },
                    { new Guid("42f77d86-1cfe-4f56-a9e7-744874c43dd4"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(420), "exercises.lunge.description", "https://hortonbarbell.com/wp-content/uploads/2022/05/Dumbbell-Lunge.png", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(420), "exercises.lunge.name", "exercises.lunge.normalized-name", null },
                    { new Guid("494b12a8-3cdf-4db0-98bf-85e0cca8d3a4"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(410), "exercises.dip.description", "https://www.muscleandfitness.com/wp-content/uploads/2018/07/1109-dip.jpg?w=800&quality=86&strip=all", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(410), "exercises.dip.name", "exercises.dip.normalized-name", null },
                    { new Guid("4ee2eeef-0cda-485b-9723-c45b90296130"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(410), "exercises.pull-up.description", "https://hips.hearstapps.com/hmg-prod/images/mh0418-fit-pul-01-1558551798.jpg?crop=0.749xw:1.00xh;0.251xw,0&resize=1200:*", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(410), "exercises.pull-up.name", "exercises.pull-up.normalized-name", null },
                    { new Guid("813629e9-2ae8-4617-822e-5925bb098ccc"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(400), "exercises.dead-lift.description", "https://miro.medium.com/v2/resize:fit:1024/0*UkQCo1eLsXjoXn4v.jpg", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(400), "exercises.dead-lift.name", "exercises.dead-lift.normalized-name", null },
                    { new Guid("a11e442c-8d45-4002-9120-20db156fe687"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(420), "exercises.push-up.description", "https://www.fitnesseducation.edu.au/wp-content/uploads/2017/03/Pushups.jpg", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(420), "exercises.push-up.name", "exercises.push-up.normalized-name", null },
                    { new Guid("acc3fe8d-c7c9-4bc4-88b9-6736ca4b26a0"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(390), "exercises.squat.description", "https://legionathletics.com/wp-content/uploads/2019/05/arnold-squat.jpg", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(390), "exercises.squat.name", "exercises.squat.normalized-name", null },
                    { new Guid("b9d4beb6-a758-4d8c-9448-dd8cd76d719b"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(420), "exercises.curl.description", "https://hortonbarbell.com/wp-content/uploads/2023/01/How-To-Do-Tempo-Bicep-Curls.png", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(420), "exercises.curl.name", "exercises.curl.normalized-name", null },
                    { new Guid("e56414dc-ef26-4f41-a5be-0be894a262d4"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(400), "exercises.shoulder-press.description", "https://legionathletics.com/wp-content/uploads/2023/10/Dumbbell-Shoulder-Press-before-after.png", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(400), "exercises.shoulder-press.name", "exercises.shoulder-press.normalized-name", null }
                });

            migrationBuilder.InsertData(
                table: "Gyms",
                columns: new[] { "Id", "CreatedAt", "Latitude", "Longitude", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("111efe1a-6e8f-4b03-8a1b-1d8d05f6ec5f"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(820), 49.178859520009325, 16.59588166754828, new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(820), "Posilovna Velký Průvan" },
                    { new Guid("1b2a5d3b-a9a3-4947-addb-717a89ad29de"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(850), 49.190492694739753, 16.617386769256324, new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(850), "Form Factory Fitness Club Vlněna" },
                    { new Guid("21258a74-9d4d-4763-98e6-ad4c0e23739a"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(850), 49.212976899683049, 16.609015907373617, new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(850), "Fitness Boby" },
                    { new Guid("36963396-cc12-407f-91a1-212f22ba6775"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(830), 49.179083949535297, 16.596503940037902, new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(830), "Posilovna Malý Průvan" },
                    { new Guid("851c1882-85b8-4259-bf1c-545db2487509"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(840), 49.181262112264804, 16.60282245697524, new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(840), "NewPark Gym" },
                    { new Guid("b1f7c1c6-551f-4169-831b-92eb13da57d1"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(840), 49.180330210607991, 16.606384581697789, new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(840), "Energy Fitness Club" },
                    { new Guid("d2977ca2-4d25-4b50-919e-24d7cd716f5d"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(850), 49.218555432690493, 16.624250854578833, new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(850), "Blackfield Gym" },
                    { new Guid("d92482c1-8d06-4c28-addf-c6485509290f"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(830), 49.177089060496634, 16.606190093594201, new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(830), "AZ Fitness" },
                    { new Guid("e8d0ab41-04e5-49e1-8595-2128b155efeb"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(840), 49.215051402565855, 16.609402145470618, new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(840), "Hulk Gym" },
                    { new Guid("fcc11923-4c76-4461-8184-0ab58c642568"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(860), 49.208489226784764, 16.605422062883459, new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(860), "Form Factory Fitness Club Lužánky" }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "CreatedAt", "Key", "Locale", "ModifiedAt", "Value" },
                values: new object[,]
                {
                    { new Guid("01d9a2f7-c424-4739-88eb-57e61cae7d7c"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(560), "exercises.dead-lift.name", "cs", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(560), "Mrtvý tah" },
                    { new Guid("0300b9f3-ea58-4a0d-a8f0-7a769919a5ed"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(580), "exercises.dead-lift.description", "cs", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(580), "Mrtvý tah je cvik na posílení zad, hýždí a hamstringů, provedený ohnutím v pase a zdvihem váhy z podlahy s udržením rovné páteře." },
                    { new Guid("050a56c9-44a1-4072-a53d-eeaa803c68ce"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(620), "exercises.pull-up.description", "en", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(620), "An effective upper body exercise primarily targeting the back and biceps. Hang from a bar with palms facing away, pull your body up until your chin passes the bar, and lower back down." },
                    { new Guid("09a3ab29-75d0-4930-89f7-13e7c1f1e1ec"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(610), "exercises.pull-up.normalized-name", "en", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(610), "PULLUP" },
                    { new Guid("09dc677a-6f66-4a7a-8604-54a5c88bfcc3"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(730), "exercises.curl.description", "en", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(730), "An isolation exercise for the biceps. Stand with weights in hand, palms facing forward, and curl the weights towards your shoulders by bending at the elbows." },
                    { new Guid("19186a5c-6dcc-4df6-b31c-220fa1bc2564"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(540), "exercises.squat.normalized-name", "cs", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(540), "DREP" },
                    { new Guid("1dc335f7-5a0f-4b2f-a51d-983c471fe76f"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(540), "exercises.squat.normalized-name", "en", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(540), "SQUAT" },
                    { new Guid("1e76e74b-9696-4fdb-ac7e-403e64c1688a"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(680), "exercises.lunge.description", "en", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(680), "A lower body exercise targeting the legs and glutes. Take a step forward with one leg, lower your body until both knees form right angles, then return to the starting position." },
                    { new Guid("1fb4a00a-2ce0-4f23-a162-4382d370ddfb"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(650), "exercises.bench-press.name", "en", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(650), "Bench press" },
                    { new Guid("27ca5a63-2eab-4954-86c3-f4f8d5fac004"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(590), "exercises.shoulder-press.normalized-name", "en", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(590), "SHOULDERPRESS" },
                    { new Guid("28f18054-609d-40b3-af46-3b9da83f21f3"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(600), "exercises.shoulder-press.description", "cs", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(600), "Tlaky na ramena zaměřují se na posílení ramenních svalů a vykonávají se tlačením činek nad hlavu." },
                    { new Guid("2918047d-b1ab-4052-9e76-b8b26c5180ee"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(550), "exercises.dead-lift.name", "en", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(550), "Dead-lift" },
                    { new Guid("2bc30fd7-22dc-4bbe-8a8d-b496326a1951"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(680), "exercises.lunge.normalized-name", "cs", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(680), "VYPAD" },
                    { new Guid("30c46a63-399c-445f-a048-057a59da9a51"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(730), "exercises.curl.description", "cs", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(730), "Bicepsový zdvih cílí na posílení bicepsů a vykonává se zdvihem váhy směrem k ramenům při ohnutí v loktech." },
                    { new Guid("30e276b3-23bb-4829-89b9-1b90519df263"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(720), "exercises.curl.normalized-name", "cs", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(720), "BICEPSOVYZDVIH" },
                    { new Guid("3e7c55a0-1137-48b7-b0c9-7e3a0f1dad0a"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(670), "exercises.lunge.name", "en", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(670), "Lunge" },
                    { new Guid("49ea0ee3-30ea-4f26-8e96-a07bfcbf3c2f"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(570), "exercises.dead-lift.normalized-name", "cs", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(570), "MRTVYTAH" },
                    { new Guid("4c062ff2-5729-4be9-ac86-398c3bce09b1"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(660), "exercises.bench-press.description", "en", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(660), "A classic chest exercise focusing on the pectoral muscles. Lie on a bench, lower and lift a barbell or dumbbells to and from your chest." },
                    { new Guid("4d7d70cc-6847-436c-9141-d7725af2dd7d"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(660), "exercises.bench-press.normalized-name", "cs", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(660), "BENCHPRESS" },
                    { new Guid("4edd962f-f6c2-4625-a172-5f81f8668ddb"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(690), "exercises.push-up.name", "en", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(690), "Push up" },
                    { new Guid("4f234712-5172-41a7-a2fd-56bbceb72b18"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(550), "exercises.squat.description", "cs", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(550), "Dřep posiluje dolní část těla, především nohy, hamstrings a hýždě. Vykonává se stáním s váhou na ramenou a poklesem do pravého úhlu v kolenou." },
                    { new Guid("632f3e5a-f037-43fa-8639-4d83048aec88"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(640), "exercises.dip.description", "en", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(640), "An isolation exercise for the triceps and chest. Support yourself on parallel bars, lower your body by bending your elbows, and push back up." },
                    { new Guid("66584d17-300a-4dac-9015-e39f5360c1f4"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(530), "exercises.squat.name", "en", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(530), "Squat" },
                    { new Guid("670e641a-986c-4a4a-a801-8dbfa3d2aabd"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(710), "exercises.push-up.description", "cs", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(710), "Kliky jsou cvik na posílení horní části těla, zvláště hrudníku, tricepsů a deltových svalů. Provádí se opakováním zvedání a spouštění těla, kdy se opíráte o ruce na zemi a tlačíte se nahoru a dolů." },
                    { new Guid("78b56ab6-8490-4940-8b4d-e2e16d505c40"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(640), "exercises.dip.normalized-name", "cs", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(640), "KLIKNABRADLECH" },
                    { new Guid("78e3701b-5513-4895-9db7-da92b97f481f"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(590), "exercises.shoulder-press.normalized-name", "cs", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(590), "TLAKNARAMENA" },
                    { new Guid("7a07d80e-9823-4b68-8522-24b6d2cf8596"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(610), "exercises.pull-up.name", "cs", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(610), "Shyb" },
                    { new Guid("7adefe10-d4ae-4603-9870-f82152156445"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(610), "exercises.pull-up.normalized-name", "cs", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(610), "SHYB" },
                    { new Guid("7e8f13a3-7bc5-47c3-8035-127f469d3fb3"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(630), "exercises.dip.name", "en", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(630), "Dip" },
                    { new Guid("8342aaea-6262-4c56-bf27-5e75aed0f6e7"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(630), "exercises.dip.normalized-name", "en", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(630), "DIP" },
                    { new Guid("8907921d-3237-4370-9336-ac22e3207c5f"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(720), "exercises.curl.name", "cs", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(720), "Bicepsový zdvih" },
                    { new Guid("8cbdf6a7-5e8b-43bf-a2fa-ea9a1edba144"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(570), "exercises.dead-lift.description", "en", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(570), "A compound exercise for overall strength, focusing on the back, glutes, hamstrings, and lower back. Start with the weight on the ground, hinge at the hips, lift the weight by straightening your hips and knees." },
                    { new Guid("90e75daf-787b-49d5-8337-6f21e117660f"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(620), "exercises.pull-up.description", "cs", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(620), "Shyb je izolovaný cvik pro tricepsy, provádí se zvedáním váhy pomocí prodloužení paže." },
                    { new Guid("92e5d0b2-832d-4ee5-bf0b-8019890e6e06"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(580), "exercises.shoulder-press.name", "cs", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(580), "Tlak na ramena" },
                    { new Guid("99beba73-88b6-47cb-91ab-ec220308adb3"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(570), "exercises.dead-lift.normalized-name", "en", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(570), "DEADLIFT" },
                    { new Guid("9ccc66af-b0b4-4891-823c-1ebf7fa356fc"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(710), "exercises.push-up.description", "en", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(710), "A versatile exercise engaging the chest, shoulders, and triceps. Start in a plank position, lower your body to the ground, and push back up." },
                    { new Guid("a0016462-8240-4dbe-bf22-65e6fc7c47ff"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(700), "exercises.push-up.name", "cs", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(700), "Klik" },
                    { new Guid("badd68f9-9cf5-45af-b27b-a629e862fb43"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(540), "exercises.squat.name", "cs", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(540), "Dřep" },
                    { new Guid("be56bbc7-2228-40dc-a158-e635fffdda82"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(650), "exercises.bench-press.name", "cs", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(650), "Bench press" },
                    { new Guid("c603e24a-9e7d-40ab-8b56-753fcc8a78c7"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(630), "exercises.dip.name", "cs", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(630), "Klik na bradlech" },
                    { new Guid("c79e4073-0c22-49af-bd3c-3aca311114dc"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(690), "exercises.lunge.description", "cs", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(690), "Výpad je cvik na dolní část těla, střídavým krokem dopředu a poklesem kolena k zemi." },
                    { new Guid("cce34cb2-52fb-408e-b95f-e3017a7938fc"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(600), "exercises.shoulder-press.description", "en", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(600), "An upper body exercise concentrating on shoulder muscles. Whether sitting or standing, press weights or other resistance overhead, emphasizing controlled movements." },
                    { new Guid("d31dfa2e-edd7-429a-8f27-45722fed1cca"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(660), "exercises.bench-press.normalized-name", "en", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(660), "BENCHPRESS" },
                    { new Guid("d3ef5b53-a133-4a2b-a117-b59fae2f4a8b"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(680), "exercises.lunge.normalized-name", "en", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(680), "LUNGE" },
                    { new Guid("e11cb572-65d3-4c87-ac51-a62b32cd16bb"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(550), "exercises.squat.description", "en", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(550), "A fundamental lower body exercise targeting the legs, hamstrings, and glutes. Stand with feet shoulder-width apart, lower your body by bending your knees, and return to the starting position." },
                    { new Guid("e6719f8d-ba13-4433-ace7-b660f53c7481"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(710), "exercises.curl.name", "en", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(710), "Bicep curl" },
                    { new Guid("ea130353-f8fa-4aa7-b434-ce13111c4642"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(670), "exercises.bench-press.description", "cs", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(670), "Bench-press je klasický cvik pro posílení hrudníku, tricepse a delt. " },
                    { new Guid("ed9449da-626a-4710-bc68-8a5e94902ff8"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(640), "exercises.dip.description", "cs", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(640), "Kliky na bradlech posilují horní část těla, zejména hrudník, tricepsy a deltové svaly." },
                    { new Guid("f0fb793f-043e-4a98-b8c0-979df4fd2a1d"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(670), "exercises.lunge.name", "cs", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(670), "Výpad" },
                    { new Guid("f93acc8c-3477-4045-bc2a-152f2ac10403"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(700), "exercises.push-up.normalized-name", "cs", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(700), "KLIK" },
                    { new Guid("fa0928f6-bc29-42af-a6ea-f48061f5c3a8"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(720), "exercises.curl.normalized-name", "en", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(720), "BICEPCURL" },
                    { new Guid("fa692408-d6f3-4560-a9dd-b17c30d975b0"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(600), "exercises.pull-up.name", "en", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(600), "Pull up" },
                    { new Guid("fb87cd90-294f-4460-892a-23749429d02f"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(580), "exercises.shoulder-press.name", "en", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(580), "Shoulder press" },
                    { new Guid("fd94178d-365a-4d37-9b1c-c42525438fdd"), new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(700), "exercises.push-up.normalized-name", "en", new DateTime(2024, 1, 12, 17, 6, 19, 81, DateTimeKind.Utc).AddTicks(700), "PUSHUP" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_WorkoutId",
                table: "Activities",
                column: "WorkoutId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Workouts_WorkoutId",
                table: "Activities",
                column: "WorkoutId",
                principalTable: "Workouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Workouts_WorkoutId",
                table: "Activities");

            migrationBuilder.DropIndex(
                name: "IX_Activities_WorkoutId",
                table: "Activities");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2239df6e-9146-410d-927a-a2368ad82188"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("42f77d86-1cfe-4f56-a9e7-744874c43dd4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("494b12a8-3cdf-4db0-98bf-85e0cca8d3a4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4ee2eeef-0cda-485b-9723-c45b90296130"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("813629e9-2ae8-4617-822e-5925bb098ccc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a11e442c-8d45-4002-9120-20db156fe687"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("acc3fe8d-c7c9-4bc4-88b9-6736ca4b26a0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b9d4beb6-a758-4d8c-9448-dd8cd76d719b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e56414dc-ef26-4f41-a5be-0be894a262d4"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("111efe1a-6e8f-4b03-8a1b-1d8d05f6ec5f"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("1b2a5d3b-a9a3-4947-addb-717a89ad29de"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("21258a74-9d4d-4763-98e6-ad4c0e23739a"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("36963396-cc12-407f-91a1-212f22ba6775"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("851c1882-85b8-4259-bf1c-545db2487509"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("b1f7c1c6-551f-4169-831b-92eb13da57d1"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("d2977ca2-4d25-4b50-919e-24d7cd716f5d"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("d92482c1-8d06-4c28-addf-c6485509290f"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("e8d0ab41-04e5-49e1-8595-2128b155efeb"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("fcc11923-4c76-4461-8184-0ab58c642568"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("01d9a2f7-c424-4739-88eb-57e61cae7d7c"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("0300b9f3-ea58-4a0d-a8f0-7a769919a5ed"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("050a56c9-44a1-4072-a53d-eeaa803c68ce"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("09a3ab29-75d0-4930-89f7-13e7c1f1e1ec"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("09dc677a-6f66-4a7a-8604-54a5c88bfcc3"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("19186a5c-6dcc-4df6-b31c-220fa1bc2564"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("1dc335f7-5a0f-4b2f-a51d-983c471fe76f"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("1e76e74b-9696-4fdb-ac7e-403e64c1688a"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("1fb4a00a-2ce0-4f23-a162-4382d370ddfb"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("27ca5a63-2eab-4954-86c3-f4f8d5fac004"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("28f18054-609d-40b3-af46-3b9da83f21f3"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("2918047d-b1ab-4052-9e76-b8b26c5180ee"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("2bc30fd7-22dc-4bbe-8a8d-b496326a1951"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("30c46a63-399c-445f-a048-057a59da9a51"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("30e276b3-23bb-4829-89b9-1b90519df263"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("3e7c55a0-1137-48b7-b0c9-7e3a0f1dad0a"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("49ea0ee3-30ea-4f26-8e96-a07bfcbf3c2f"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("4c062ff2-5729-4be9-ac86-398c3bce09b1"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("4d7d70cc-6847-436c-9141-d7725af2dd7d"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("4edd962f-f6c2-4625-a172-5f81f8668ddb"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("4f234712-5172-41a7-a2fd-56bbceb72b18"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("632f3e5a-f037-43fa-8639-4d83048aec88"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("66584d17-300a-4dac-9015-e39f5360c1f4"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("670e641a-986c-4a4a-a801-8dbfa3d2aabd"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("78b56ab6-8490-4940-8b4d-e2e16d505c40"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("78e3701b-5513-4895-9db7-da92b97f481f"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("7a07d80e-9823-4b68-8522-24b6d2cf8596"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("7adefe10-d4ae-4603-9870-f82152156445"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("7e8f13a3-7bc5-47c3-8035-127f469d3fb3"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("8342aaea-6262-4c56-bf27-5e75aed0f6e7"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("8907921d-3237-4370-9336-ac22e3207c5f"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("8cbdf6a7-5e8b-43bf-a2fa-ea9a1edba144"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("90e75daf-787b-49d5-8337-6f21e117660f"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("92e5d0b2-832d-4ee5-bf0b-8019890e6e06"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("99beba73-88b6-47cb-91ab-ec220308adb3"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("9ccc66af-b0b4-4891-823c-1ebf7fa356fc"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("a0016462-8240-4dbe-bf22-65e6fc7c47ff"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("badd68f9-9cf5-45af-b27b-a629e862fb43"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("be56bbc7-2228-40dc-a158-e635fffdda82"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("c603e24a-9e7d-40ab-8b56-753fcc8a78c7"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("c79e4073-0c22-49af-bd3c-3aca311114dc"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("cce34cb2-52fb-408e-b95f-e3017a7938fc"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("d31dfa2e-edd7-429a-8f27-45722fed1cca"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("d3ef5b53-a133-4a2b-a117-b59fae2f4a8b"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("e11cb572-65d3-4c87-ac51-a62b32cd16bb"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("e6719f8d-ba13-4433-ace7-b660f53c7481"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("ea130353-f8fa-4aa7-b434-ce13111c4642"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("ed9449da-626a-4710-bc68-8a5e94902ff8"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("f0fb793f-043e-4a98-b8c0-979df4fd2a1d"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("f93acc8c-3477-4045-bc2a-152f2ac10403"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("fa0928f6-bc29-42af-a6ea-f48061f5c3a8"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("fa692408-d6f3-4560-a9dd-b17c30d975b0"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("fb87cd90-294f-4460-892a-23749429d02f"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("fd94178d-365a-4d37-9b1c-c42525438fdd"));

            migrationBuilder.AddColumn<Guid>(
                name: "WorkoutEntityId",
                table: "Activities",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "CreatedAt", "Description", "ImageURL", "ModifiedAt", "Name", "NormalizedName", "VideoURL" },
                values: new object[,]
                {
                    { new Guid("0a544b9f-cb83-4dd5-a6e6-3d7dafd1c3f9"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6320), "exercises.squat.description", "https://legionathletics.com/wp-content/uploads/2019/05/arnold-squat.jpg", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6320), "exercises.squat.name", "exercises.squat.normalized-name", null },
                    { new Guid("3402086c-4353-4e4d-b1c0-8a9da1888d96"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6360), "exercises.curl.description", "https://hortonbarbell.com/wp-content/uploads/2023/01/How-To-Do-Tempo-Bicep-Curls.png", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6360), "exercises.curl.name", "exercises.curl.normalized-name", null },
                    { new Guid("47bad8bd-6116-4824-b20a-970555533098"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6340), "exercises.pull-up.description", "https://hips.hearstapps.com/hmg-prod/images/mh0418-fit-pul-01-1558551798.jpg?crop=0.749xw:1.00xh;0.251xw,0&resize=1200:*", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6340), "exercises.pull-up.name", "exercises.pull-up.normalized-name", null },
                    { new Guid("6eeb8a04-3209-4e17-bc4e-52349e1b9678"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6350), "exercises.push-up.description", "https://www.fitnesseducation.edu.au/wp-content/uploads/2017/03/Pushups.jpg", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6350), "exercises.push-up.name", "exercises.push-up.normalized-name", null },
                    { new Guid("85d567ed-2ecf-4ccd-acab-0110c838bbc9"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6340), "exercises.dip.description", "https://www.muscleandfitness.com/wp-content/uploads/2018/07/1109-dip.jpg?w=800&quality=86&strip=all", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6340), "exercises.dip.name", "exercises.dip.normalized-name", null },
                    { new Guid("cb68be57-94ce-4149-8d0e-7db6c7706b5a"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6330), "exercises.dead-lift.description", "https://miro.medium.com/v2/resize:fit:1024/0*UkQCo1eLsXjoXn4v.jpg", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6330), "exercises.dead-lift.name", "exercises.dead-lift.normalized-name", null },
                    { new Guid("ea176a07-39e4-439c-a3be-08a1ffee51c8"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6350), "exercises.bench-press.description", "https://caliberstrong.com/wp-content/uploads/2020/04/how-to-bench-press.jpg", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6350), "exercises.bench-press.name", "exercises.bench-press.normalized-name", null },
                    { new Guid("f478d873-d2e7-4deb-8f15-6d5bfdde550b"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6330), "exercises.shoulder-press.description", "https://legionathletics.com/wp-content/uploads/2023/10/Dumbbell-Shoulder-Press-before-after.png", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6330), "exercises.shoulder-press.name", "exercises.shoulder-press.normalized-name", null },
                    { new Guid("fe7e5db1-ae3c-4087-bd0d-4da92193ea93"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6350), "exercises.lunge.description", "https://hortonbarbell.com/wp-content/uploads/2022/05/Dumbbell-Lunge.png", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6350), "exercises.lunge.name", "exercises.lunge.normalized-name", null }
                });

            migrationBuilder.InsertData(
                table: "Gyms",
                columns: new[] { "Id", "CreatedAt", "Latitude", "Longitude", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("02a0d371-de5a-4f6f-80e6-8c8a04e8cafb"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6750), 49.215051402565855, 16.609402145470618, new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6750), "Hulk Gym" },
                    { new Guid("06ede792-e5b9-4575-9c25-37d6095e6871"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6750), 49.218555432690493, 16.624250854578833, new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6750), "Blackfield Gym" },
                    { new Guid("10e4b565-bc4e-49ef-bdb4-a528d7d65f39"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6740), 49.180330210607991, 16.606384581697789, new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6740), "Energy Fitness Club" },
                    { new Guid("2064c892-395c-4806-a005-5a3cbe2607c2"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6760), 49.208489226784764, 16.605422062883459, new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6760), "Form Factory Fitness Club Lužánky" },
                    { new Guid("3e9fefef-6515-44c7-b2e4-e12d7df7ac5f"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6750), 49.212976899683049, 16.609015907373617, new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6750), "Fitness Boby" },
                    { new Guid("40fc84f3-a907-44fd-8a3f-b00829aff78d"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6740), 49.177089060496634, 16.606190093594201, new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6740), "AZ Fitness" },
                    { new Guid("42994c66-5a02-45b7-8545-e3323db1120c"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6730), 49.178859520009325, 16.59588166754828, new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6730), "Posilovna Velký Průvan" },
                    { new Guid("a80750cf-e4b1-4838-9a8b-3376b7cde476"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6760), 49.190492694739753, 16.617386769256324, new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6760), "Form Factory Fitness Club Vlněna" },
                    { new Guid("d69c2bbf-052d-4088-9729-f7ea854e0d47"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6740), 49.181262112264804, 16.60282245697524, new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6740), "NewPark Gym" },
                    { new Guid("e64f70fc-fffe-42ea-8ae1-43cc5ce5c9a0"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6730), 49.179083949535297, 16.596503940037902, new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6730), "Posilovna Malý Průvan" }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "CreatedAt", "Key", "Locale", "ModifiedAt", "Value" },
                values: new object[,]
                {
                    { new Guid("00ca0392-333d-42a7-a545-4c6212e087ef"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6490), "exercises.dead-lift.name", "cs", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6490), "Mrtvý tah" },
                    { new Guid("0283691f-f64a-44f2-bedb-2c63b5a397ef"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6650), "exercises.curl.normalized-name", "cs", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6650), "BICEPSOVYZDVIH" },
                    { new Guid("05674422-29af-4c8d-b20c-26468fb934af"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6570), "exercises.bench-press.normalized-name", "en", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6570), "BENCHPRESS" },
                    { new Guid("09a168f6-cab3-4dd1-858f-ebc5c0cb7307"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6580), "exercises.lunge.name", "en", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6580), "Lunge" },
                    { new Guid("1253c3b7-c89b-46ab-9fd4-c4b5c74ed251"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6630), "exercises.push-up.normalized-name", "cs", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6630), "KLIK" },
                    { new Guid("16eeb543-fea1-4d58-98b9-424b44f72213"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6560), "exercises.dip.description", "en", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6560), "An isolation exercise for the triceps and chest. Support yourself on parallel bars, lower your body by bending your elbows, and push back up." },
                    { new Guid("17a20bbe-1ddd-4b9a-953f-cc791455169d"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6610), "exercises.lunge.normalized-name", "en", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6610), "LUNGE" },
                    { new Guid("1e131325-e252-4fcb-93f4-666730d508ef"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6480), "exercises.squat.description", "en", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6480), "A fundamental lower body exercise targeting the legs, hamstrings, and glutes. Stand with feet shoulder-width apart, lower your body by bending your knees, and return to the starting position." },
                    { new Guid("1f56a490-7552-47e0-824a-acd6fcf61234"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6650), "exercises.curl.normalized-name", "en", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6650), "BICEPCURL" },
                    { new Guid("284039c9-06df-4839-b7d9-b83e69f76542"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6620), "exercises.push-up.name", "cs", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6620), "Klik" },
                    { new Guid("2ea6cd3d-e8f4-4528-9099-201f2e5f34fe"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6640), "exercises.push-up.description", "cs", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6640), "Kliky jsou cvik na posílení horní části těla, zvláště hrudníku, tricepsů a deltových svalů. Provádí se opakováním zvedání a spouštění těla, kdy se opíráte o ruce na zemi a tlačíte se nahoru a dolů." },
                    { new Guid("30c045cb-c334-4376-abe8-e65f6d58c729"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6470), "exercises.squat.normalized-name", "en", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6470), "SQUAT" },
                    { new Guid("34b6ec59-5a9e-43f6-b3a9-038e089479c9"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6490), "exercises.dead-lift.normalized-name", "en", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6490), "DEADLIFT" },
                    { new Guid("437b14d0-8577-4a34-964c-d04204273c46"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6500), "exercises.dead-lift.normalized-name", "cs", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6500), "MRTVYTAH" },
                    { new Guid("4415e57c-4073-4f52-82be-7e8142753193"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6520), "exercises.shoulder-press.description", "en", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6520), "An upper body exercise concentrating on shoulder muscles. Whether sitting or standing, press weights or other resistance overhead, emphasizing controlled movements." },
                    { new Guid("47b71aa7-2419-4778-8c93-a9894805150e"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6630), "exercises.push-up.description", "en", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6630), "A versatile exercise engaging the chest, shoulders, and triceps. Start in a plank position, lower your body to the ground, and push back up." },
                    { new Guid("4ef6bc65-b7d6-444a-8995-5e99dd0d7f0d"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6470), "exercises.squat.name", "en", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6470), "Squat" },
                    { new Guid("5221f95f-6dd3-48f3-9a13-ff7650da4ad8"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6510), "exercises.shoulder-press.normalized-name", "en", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6510), "SHOULDERPRESS" },
                    { new Guid("541fd8cf-65e4-453d-93a5-9c54102ba8dd"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6620), "exercises.lunge.description", "cs", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6620), "Výpad je cvik na dolní část těla, střídavým krokem dopředu a poklesem kolena k zemi." },
                    { new Guid("55189d16-106d-4389-ba7e-5c3e430e4d14"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6560), "exercises.bench-press.name", "en", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6560), "Bench press" },
                    { new Guid("57d7b225-8944-4867-a5dc-74be46bbbe17"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6530), "exercises.pull-up.name", "cs", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6530), "Shyb" },
                    { new Guid("58e24599-6323-4590-8b4e-e9121f9f41b9"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6470), "exercises.squat.name", "cs", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6470), "Dřep" },
                    { new Guid("5dca569b-666b-4e05-b1ba-64b2e7ea2e20"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6560), "exercises.dip.description", "cs", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6560), "Kliky na bradlech posilují horní část těla, zejména hrudník, tricepsy a deltové svaly." },
                    { new Guid("5ef99cf2-e0d9-4967-8485-8a725d7a21f6"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6510), "exercises.shoulder-press.name", "en", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6510), "Shoulder press" },
                    { new Guid("60234e5a-3b4f-49df-b42b-8728f0cfe510"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6480), "exercises.squat.normalized-name", "cs", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6480), "DREP" },
                    { new Guid("62cf4746-16a7-4a00-9ffd-3cb473639b06"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6500), "exercises.dead-lift.description", "cs", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6500), "Mrtvý tah je cvik na posílení zad, hýždí a hamstringů, provedený ohnutím v pase a zdvihem váhy z podlahy s udržením rovné páteře." },
                    { new Guid("65f525eb-bb17-4f57-ae5f-547997207968"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6610), "exercises.lunge.normalized-name", "cs", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6610), "VYPAD" },
                    { new Guid("7ae636ba-4c52-4305-b5c9-dfb08aa166ee"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6540), "exercises.pull-up.normalized-name", "cs", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6540), "SHYB" },
                    { new Guid("8bff3351-c3e9-4974-b72b-ad3224d69a54"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6550), "exercises.dip.name", "cs", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6550), "Klik na bradlech" },
                    { new Guid("925de2bd-1da0-4d49-b3da-19243d38579c"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6640), "exercises.curl.name", "en", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6640), "Bicep curl" },
                    { new Guid("94365bd2-9438-4da4-bc93-55932180e023"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6550), "exercises.dip.normalized-name", "en", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6550), "DIP" },
                    { new Guid("9d20c4b6-28f6-4bb1-955d-aa402710a289"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6540), "exercises.pull-up.description", "cs", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6540), "Shyb je izolovaný cvik pro tricepsy, provádí se zvedáním váhy pomocí prodloužení paže." },
                    { new Guid("9d8e69e7-6db6-4c49-9ca1-a3439c710e3d"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6610), "exercises.lunge.description", "en", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6610), "A lower body exercise targeting the legs and glutes. Take a step forward with one leg, lower your body until both knees form right angles, then return to the starting position." },
                    { new Guid("a19baf8e-bd04-4007-b108-f3ec64cc8ab7"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6520), "exercises.shoulder-press.normalized-name", "cs", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6520), "TLAKNARAMENA" },
                    { new Guid("a3eca4f8-4e5d-48fb-9813-7f6a943950c7"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6520), "exercises.shoulder-press.description", "cs", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6520), "Tlaky na ramena zaměřují se na posílení ramenních svalů a vykonávají se tlačením činek nad hlavu." },
                    { new Guid("aa4d6373-3fb4-4f48-b22c-958ac6d9e2fe"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6580), "exercises.bench-press.description", "en", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6580), "A classic chest exercise focusing on the pectoral muscles. Lie on a bench, lower and lift a barbell or dumbbells to and from your chest." },
                    { new Guid("abac62f5-bc79-4292-a6af-98ea017c202c"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6580), "exercises.bench-press.description", "cs", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6580), "Bench-press je klasický cvik pro posílení hrudníku, tricepse a delt. " },
                    { new Guid("b3be6085-abf3-47b8-a779-6b3dc7715104"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6540), "exercises.pull-up.description", "en", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6540), "An effective upper body exercise primarily targeting the back and biceps. Hang from a bar with palms facing away, pull your body up until your chin passes the bar, and lower back down." },
                    { new Guid("b488bfdc-1cfc-43db-b21b-2b58db2293a3"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6620), "exercises.push-up.name", "en", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6620), "Push up" },
                    { new Guid("b685fb3a-5350-450a-bdba-b94dabb76e9e"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6570), "exercises.bench-press.name", "cs", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6570), "Bench press" },
                    { new Guid("b7f6ecf4-b1fb-42c3-a818-8b152b96aab4"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6500), "exercises.dead-lift.description", "en", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6500), "A compound exercise for overall strength, focusing on the back, glutes, hamstrings, and lower back. Start with the weight on the ground, hinge at the hips, lift the weight by straightening your hips and knees." },
                    { new Guid("bef35816-9774-4e2c-829d-08412d305bdf"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6530), "exercises.pull-up.normalized-name", "en", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6530), "PULLUP" },
                    { new Guid("d2307913-6d46-4be2-91fc-3951843da8b7"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6590), "exercises.lunge.name", "cs", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6590), "Výpad" },
                    { new Guid("d2900632-94ec-4c75-851f-3c77e125b0a3"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6660), "exercises.curl.description", "cs", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6660), "Bicepsový zdvih cílí na posílení bicepsů a vykonává se zdvihem váhy směrem k ramenům při ohnutí v loktech." },
                    { new Guid("d6e3977b-87d8-49c8-b6b5-67f2357a2328"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6490), "exercises.dead-lift.name", "en", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6490), "Dead-lift" },
                    { new Guid("de8d7db2-1afa-4729-a529-5c36ef8d09d5"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6540), "exercises.dip.name", "en", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6550), "Dip" },
                    { new Guid("e1dbb834-c08b-488f-804c-bc5f59fe0ede"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6480), "exercises.squat.description", "cs", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6480), "Dřep posiluje dolní část těla, především nohy, hamstrings a hýždě. Vykonává se stáním s váhou na ramenou a poklesem do pravého úhlu v kolenou." },
                    { new Guid("e5031a4e-cc45-4429-b9a4-1ed358ba3398"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6630), "exercises.push-up.normalized-name", "en", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6630), "PUSHUP" },
                    { new Guid("e6293cb6-b37d-4e56-9e42-b3a112f41499"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6570), "exercises.bench-press.normalized-name", "cs", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6570), "BENCHPRESS" },
                    { new Guid("ec96b70d-088e-495b-bf7e-a0dc449a2a86"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6550), "exercises.dip.normalized-name", "cs", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6560), "KLIKNABRADLECH" },
                    { new Guid("f61878f3-2e99-4e80-8e6e-619775dbf9a9"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6510), "exercises.shoulder-press.name", "cs", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6510), "Tlak na ramena" },
                    { new Guid("f8de1c34-0797-4396-9b00-3be2d28bffad"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6650), "exercises.curl.description", "en", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6650), "An isolation exercise for the biceps. Stand with weights in hand, palms facing forward, and curl the weights towards your shoulders by bending at the elbows." },
                    { new Guid("fd30a84a-1874-49e5-b1be-7bfe1f722d9c"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6530), "exercises.pull-up.name", "en", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6530), "Pull up" },
                    { new Guid("fe76252d-c198-4ddf-8292-d6f72416e548"), new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6640), "exercises.curl.name", "cs", new DateTime(2024, 1, 11, 13, 1, 51, 411, DateTimeKind.Utc).AddTicks(6640), "Bicepsový zdvih" }
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
    }
}
