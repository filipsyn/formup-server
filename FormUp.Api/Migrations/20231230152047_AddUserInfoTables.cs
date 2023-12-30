using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FormUp.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddUserInfoTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("18701ace-5927-413a-9393-d9550d5c1221"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8a0cb85e-1a38-4d86-b33a-2ad5b3cf685a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b9648b00-a160-414e-b090-ca1a2360f420"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d2bf04e5-4301-49b9-8912-31cf478dc753"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("0043a09c-33c6-4849-aa44-e459da524d47"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("58a29f76-2cb2-43b2-873b-a9a0b4d8d1d6"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("639129eb-9054-4349-b057-be09fa374de4"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("7d2ee132-7a45-4b96-8226-a1254fb706d8"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("b02ae724-3a74-4512-af82-839b3788cebc"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("c3f44586-b780-46ab-9b75-7e0a9abb48a9"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("cfc6c877-8087-4751-841a-300fdc7bea99"));

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: new Guid("eeb0ee76-ea2f-4030-910b-1c9383a90d4b"));

            migrationBuilder.CreateTable(
                name: "Heights",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Uid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<float>(type: "real", nullable: false),
                    At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heights", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Uid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Weights",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Uid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<float>(type: "real", nullable: false),
                    At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weights", x => x.Id);
                });

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
                name: "IX_Heights_Uid",
                table: "Heights",
                column: "Uid");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Uid",
                table: "Users",
                column: "Uid");

            migrationBuilder.CreateIndex(
                name: "IX_Weights_Uid",
                table: "Weights",
                column: "Uid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Heights");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Weights");

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
                    { new Guid("18701ace-5927-413a-9393-d9550d5c1221"), new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8490), new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8490), "exercises.bw-squats" },
                    { new Guid("8a0cb85e-1a38-4d86-b33a-2ad5b3cf685a"), new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8490), new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8490), "exercises.push-ups" },
                    { new Guid("b9648b00-a160-414e-b090-ca1a2360f420"), new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8440), new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8480), "exercises.pull-ups" },
                    { new Guid("d2bf04e5-4301-49b9-8912-31cf478dc753"), new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8500), new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8500), "exercises.dips" }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "CreatedAt", "Key", "Locale", "ModifiedAt", "Value" },
                values: new object[,]
                {
                    { new Guid("0043a09c-33c6-4849-aa44-e459da524d47"), new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8600), "exercises.pull-ups", "cs", new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8600), "Shyby" },
                    { new Guid("58a29f76-2cb2-43b2-873b-a9a0b4d8d1d6"), new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8630), "exercises.push-ups", "en", new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8630), "Push ups" },
                    { new Guid("639129eb-9054-4349-b057-be09fa374de4"), new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8600), "exercises.pull-ups", "en", new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8600), "Pull ups" },
                    { new Guid("7d2ee132-7a45-4b96-8226-a1254fb706d8"), new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8610), "exercises.dips", "cs", new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8610), "Dipy" },
                    { new Guid("b02ae724-3a74-4512-af82-839b3788cebc"), new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8630), "exercises.push-ups", "cs", new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8630), "Kliky" },
                    { new Guid("c3f44586-b780-46ab-9b75-7e0a9abb48a9"), new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8610), "exercises.dips", "en", new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8610), "Dips" },
                    { new Guid("cfc6c877-8087-4751-841a-300fdc7bea99"), new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8620), "exercises.bw-squats", "en", new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8630), "Body-weight squats" },
                    { new Guid("eeb0ee76-ea2f-4030-910b-1c9383a90d4b"), new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8620), "exercises.bw-squats", "cs", new DateTime(2023, 12, 25, 15, 4, 42, 218, DateTimeKind.Local).AddTicks(8620), "Dřepy s vlastní vahou" }
                });
        }
    }
}
