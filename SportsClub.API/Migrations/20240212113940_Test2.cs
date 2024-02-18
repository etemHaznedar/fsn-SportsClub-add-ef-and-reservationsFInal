using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsClub.API.Migrations
{
    /// <inheritdoc />
    public partial class Test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_workouts",
                table: "workouts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_lessons",
                table: "lessons");

            migrationBuilder.RenameTable(
                name: "workouts",
                newName: "Workouts");

            migrationBuilder.RenameTable(
                name: "lessons",
                newName: "Lessons");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Workouts",
                table: "Workouts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lessons",
                table: "Lessons",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 13, 19, 30, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 12, 18, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 12, 18, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 13, 15, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 15, 15, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 17, 10, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 16, 19, 30, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 18, 11, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 12, 16, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 12, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 12, 20, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 12, 17, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 12, 19, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 12, 17, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 13, 17, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 14, 14, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 17,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 15, 14, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 18,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 16, 14, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 19,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 17, 10, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 20,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 18, 10, 0, 0, 0, DateTimeKind.Local));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Workouts",
                table: "Workouts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lessons",
                table: "Lessons");

            migrationBuilder.RenameTable(
                name: "Workouts",
                newName: "workouts");

            migrationBuilder.RenameTable(
                name: "Lessons",
                newName: "lessons");

            migrationBuilder.AddPrimaryKey(
                name: "PK_workouts",
                table: "workouts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_lessons",
                table: "lessons",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 6, 19, 30, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 5, 18, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDateTime",
                value: new DateTime(2024, 1, 31, 18, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 6, 15, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 1, 15, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 3, 10, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 2, 19, 30, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 4, 11, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "StartDateTime",
                value: new DateTime(2024, 1, 31, 16, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "StartDateTime",
                value: new DateTime(2024, 1, 31, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "StartDateTime",
                value: new DateTime(2024, 1, 31, 20, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "StartDateTime",
                value: new DateTime(2024, 1, 31, 17, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "StartDateTime",
                value: new DateTime(2024, 1, 31, 19, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 5, 17, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 6, 17, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "Id",
                keyValue: 16,
                column: "StartDateTime",
                value: new DateTime(2024, 1, 31, 14, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "Id",
                keyValue: 17,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 1, 14, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "Id",
                keyValue: 18,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 2, 14, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "Id",
                keyValue: 19,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 3, 10, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "Id",
                keyValue: 20,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 4, 10, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
