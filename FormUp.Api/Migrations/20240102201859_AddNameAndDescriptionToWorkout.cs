using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FormUp.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddNameAndDescriptionToWorkout : Migration
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
                name: "Description",
                table: "Workouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Workouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("38bc29ef-4e79-45db-97d9-4981b019bc41"), new DateTime(2024, 1, 2, 21, 18, 59, 4, DateTimeKind.Local).AddTicks(7090), new DateTime(2024, 1, 2, 21, 18, 59, 4, DateTimeKind.Local).AddTicks(7090), "exercises.push-ups" },
                    { new Guid("53890bde-7ab2-4689-a696-494a1ce7a361"), new DateTime(2024, 1, 2, 21, 18, 59, 4, DateTimeKind.Local).AddTicks(7100), new DateTime(2024, 1, 2, 21, 18, 59, 4, DateTimeKind.Local).AddTicks(7100), "exercises.dips" },
                    { new Guid("a694c919-416e-4cc7-b3b3-2240131a29c9"), new DateTime(2024, 1, 2, 21, 18, 59, 4, DateTimeKind.Local).AddTicks(7090), new DateTime(2024, 1, 2, 21, 18, 59, 4, DateTimeKind.Local).AddTicks(7090), "exercises.bw-squats" },
                    { new Guid("fdb77d6a-1449-44cd-a097-1ed4a58d637d"), new DateTime(2024, 1, 2, 21, 18, 59, 4, DateTimeKind.Local).AddTicks(7040), new DateTime(2024, 1, 2, 21, 18, 59, 4, DateTimeKind.Local).AddTicks(7080), "exercises.pull-ups" }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "CreatedAt", "Key", "Locale", "ModifiedAt", "Value" },
                values: new object[,]
                {
                    { new Guid("24d3cdfd-d0e3-4228-9c6b-b49f3414b24f"), new DateTime(2024, 1, 2, 21, 18, 59, 4, DateTimeKind.Local).AddTicks(7230), "exercises.push-ups", "cs", new DateTime(2024, 1, 2, 21, 18, 59, 4, DateTimeKind.Local).AddTicks(7230), "Kliky" },
                    { new Guid("70b1bd1f-7c8a-450c-b975-a34a0d492178"), new DateTime(2024, 1, 2, 21, 18, 59, 4, DateTimeKind.Local).AddTicks(7200), "exercises.pull-ups", "cs", new DateTime(2024, 1, 2, 21, 18, 59, 4, DateTimeKind.Local).AddTicks(7200), "Shyby" },
                    { new Guid("7bc2f37a-913d-45da-9d07-f82d2dcca015"), new DateTime(2024, 1, 2, 21, 18, 59, 4, DateTimeKind.Local).AddTicks(7240), "exercises.push-ups", "en", new DateTime(2024, 1, 2, 21, 18, 59, 4, DateTimeKind.Local).AddTicks(7240), "Push ups" },
                    { new Guid("7cea4c28-7042-4976-956d-0616b66cb24e"), new DateTime(2024, 1, 2, 21, 18, 59, 4, DateTimeKind.Local).AddTicks(7210), "exercises.pull-ups", "en", new DateTime(2024, 1, 2, 21, 18, 59, 4, DateTimeKind.Local).AddTicks(7210), "Pull ups" },
                    { new Guid("881fcd5e-eda7-4bcd-9045-65f47abd563e"), new DateTime(2024, 1, 2, 21, 18, 59, 4, DateTimeKind.Local).AddTicks(7220), "exercises.dips", "en", new DateTime(2024, 1, 2, 21, 18, 59, 4, DateTimeKind.Local).AddTicks(7220), "Dips" },
                    { new Guid("e2443501-1b58-4cb3-99d2-c915347fbf56"), new DateTime(2024, 1, 2, 21, 18, 59, 4, DateTimeKind.Local).AddTicks(7230), "exercises.bw-squats", "en", new DateTime(2024, 1, 2, 21, 18, 59, 4, DateTimeKind.Local).AddTicks(7230), "Body-weight squats" },
                    { new Guid("ebd01e46-86a8-4900-bd1f-449dbea44a16"), new DateTime(2024, 1, 2, 21, 18, 59, 4, DateTimeKind.Local).AddTicks(7220), "exercises.bw-squats", "cs", new DateTime(2024, 1, 2, 21, 18, 59, 4, DateTimeKind.Local).AddTicks(7220), "Dřepy s vlastní vahou" },
                    { new Guid("fc1ec5f7-3774-41f8-9298-d3c34f79a24d"), new DateTime(2024, 1, 2, 21, 18, 59, 4, DateTimeKind.Local).AddTicks(7210), "exercises.dips", "cs", new DateTime(2024, 1, 2, 21, 18, 59, 4, DateTimeKind.Local).AddTicks(7210), "Dipy" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("38bc29ef-4e79-45db-97d9-4981b019bc41"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("53890bde-7ab2-4689-a696-494a1ce7a361"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a694c919-416e-4cc7-b3b3-2240131a29c9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fdb77d6a-1449-44cd-a097-1ed4a58d637d"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("24d3cdfd-d0e3-4228-9c6b-b49f3414b24f"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("70b1bd1f-7c8a-450c-b975-a34a0d492178"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("7bc2f37a-913d-45da-9d07-f82d2dcca015"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("7cea4c28-7042-4976-956d-0616b66cb24e"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("881fcd5e-eda7-4bcd-9045-65f47abd563e"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("e2443501-1b58-4cb3-99d2-c915347fbf56"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("ebd01e46-86a8-4900-bd1f-449dbea44a16"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("fc1ec5f7-3774-41f8-9298-d3c34f79a24d"));

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Workouts");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Workouts");

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
