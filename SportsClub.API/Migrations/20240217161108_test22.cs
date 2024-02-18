using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsClub.API.Migrations
{
    /// <inheritdoc />
    public partial class test22 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WorkoutId",
                table: "Enrollments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 17, 18, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 22, 15, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 23, 19, 30, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 17, 16, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 17, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 17, 20, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 17, 17, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 17, 19, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 17,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 22, 14, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 18,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 23, 14, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_LessonId",
                table: "Enrollments",
                column: "LessonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Lessons_LessonId",
                table: "Enrollments",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Lessons_LessonId",
                table: "Enrollments");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_LessonId",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "WorkoutId",
                table: "Enrollments");

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 15, 18, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 15, 15, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 16, 19, 30, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 15, 16, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 15, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 15, 20, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 15, 17, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "StartDateTime",
                value: new DateTime(2024, 2, 15, 19, 30, 0, 0, DateTimeKind.Unspecified));

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
        }
    }
}
