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
            migrationBuilder.DropTable(
                name: "Geolocations");

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

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "CreatedAt", "Description", "ImageURL", "ModifiedAt", "Name", "NormalizedName", "VideoURL" },
                values: new object[,]
                {
                    { new Guid("235db024-23e0-4383-8392-24051d34dab7"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(5880), "exercises.push-up.description", "https://www.fitnesseducation.edu.au/wp-content/uploads/2017/03/Pushups.jpg", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(5880), "exercises.push-up.name", "exercises.push-up.normalized-name", null },
                    { new Guid("2fb5dd3d-33f1-4df0-8d3d-76ebccf624fe"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(5870), "exercises.pull-up.description", "https://hips.hearstapps.com/hmg-prod/images/mh0418-fit-pul-01-1558551798.jpg?crop=0.749xw:1.00xh;0.251xw,0&resize=1200:*", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(5870), "exercises.pull-up.name", "exercises.pull-up.normalized-name", null },
                    { new Guid("5443f8f5-b9dc-4afa-9835-09f730a8219b"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(5880), "exercises.bench-press.description", "https://caliberstrong.com/wp-content/uploads/2020/04/how-to-bench-press.jpg", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(5880), "exercises.bench-press.name", "exercises.bench-press.normalized-name", null },
                    { new Guid("6f714844-8a78-40b7-9cc3-78291fcb0864"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(5890), "exercises.curl.description", "https://hortonbarbell.com/wp-content/uploads/2023/01/How-To-Do-Tempo-Bicep-Curls.png", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(5890), "exercises.curl.name", "exercises.curl.normalized-name", null },
                    { new Guid("8199994a-2c4a-417a-86e6-b2143c38e4d6"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(5870), "exercises.dip.description", "https://www.muscleandfitness.com/wp-content/uploads/2018/07/1109-dip.jpg?w=800&quality=86&strip=all", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(5870), "exercises.dip.name", "exercises.dip.normalized-name", null },
                    { new Guid("95640e86-3b1f-475f-b6a4-04aa9aa95fa6"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(5860), "exercises.squat.description", "https://legionathletics.com/wp-content/uploads/2019/05/arnold-squat.jpg", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(5860), "exercises.squat.name", "exercises.squat.normalized-name", null },
                    { new Guid("fa8378b2-66c4-4ea8-a14a-5486421727d5"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(5860), "exercises.dead-lift.description", "https://miro.medium.com/v2/resize:fit:1024/0*UkQCo1eLsXjoXn4v.jpg", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(5860), "exercises.dead-lift.name", "exercises.dead-lift.normalized-name", null },
                    { new Guid("fb51932c-7457-4dc8-afef-0b8d613b09fd"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(5880), "exercises.lunge.description", "https://hortonbarbell.com/wp-content/uploads/2022/05/Dumbbell-Lunge.png", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(5880), "exercises.lunge.name", "exercises.lunge.normalized-name", null },
                    { new Guid("ff78d2e7-d3a5-49f6-a9ef-2476eb272343"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(5870), "exercises.shoulder-press.description", "https://legionathletics.com/wp-content/uploads/2023/10/Dumbbell-Shoulder-Press-before-after.png", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(5870), "exercises.shoulder-press.name", "exercises.shoulder-press.normalized-name", null }
                });

            migrationBuilder.InsertData(
                table: "Gyms",
                columns: new[] { "Id", "CreatedAt", "Latitude", "Longitude", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("16a5d582-4405-44a6-a439-0e2b45f81725"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6270), 49.218555432690493, 16.624250854578833, new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6270), "Blackfield Gym" },
                    { new Guid("29a68557-6522-402a-9758-9edf58ad02ec"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6280), 49.208489226784764, 16.605422062883459, new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6280), "Form Factory Fitness Club Lužánky" },
                    { new Guid("42fe9642-3cf5-41e1-91f7-4297df327e45"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6260), 49.180330210607991, 16.606384581697789, new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6260), "Energy Fitness Club" },
                    { new Guid("488b1d32-2b0f-4c75-88b5-aa7aa0b0787f"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6270), 49.190492694739753, 16.617386769256324, new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6270), "Form Factory Fitness Club Vlněna" },
                    { new Guid("4f425b9d-1539-4111-ad2c-eec94c75c581"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6240), 49.178859520009325, 16.59588166754828, new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6240), "Posilovna Velký Průvan" },
                    { new Guid("7e3c56c9-1efe-46f5-a62b-badc86c90853"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6260), 49.212976899683049, 16.609015907373617, new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6270), "Fitness Boby" },
                    { new Guid("cec5bd39-ccd0-4713-a5b0-ebfbaa9e8563"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6250), 49.181262112264804, 16.60282245697524, new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6260), "NewPark Gym" },
                    { new Guid("d7551e02-3de6-43c3-a1ae-378f885c10c2"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6250), 49.179083949535297, 16.596503940037902, new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6250), "Posilovna Malý Průvan" },
                    { new Guid("de3fea2e-aebd-4191-9637-1c70a4cf4382"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6250), 49.177089060496634, 16.606190093594201, new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6250), "AZ Fitness" },
                    { new Guid("efbd8fc8-9f68-4733-b21b-dd01271ed4d8"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6260), 49.215051402565855, 16.609402145470618, new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6260), "Hulk Gym" }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "CreatedAt", "Key", "Locale", "ModifiedAt", "Value" },
                values: new object[,]
                {
                    { new Guid("0070e103-da17-48c9-88ae-4ba94ace0650"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6120), "exercises.lunge.name", "cs", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6120), "Výpad" },
                    { new Guid("022cf0b1-a982-4275-af79-1f451d578c41"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6150), "exercises.push-up.normalized-name", "cs", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6150), "KLIK" },
                    { new Guid("0463c1c3-8f97-4c29-a878-c4d8b2227edf"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6010), "exercises.squat.normalized-name", "cs", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6010), "DREP" },
                    { new Guid("0e777278-f097-49d1-ac7f-18e9c0291a78"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6160), "exercises.curl.name", "cs", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6160), "Bicepsový zdvih" },
                    { new Guid("0ec263a6-834d-4cf1-b768-4b303df83e38"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6140), "exercises.push-up.name", "en", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6140), "Push up" },
                    { new Guid("0ee916e3-c745-47ca-9b8b-3f0008f78517"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6030), "exercises.dead-lift.normalized-name", "cs", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6030), "MRTVYTAH" },
                    { new Guid("14040039-e74f-4978-bf90-8a5fe5832b35"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6040), "exercises.shoulder-press.name", "en", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6040), "Shoulder press" },
                    { new Guid("17c4bf72-d9d3-4004-a32a-5accd6a589ba"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6090), "exercises.dip.normalized-name", "cs", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6090), "KLIKNABRADLECH" },
                    { new Guid("1e8f0d9e-4a6b-4370-8d7d-4474af5586b6"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6000), "exercises.squat.name", "cs", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6000), "Dřep" },
                    { new Guid("25abb841-fcf2-42fb-9b43-5d3aaf1640c6"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6010), "exercises.squat.description", "en", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6010), "A fundamental lower body exercise targeting the legs, hamstrings, and glutes. Stand with feet shoulder-width apart, lower your body by bending your knees, and return to the starting position." },
                    { new Guid("27736998-f81c-4a01-a5c4-33533d08d87b"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6060), "exercises.pull-up.normalized-name", "en", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6070), "PULLUP" },
                    { new Guid("2d5a0c6f-28e6-459d-ad36-3a92c671142e"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6040), "exercises.dead-lift.description", "cs", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6040), "Mrtvý tah je cvik na posílení zad, hýždí a hamstringů, provedený ohnutím v pase a zdvihem váhy z podlahy s udržením rovné páteře." },
                    { new Guid("30cf6252-e5e1-4c90-89f9-1cd5e553fabb"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6060), "exercises.pull-up.name", "en", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6060), "Pull up" },
                    { new Guid("3216a9d4-b033-4511-b981-7f9d83633dda"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6000), "exercises.squat.name", "en", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6000), "Squat" },
                    { new Guid("3223083b-3249-40a1-97cb-69ac47ea9712"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6050), "exercises.shoulder-press.normalized-name", "cs", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6050), "TLAKNARAMENA" },
                    { new Guid("3850c017-f071-4b66-a8d2-56ff36cf47be"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6020), "exercises.dead-lift.name", "cs", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6020), "Mrtvý tah" },
                    { new Guid("398e4659-c853-4cad-8470-007e3d2fd8c2"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6150), "exercises.push-up.description", "cs", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6150), "Kliky jsou cvik na posílení horní části těla, zvláště hrudníku, tricepsů a deltových svalů. Provádí se opakováním zvedání a spouštění těla, kdy se opíráte o ruce na zemi a tlačíte se nahoru a dolů." },
                    { new Guid("46435ef8-e444-4b34-83be-95890bc5c151"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6050), "exercises.shoulder-press.description", "en", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6050), "An upper body exercise concentrating on shoulder muscles. Whether sitting or standing, press weights or other resistance overhead, emphasizing controlled movements." },
                    { new Guid("4a50b1a0-df08-48a6-a43e-c492f8bd7fc7"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6010), "exercises.squat.normalized-name", "en", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6010), "SQUAT" },
                    { new Guid("4ba32383-9ef2-42b9-a5b4-d97a54c62c4d"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6090), "exercises.dip.description", "en", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6090), "An isolation exercise for the triceps and chest. Support yourself on parallel bars, lower your body by bending your elbows, and push back up." },
                    { new Guid("4fdeb35d-a3be-4e1d-8870-c99a7a3e47f2"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6170), "exercises.curl.description", "cs", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6170), "Bicepsový zdvih cílí na posílení bicepsů a vykonává se zdvihem váhy směrem k ramenům při ohnutí v loktech." },
                    { new Guid("527d0cbd-0749-4896-8c75-090860d75673"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6120), "exercises.lunge.normalized-name", "en", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6120), "LUNGE" },
                    { new Guid("52d6cb36-aba8-410f-962d-82831668d84d"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6140), "exercises.push-up.normalized-name", "en", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6140), "PUSHUP" },
                    { new Guid("54e097e8-4764-4605-9945-544697364cba"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6170), "exercises.curl.description", "en", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6170), "An isolation exercise for the biceps. Stand with weights in hand, palms facing forward, and curl the weights towards your shoulders by bending at the elbows." },
                    { new Guid("58b21240-7e65-474a-a768-87555314a288"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6070), "exercises.pull-up.description", "cs", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6070), "Shyb je izolovaný cvik pro tricepsy, provádí se zvedáním váhy pomocí prodloužení paže." },
                    { new Guid("594eb423-6e52-477f-8fff-d2810837a2af"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6080), "exercises.dip.name", "en", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6080), "Dip" },
                    { new Guid("6268d648-552b-4596-a2fc-4ed8c1636f32"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6050), "exercises.shoulder-press.normalized-name", "en", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6050), "SHOULDERPRESS" },
                    { new Guid("6a754431-7a82-4282-8b34-b02a7a1f7bad"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6130), "exercises.lunge.normalized-name", "cs", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6130), "VYPAD" },
                    { new Guid("74834118-a803-4374-9124-7118cc09f205"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6070), "exercises.pull-up.description", "en", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6070), "An effective upper body exercise primarily targeting the back and biceps. Hang from a bar with palms facing away, pull your body up until your chin passes the bar, and lower back down." },
                    { new Guid("7500d55e-1e52-4aaa-8fd4-cc40b55a8eb1"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6090), "exercises.dip.description", "cs", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6090), "Kliky na bradlech posilují horní část těla, zejména hrudník, tricepsy a deltové svaly." },
                    { new Guid("7c22d816-17e8-4bee-9abe-9ec45f32eb44"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6110), "exercises.bench-press.description", "cs", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6110), "Bench-press je klasický cvik pro posílení hrudníku, tricepse a delt. " },
                    { new Guid("7f03c884-ec07-4b21-bbed-dc0556934a86"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6140), "exercises.push-up.name", "cs", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6140), "Klik" },
                    { new Guid("847ab7dc-db1a-4730-8403-bf0726ea059a"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6080), "exercises.dip.name", "cs", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6080), "Klik na bradlech" },
                    { new Guid("978c35dc-0a18-4aa5-bc6f-2712d13be1e0"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6060), "exercises.pull-up.name", "cs", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6060), "Shyb" },
                    { new Guid("9a29eaf0-4ce7-45cb-8035-8bc3b885856f"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6040), "exercises.shoulder-press.name", "cs", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6040), "Tlak na ramena" },
                    { new Guid("a203dc84-7719-4fab-ba7e-b3403bc6a4dc"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6170), "exercises.curl.normalized-name", "cs", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6170), "BICEPSOVYZDVIH" },
                    { new Guid("a3305da5-4f5c-4ec6-8d13-9266fe0cb5f1"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6130), "exercises.lunge.description", "cs", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6130), "Výpad je cvik na dolní část těla, střídavým krokem dopředu a poklesem kolena k zemi." },
                    { new Guid("a8e82997-9f5a-497a-a8c7-d93d63659f6f"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6030), "exercises.dead-lift.normalized-name", "en", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6030), "DEADLIFT" },
                    { new Guid("b6a6e076-d6cd-4b96-89d7-89e149f78b38"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6150), "exercises.push-up.description", "en", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6150), "A versatile exercise engaging the chest, shoulders, and triceps. Start in a plank position, lower your body to the ground, and push back up." },
                    { new Guid("c0db9fb0-37f1-4a0b-bb63-3c1c4f72c3d1"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6030), "exercises.dead-lift.description", "en", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6030), "A compound exercise for overall strength, focusing on the back, glutes, hamstrings, and lower back. Start with the weight on the ground, hinge at the hips, lift the weight by straightening your hips and knees." },
                    { new Guid("c456cfb8-cb85-482d-b392-4bc8ad0c8f03"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6110), "exercises.bench-press.normalized-name", "cs", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6110), "BENCHPRESS" },
                    { new Guid("c563f5f4-07e8-4729-9177-6b6f0afa392c"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6020), "exercises.squat.description", "cs", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6020), "Dřep posiluje dolní část těla, především nohy, hamstrings a hýždě. Vykonává se stáním s váhou na ramenou a poklesem do pravého úhlu v kolenou." },
                    { new Guid("c9fbdc24-0336-4f96-8646-f21ceb499fda"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6050), "exercises.shoulder-press.description", "cs", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6050), "Tlaky na ramena zaměřují se na posílení ramenních svalů a vykonávají se tlačením činek nad hlavu." },
                    { new Guid("ca689ebb-c14a-4f79-97b8-48030bde49b9"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6100), "exercises.bench-press.name", "cs", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6100), "Bench press" },
                    { new Guid("caa4f322-eb68-499f-8e23-ba1a4edb766e"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6130), "exercises.lunge.description", "en", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6130), "A lower body exercise targeting the legs and glutes. Take a step forward with one leg, lower your body until both knees form right angles, then return to the starting position." },
                    { new Guid("dd05513a-fa27-4722-ba6c-60a35feac113"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6080), "exercises.dip.normalized-name", "en", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6080), "DIP" },
                    { new Guid("de1f9a77-17c2-4e34-a3f3-cde8908a7e67"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6110), "exercises.bench-press.description", "en", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6110), "A classic chest exercise focusing on the pectoral muscles. Lie on a bench, lower and lift a barbell or dumbbells to and from your chest." },
                    { new Guid("df1f5582-1189-47c5-9b67-51444b625015"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6160), "exercises.curl.name", "en", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6160), "Bicep curl" },
                    { new Guid("e474e447-9ad5-4f1f-9906-a7c44361a298"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6020), "exercises.dead-lift.name", "en", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6020), "Dead-lift" },
                    { new Guid("e69983d3-d3db-491e-a12a-76a2d96cd51b"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6070), "exercises.pull-up.normalized-name", "cs", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6070), "SHYB" },
                    { new Guid("e6bbed0b-5d4c-410a-85fe-ee52d704a7dd"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6120), "exercises.lunge.name", "en", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6120), "Lunge" },
                    { new Guid("ecadef8c-2b06-487f-9508-ebea7faedaa0"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6100), "exercises.bench-press.name", "en", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6100), "Bench press" },
                    { new Guid("f22b5184-fa58-4793-abde-7dbd39e1cdca"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6100), "exercises.bench-press.normalized-name", "en", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6100), "BENCHPRESS" },
                    { new Guid("fdb22b08-d9f1-4698-805c-77e198575f25"), new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6160), "exercises.curl.normalized-name", "en", new DateTime(2024, 1, 12, 17, 16, 17, 577, DateTimeKind.Utc).AddTicks(6160), "BICEPCURL" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("235db024-23e0-4383-8392-24051d34dab7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2fb5dd3d-33f1-4df0-8d3d-76ebccf624fe"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5443f8f5-b9dc-4afa-9835-09f730a8219b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6f714844-8a78-40b7-9cc3-78291fcb0864"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8199994a-2c4a-417a-86e6-b2143c38e4d6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("95640e86-3b1f-475f-b6a4-04aa9aa95fa6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fa8378b2-66c4-4ea8-a14a-5486421727d5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fb51932c-7457-4dc8-afef-0b8d613b09fd"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ff78d2e7-d3a5-49f6-a9ef-2476eb272343"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("16a5d582-4405-44a6-a439-0e2b45f81725"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("29a68557-6522-402a-9758-9edf58ad02ec"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("42fe9642-3cf5-41e1-91f7-4297df327e45"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("488b1d32-2b0f-4c75-88b5-aa7aa0b0787f"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("4f425b9d-1539-4111-ad2c-eec94c75c581"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("7e3c56c9-1efe-46f5-a62b-badc86c90853"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("cec5bd39-ccd0-4713-a5b0-ebfbaa9e8563"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("d7551e02-3de6-43c3-a1ae-378f885c10c2"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("de3fea2e-aebd-4191-9637-1c70a4cf4382"));

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: new Guid("efbd8fc8-9f68-4733-b21b-dd01271ed4d8"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("0070e103-da17-48c9-88ae-4ba94ace0650"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("022cf0b1-a982-4275-af79-1f451d578c41"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("0463c1c3-8f97-4c29-a878-c4d8b2227edf"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("0e777278-f097-49d1-ac7f-18e9c0291a78"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("0ec263a6-834d-4cf1-b768-4b303df83e38"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("0ee916e3-c745-47ca-9b8b-3f0008f78517"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("14040039-e74f-4978-bf90-8a5fe5832b35"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("17c4bf72-d9d3-4004-a32a-5accd6a589ba"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("1e8f0d9e-4a6b-4370-8d7d-4474af5586b6"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("25abb841-fcf2-42fb-9b43-5d3aaf1640c6"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("27736998-f81c-4a01-a5c4-33533d08d87b"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("2d5a0c6f-28e6-459d-ad36-3a92c671142e"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("30cf6252-e5e1-4c90-89f9-1cd5e553fabb"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("3216a9d4-b033-4511-b981-7f9d83633dda"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("3223083b-3249-40a1-97cb-69ac47ea9712"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("3850c017-f071-4b66-a8d2-56ff36cf47be"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("398e4659-c853-4cad-8470-007e3d2fd8c2"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("46435ef8-e444-4b34-83be-95890bc5c151"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("4a50b1a0-df08-48a6-a43e-c492f8bd7fc7"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("4ba32383-9ef2-42b9-a5b4-d97a54c62c4d"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("4fdeb35d-a3be-4e1d-8870-c99a7a3e47f2"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("527d0cbd-0749-4896-8c75-090860d75673"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("52d6cb36-aba8-410f-962d-82831668d84d"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("54e097e8-4764-4605-9945-544697364cba"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("58b21240-7e65-474a-a768-87555314a288"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("594eb423-6e52-477f-8fff-d2810837a2af"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("6268d648-552b-4596-a2fc-4ed8c1636f32"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("6a754431-7a82-4282-8b34-b02a7a1f7bad"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("74834118-a803-4374-9124-7118cc09f205"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("7500d55e-1e52-4aaa-8fd4-cc40b55a8eb1"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("7c22d816-17e8-4bee-9abe-9ec45f32eb44"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("7f03c884-ec07-4b21-bbed-dc0556934a86"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("847ab7dc-db1a-4730-8403-bf0726ea059a"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("978c35dc-0a18-4aa5-bc6f-2712d13be1e0"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("9a29eaf0-4ce7-45cb-8035-8bc3b885856f"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("a203dc84-7719-4fab-ba7e-b3403bc6a4dc"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("a3305da5-4f5c-4ec6-8d13-9266fe0cb5f1"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("a8e82997-9f5a-497a-a8c7-d93d63659f6f"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("b6a6e076-d6cd-4b96-89d7-89e149f78b38"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("c0db9fb0-37f1-4a0b-bb63-3c1c4f72c3d1"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("c456cfb8-cb85-482d-b392-4bc8ad0c8f03"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("c563f5f4-07e8-4729-9177-6b6f0afa392c"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("c9fbdc24-0336-4f96-8646-f21ceb499fda"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("ca689ebb-c14a-4f79-97b8-48030bde49b9"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("caa4f322-eb68-499f-8e23-ba1a4edb766e"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("dd05513a-fa27-4722-ba6c-60a35feac113"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("de1f9a77-17c2-4e34-a3f3-cde8908a7e67"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("df1f5582-1189-47c5-9b67-51444b625015"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("e474e447-9ad5-4f1f-9906-a7c44361a298"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("e69983d3-d3db-491e-a12a-76a2d96cd51b"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("e6bbed0b-5d4c-410a-85fe-ee52d704a7dd"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("ecadef8c-2b06-487f-9508-ebea7faedaa0"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("f22b5184-fa58-4793-abde-7dbd39e1cdca"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("fdb22b08-d9f1-4698-805c-77e198575f25"));

            migrationBuilder.CreateTable(
                name: "Geolocations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Geolocations", x => x.Id);
                });

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
        }
    }
}
