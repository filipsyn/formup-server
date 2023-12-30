using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FormUp.Api.Migrations
{
    /// <inheritdoc />
    public partial class MakeUidUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Uid",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("091b2c47-8b6d-4e7c-9d9c-9b065c67c366"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("42a85eb0-0d5d-4964-8acc-c219ed10f1f1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("cc2541fc-065b-4b93-a9c6-52856ccec36f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e43186c5-41fb-4a38-be75-09a59962ae03"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("02e4246d-27cb-4917-870a-39bdd5f8f406"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("2b07c0a4-cea0-433e-bae5-47480e61565e"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("666bd883-b2a0-412e-abac-af7d585a8492"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("9dfefab2-fd81-4e3d-acc0-00be08aa4c5c"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("accca864-fcfb-48c3-8965-0179d753dc39"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("b40ecadb-8ef7-43cb-8e3f-2e9232e92888"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("c73df065-456f-4b3c-8f5f-4d4de07d7db4"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("f9d45118-a307-4121-b1f9-541165282bbd"));

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

            migrationBuilder.CreateIndex(
                name: "IX_Users_Uid",
                table: "Users",
                column: "Uid",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Uid",
                table: "Users");

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

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("091b2c47-8b6d-4e7c-9d9c-9b065c67c366"), new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2250), new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2250), "exercises.push-ups" },
                    { new Guid("42a85eb0-0d5d-4964-8acc-c219ed10f1f1"), new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2200), new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2240), "exercises.pull-ups" },
                    { new Guid("cc2541fc-065b-4b93-a9c6-52856ccec36f"), new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2250), new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2250), "exercises.bw-squats" },
                    { new Guid("e43186c5-41fb-4a38-be75-09a59962ae03"), new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2260), new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2260), "exercises.dips" }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "CreatedAt", "Key", "Locale", "ModifiedAt", "Value" },
                values: new object[,]
                {
                    { new Guid("02e4246d-27cb-4917-870a-39bdd5f8f406"), new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2380), "exercises.dips", "cs", new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2380), "Dipy" },
                    { new Guid("2b07c0a4-cea0-433e-bae5-47480e61565e"), new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2400), "exercises.push-ups", "cs", new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2400), "Kliky" },
                    { new Guid("666bd883-b2a0-412e-abac-af7d585a8492"), new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2400), "exercises.push-ups", "en", new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2410), "Push ups" },
                    { new Guid("9dfefab2-fd81-4e3d-acc0-00be08aa4c5c"), new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2390), "exercises.bw-squats", "cs", new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2390), "Dřepy s vlastní vahou" },
                    { new Guid("accca864-fcfb-48c3-8965-0179d753dc39"), new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2370), "exercises.pull-ups", "cs", new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2370), "Shyby" },
                    { new Guid("b40ecadb-8ef7-43cb-8e3f-2e9232e92888"), new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2390), "exercises.bw-squats", "en", new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2390), "Body-weight squats" },
                    { new Guid("c73df065-456f-4b3c-8f5f-4d4de07d7db4"), new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2370), "exercises.pull-ups", "en", new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2370), "Pull ups" },
                    { new Guid("f9d45118-a307-4121-b1f9-541165282bbd"), new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2380), "exercises.dips", "en", new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2390), "Dips" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Uid",
                table: "Users",
                column: "Uid");
        }
    }
}
