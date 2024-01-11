using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FormUp.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreInfoToExercises : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
