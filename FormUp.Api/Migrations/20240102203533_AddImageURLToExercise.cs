using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FormUp.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddImageURLToExercise : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0bee513c-3b3f-4b0d-92d2-c35ff19efccf"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("59bba53d-32c4-4c7a-921f-b50244f5671d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("73925319-a217-4c35-aa2f-4e56e9553d85"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7f1d02b1-2b42-4c4a-8d28-eaf7c83f7b3e"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("0b7ec5a5-3dbc-49a4-a9d5-ea66b9d8a54e"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("7341f05f-b889-49a9-b0b7-e8b714e06614"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("b5a941a7-53ce-4350-a39f-ee1905a964ad"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("bce2af68-2cc5-43ee-a904-319509a54226"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("c54cfb99-7be8-4f7e-b139-a0c04abb48e8"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("ee3ba020-23ce-42a3-936f-1a9d69922e64"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("f7a68c6f-f911-4720-ad1b-24159f4e78b7"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("fe6dc787-3c2a-4540-81ed-7c988ebcfa65"));

            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "CreatedAt", "ImageURL", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("07eb8084-1ea1-4de5-97e9-919bc447e6ea"), new DateTime(2024, 1, 2, 21, 35, 32, 813, DateTimeKind.Local).AddTicks(540), null, new DateTime(2024, 1, 2, 21, 35, 32, 813, DateTimeKind.Local).AddTicks(620), "exercises.pull-ups" },
                    { new Guid("3b83d3ca-c68d-4a92-adda-18e813fc096f"), new DateTime(2024, 1, 2, 21, 35, 32, 813, DateTimeKind.Local).AddTicks(630), null, new DateTime(2024, 1, 2, 21, 35, 32, 813, DateTimeKind.Local).AddTicks(630), "exercises.push-ups" },
                    { new Guid("3c82c2e8-2c2d-4106-86b7-3e2f3a39c51a"), new DateTime(2024, 1, 2, 21, 35, 32, 813, DateTimeKind.Local).AddTicks(640), null, new DateTime(2024, 1, 2, 21, 35, 32, 813, DateTimeKind.Local).AddTicks(640), "exercises.dips" },
                    { new Guid("6a15c340-61f6-4ba7-b676-cbd5ce68c46f"), new DateTime(2024, 1, 2, 21, 35, 32, 813, DateTimeKind.Local).AddTicks(630), null, new DateTime(2024, 1, 2, 21, 35, 32, 813, DateTimeKind.Local).AddTicks(630), "exercises.bw-squats" }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "CreatedAt", "Key", "Locale", "ModifiedAt", "Value" },
                values: new object[,]
                {
                    { new Guid("06a4f1d8-6d8d-4e23-a52b-4831e8ed22b2"), new DateTime(2024, 1, 2, 21, 35, 32, 813, DateTimeKind.Local).AddTicks(790), "exercises.bw-squats", "cs", new DateTime(2024, 1, 2, 21, 35, 32, 813, DateTimeKind.Local).AddTicks(790), "Dřepy s vlastní vahou" },
                    { new Guid("136e9f39-5ee7-4722-a129-8b15e4ced3bc"), new DateTime(2024, 1, 2, 21, 35, 32, 813, DateTimeKind.Local).AddTicks(780), "exercises.dips", "cs", new DateTime(2024, 1, 2, 21, 35, 32, 813, DateTimeKind.Local).AddTicks(780), "Dipy" },
                    { new Guid("44cbcd5e-ea21-4702-a840-4c08da3aacea"), new DateTime(2024, 1, 2, 21, 35, 32, 813, DateTimeKind.Local).AddTicks(810), "exercises.push-ups", "en", new DateTime(2024, 1, 2, 21, 35, 32, 813, DateTimeKind.Local).AddTicks(810), "Push ups" },
                    { new Guid("8b4719eb-a881-442f-a619-5875551ae659"), new DateTime(2024, 1, 2, 21, 35, 32, 813, DateTimeKind.Local).AddTicks(770), "exercises.pull-ups", "cs", new DateTime(2024, 1, 2, 21, 35, 32, 813, DateTimeKind.Local).AddTicks(770), "Shyby" },
                    { new Guid("921b1877-a56c-48f2-b382-5c6614e9e71f"), new DateTime(2024, 1, 2, 21, 35, 32, 813, DateTimeKind.Local).AddTicks(770), "exercises.pull-ups", "en", new DateTime(2024, 1, 2, 21, 35, 32, 813, DateTimeKind.Local).AddTicks(770), "Pull ups" },
                    { new Guid("939b254f-cf75-44fc-9add-0ce05134deb4"), new DateTime(2024, 1, 2, 21, 35, 32, 813, DateTimeKind.Local).AddTicks(800), "exercises.push-ups", "cs", new DateTime(2024, 1, 2, 21, 35, 32, 813, DateTimeKind.Local).AddTicks(800), "Kliky" },
                    { new Guid("d03a2674-eecc-442e-97eb-16212bbb64a2"), new DateTime(2024, 1, 2, 21, 35, 32, 813, DateTimeKind.Local).AddTicks(790), "exercises.dips", "en", new DateTime(2024, 1, 2, 21, 35, 32, 813, DateTimeKind.Local).AddTicks(790), "Dips" },
                    { new Guid("fa99d7ba-8d3a-4bac-bbef-e46779186d2d"), new DateTime(2024, 1, 2, 21, 35, 32, 813, DateTimeKind.Local).AddTicks(800), "exercises.bw-squats", "en", new DateTime(2024, 1, 2, 21, 35, 32, 813, DateTimeKind.Local).AddTicks(800), "Body-weight squats" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("07eb8084-1ea1-4de5-97e9-919bc447e6ea"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3b83d3ca-c68d-4a92-adda-18e813fc096f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3c82c2e8-2c2d-4106-86b7-3e2f3a39c51a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6a15c340-61f6-4ba7-b676-cbd5ce68c46f"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("06a4f1d8-6d8d-4e23-a52b-4831e8ed22b2"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("136e9f39-5ee7-4722-a129-8b15e4ced3bc"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("44cbcd5e-ea21-4702-a840-4c08da3aacea"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("8b4719eb-a881-442f-a619-5875551ae659"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("921b1877-a56c-48f2-b382-5c6614e9e71f"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("939b254f-cf75-44fc-9add-0ce05134deb4"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("d03a2674-eecc-442e-97eb-16212bbb64a2"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("fa99d7ba-8d3a-4bac-bbef-e46779186d2d"));

            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Exercises");

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("0bee513c-3b3f-4b0d-92d2-c35ff19efccf"), new DateTime(2023, 12, 30, 18, 14, 25, 186, DateTimeKind.Local).AddTicks(4440), new DateTime(2023, 12, 30, 18, 14, 25, 186, DateTimeKind.Local).AddTicks(4440), "exercises.dips" },
                    { new Guid("59bba53d-32c4-4c7a-921f-b50244f5671d"), new DateTime(2023, 12, 30, 18, 14, 25, 186, DateTimeKind.Local).AddTicks(4440), new DateTime(2023, 12, 30, 18, 14, 25, 186, DateTimeKind.Local).AddTicks(4440), "exercises.bw-squats" },
                    { new Guid("73925319-a217-4c35-aa2f-4e56e9553d85"), new DateTime(2023, 12, 30, 18, 14, 25, 186, DateTimeKind.Local).AddTicks(4370), new DateTime(2023, 12, 30, 18, 14, 25, 186, DateTimeKind.Local).AddTicks(4420), "exercises.pull-ups" },
                    { new Guid("7f1d02b1-2b42-4c4a-8d28-eaf7c83f7b3e"), new DateTime(2023, 12, 30, 18, 14, 25, 186, DateTimeKind.Local).AddTicks(4430), new DateTime(2023, 12, 30, 18, 14, 25, 186, DateTimeKind.Local).AddTicks(4430), "exercises.push-ups" }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "CreatedAt", "Key", "Locale", "ModifiedAt", "Value" },
                values: new object[,]
                {
                    { new Guid("0b7ec5a5-3dbc-49a4-a9d5-ea66b9d8a54e"), new DateTime(2023, 12, 30, 18, 14, 25, 186, DateTimeKind.Local).AddTicks(4570), "exercises.dips", "en", new DateTime(2023, 12, 30, 18, 14, 25, 186, DateTimeKind.Local).AddTicks(4570), "Dips" },
                    { new Guid("7341f05f-b889-49a9-b0b7-e8b714e06614"), new DateTime(2023, 12, 30, 18, 14, 25, 186, DateTimeKind.Local).AddTicks(4550), "exercises.pull-ups", "cs", new DateTime(2023, 12, 30, 18, 14, 25, 186, DateTimeKind.Local).AddTicks(4560), "Shyby" },
                    { new Guid("b5a941a7-53ce-4350-a39f-ee1905a964ad"), new DateTime(2023, 12, 30, 18, 14, 25, 186, DateTimeKind.Local).AddTicks(4560), "exercises.pull-ups", "en", new DateTime(2023, 12, 30, 18, 14, 25, 186, DateTimeKind.Local).AddTicks(4560), "Pull ups" },
                    { new Guid("bce2af68-2cc5-43ee-a904-319509a54226"), new DateTime(2023, 12, 30, 18, 14, 25, 186, DateTimeKind.Local).AddTicks(4590), "exercises.push-ups", "en", new DateTime(2023, 12, 30, 18, 14, 25, 186, DateTimeKind.Local).AddTicks(4590), "Push ups" },
                    { new Guid("c54cfb99-7be8-4f7e-b139-a0c04abb48e8"), new DateTime(2023, 12, 30, 18, 14, 25, 186, DateTimeKind.Local).AddTicks(4590), "exercises.push-ups", "cs", new DateTime(2023, 12, 30, 18, 14, 25, 186, DateTimeKind.Local).AddTicks(4590), "Kliky" },
                    { new Guid("ee3ba020-23ce-42a3-936f-1a9d69922e64"), new DateTime(2023, 12, 30, 18, 14, 25, 186, DateTimeKind.Local).AddTicks(4580), "exercises.bw-squats", "cs", new DateTime(2023, 12, 30, 18, 14, 25, 186, DateTimeKind.Local).AddTicks(4580), "Dřepy s vlastní vahou" },
                    { new Guid("f7a68c6f-f911-4720-ad1b-24159f4e78b7"), new DateTime(2023, 12, 30, 18, 14, 25, 186, DateTimeKind.Local).AddTicks(4580), "exercises.bw-squats", "en", new DateTime(2023, 12, 30, 18, 14, 25, 186, DateTimeKind.Local).AddTicks(4580), "Body-weight squats" },
                    { new Guid("fe6dc787-3c2a-4540-81ed-7c988ebcfa65"), new DateTime(2023, 12, 30, 18, 14, 25, 186, DateTimeKind.Local).AddTicks(4570), "exercises.dips", "cs", new DateTime(2023, 12, 30, 18, 14, 25, 186, DateTimeKind.Local).AddTicks(4570), "Dipy" }
                });
        }
    }
}
