using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsClub.API.Migrations
{
    /// <inheritdoc />
    public partial class test25 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Lessons_LessonId",
                table: "Enrollments");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_LessonId",
                table: "Enrollments");

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CurrentCapacity", "MaxCapacity" },
                values: new object[] { 21, 22 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CurrentCapacity", "MaxCapacity" },
                values: new object[] { 4, 15 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CurrentCapacity", "MaxCapacity", "StartDateTime" },
                values: new object[] { 5, 16, new DateTime(2024, 2, 18, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CurrentCapacity", "MaxCapacity" },
                values: new object[] { 21, 5 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CurrentCapacity", "MaxCapacity", "StartDateTime" },
                values: new object[] { 6, 22, new DateTime(2024, 2, 24, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CurrentCapacity", "MaxCapacity" },
                values: new object[] { 22, 22 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CurrentCapacity", "MaxCapacity" },
                values: new object[] { 22, 22 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CurrentCapacity", "MaxCapacity", "StartDateTime" },
                values: new object[] { 12, 22, new DateTime(2024, 2, 18, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CurrentCapacity", "MaxCapacity", "StartDateTime" },
                values: new object[] { 13, 22, new DateTime(2024, 2, 18, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CurrentCapacity", "MaxCapacity", "StartDateTime" },
                values: new object[] { 16, 17, new DateTime(2024, 2, 18, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CurrentCapacity", "MaxCapacity", "StartDateTime" },
                values: new object[] { 17, 17, new DateTime(2024, 2, 18, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CurrentCapacity", "MaxCapacity", "StartDateTime" },
                values: new object[] { 21, 22, new DateTime(2024, 2, 18, 19, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CurrentCapacity", "MaxCapacity" },
                values: new object[] { 5, 22 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CurrentCapacity", "MaxCapacity" },
                values: new object[] { 6, 22 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CurrentCapacity", "MaxCapacity" },
                values: new object[] { 5, 22 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CurrentCapacity", "MaxCapacity" },
                values: new object[] { 4, 22 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CurrentCapacity", "MaxCapacity" },
                values: new object[] { 5, 22 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CurrentCapacity", "MaxCapacity", "StartDateTime" },
                values: new object[] { 3, 22, new DateTime(2024, 2, 24, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CurrentCapacity", "MaxCapacity" },
                values: new object[] { 5, 22 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CurrentCapacity", "MaxCapacity" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CurrentCapacity", "MaxCapacity" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CurrentCapacity", "MaxCapacity", "StartDateTime" },
                values: new object[] { 0, 0, new DateTime(2024, 2, 17, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CurrentCapacity", "MaxCapacity" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CurrentCapacity", "MaxCapacity", "StartDateTime" },
                values: new object[] { 0, 0, new DateTime(2024, 2, 17, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CurrentCapacity", "MaxCapacity" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CurrentCapacity", "MaxCapacity" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CurrentCapacity", "MaxCapacity", "StartDateTime" },
                values: new object[] { 0, 0, new DateTime(2024, 2, 17, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CurrentCapacity", "MaxCapacity", "StartDateTime" },
                values: new object[] { 0, 0, new DateTime(2024, 2, 17, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CurrentCapacity", "MaxCapacity", "StartDateTime" },
                values: new object[] { 0, 0, new DateTime(2024, 2, 17, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CurrentCapacity", "MaxCapacity", "StartDateTime" },
                values: new object[] { 0, 0, new DateTime(2024, 2, 17, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CurrentCapacity", "MaxCapacity", "StartDateTime" },
                values: new object[] { 0, 0, new DateTime(2024, 2, 17, 19, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CurrentCapacity", "MaxCapacity" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CurrentCapacity", "MaxCapacity" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CurrentCapacity", "MaxCapacity" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CurrentCapacity", "MaxCapacity" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CurrentCapacity", "MaxCapacity" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CurrentCapacity", "MaxCapacity", "StartDateTime" },
                values: new object[] { 0, 0, new DateTime(2024, 2, 17, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CurrentCapacity", "MaxCapacity" },
                values: new object[] { 0, 0 });

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
    }
}
