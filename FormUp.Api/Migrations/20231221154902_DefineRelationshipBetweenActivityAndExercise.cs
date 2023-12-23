using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FormUp.Api.Migrations
{
    /// <inheritdoc />
    public partial class DefineRelationshipBetweenActivityAndExercise : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Exercises_ExerciseId",
                table: "Activities");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("35fb6cd8-3f39-4928-adf3-5f86407272b4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("93436d4a-4b0d-4724-8d19-f4976d0cbf03"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c61abd0f-8031-4fdd-9773-1e4a3ed46432"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ddbfbad7-c919-43a8-a4f5-4e848e4c166e"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ExerciseId",
                table: "Activities",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("459c307a-98dc-4591-b55e-de3e359a5269"), new DateTime(2023, 12, 21, 16, 49, 2, 565, DateTimeKind.Local).AddTicks(3990), new DateTime(2023, 12, 21, 16, 49, 2, 565, DateTimeKind.Local).AddTicks(3990), "Dips" },
                    { new Guid("5e4ae2f1-afa5-48a0-a5e3-c072790afa99"), new DateTime(2023, 12, 21, 16, 49, 2, 565, DateTimeKind.Local).AddTicks(3980), new DateTime(2023, 12, 21, 16, 49, 2, 565, DateTimeKind.Local).AddTicks(3980), "Body-weight squats" },
                    { new Guid("9341a66e-dda8-4f26-a02e-01b2565bdb16"), new DateTime(2023, 12, 21, 16, 49, 2, 565, DateTimeKind.Local).AddTicks(3900), new DateTime(2023, 12, 21, 16, 49, 2, 565, DateTimeKind.Local).AddTicks(3970), "Pull ups" },
                    { new Guid("e274ef28-8a34-4321-8cc6-ee89e384713f"), new DateTime(2023, 12, 21, 16, 49, 2, 565, DateTimeKind.Local).AddTicks(3980), new DateTime(2023, 12, 21, 16, 49, 2, 565, DateTimeKind.Local).AddTicks(3980), "Push ups" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Exercises_ExerciseId",
                table: "Activities",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Exercises_ExerciseId",
                table: "Activities");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("459c307a-98dc-4591-b55e-de3e359a5269"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5e4ae2f1-afa5-48a0-a5e3-c072790afa99"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9341a66e-dda8-4f26-a02e-01b2565bdb16"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e274ef28-8a34-4321-8cc6-ee89e384713f"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ExerciseId",
                table: "Activities",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("35fb6cd8-3f39-4928-adf3-5f86407272b4"), new DateTime(2023, 12, 21, 12, 26, 46, 450, DateTimeKind.Local).AddTicks(9280), new DateTime(2023, 12, 21, 12, 26, 46, 450, DateTimeKind.Local).AddTicks(9280), "Body-weight squats" },
                    { new Guid("93436d4a-4b0d-4724-8d19-f4976d0cbf03"), new DateTime(2023, 12, 21, 12, 26, 46, 450, DateTimeKind.Local).AddTicks(9210), new DateTime(2023, 12, 21, 12, 26, 46, 450, DateTimeKind.Local).AddTicks(9270), "Pull ups" },
                    { new Guid("c61abd0f-8031-4fdd-9773-1e4a3ed46432"), new DateTime(2023, 12, 21, 12, 26, 46, 450, DateTimeKind.Local).AddTicks(9280), new DateTime(2023, 12, 21, 12, 26, 46, 450, DateTimeKind.Local).AddTicks(9290), "Dips" },
                    { new Guid("ddbfbad7-c919-43a8-a4f5-4e848e4c166e"), new DateTime(2023, 12, 21, 12, 26, 46, 450, DateTimeKind.Local).AddTicks(9270), new DateTime(2023, 12, 21, 12, 26, 46, 450, DateTimeKind.Local).AddTicks(9280), "Push ups" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Exercises_ExerciseId",
                table: "Activities",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "Id");
        }
    }
}
