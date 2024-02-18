using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsClub.API.Migrations
{
    /// <inheritdoc />
    public partial class _14022024 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrentCapacity",
                table: "Lessons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaxCapacity",
                table: "Lessons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Enrollments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LessonId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsEnrolled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollments", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CurrentCapacity", "MaxCapacity", "StartDateTime" },
                values: new object[] { 0, 0, new DateTime(2024, 2, 20, 19, 30, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CurrentCapacity", "MaxCapacity", "StartDateTime" },
                values: new object[] { 0, 0, new DateTime(2024, 2, 19, 18, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CurrentCapacity", "MaxCapacity", "StartDateTime" },
                values: new object[] { 0, 0, new DateTime(2024, 2, 14, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CurrentCapacity", "MaxCapacity", "StartDateTime" },
                values: new object[] { 0, 0, new DateTime(2024, 2, 20, 15, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CurrentCapacity", "MaxCapacity" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CurrentCapacity", "MaxCapacity" },
                values: new object[] { 0, 0 });

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
                values: new object[] { 0, 0, new DateTime(2024, 2, 14, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CurrentCapacity", "MaxCapacity", "StartDateTime" },
                values: new object[] { 0, 0, new DateTime(2024, 2, 14, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CurrentCapacity", "MaxCapacity", "StartDateTime" },
                values: new object[] { 0, 0, new DateTime(2024, 2, 14, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CurrentCapacity", "MaxCapacity", "StartDateTime" },
                values: new object[] { 0, 0, new DateTime(2024, 2, 14, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CurrentCapacity", "MaxCapacity", "StartDateTime" },
                values: new object[] { 0, 0, new DateTime(2024, 2, 14, 19, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CurrentCapacity", "MaxCapacity", "StartDateTime" },
                values: new object[] { 0, 0, new DateTime(2024, 2, 19, 17, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CurrentCapacity", "MaxCapacity", "StartDateTime" },
                values: new object[] { 0, 0, new DateTime(2024, 2, 20, 17, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "CurrentCapacity", "MaxCapacity" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CurrentCapacity", "MaxCapacity" },
                values: new object[] { 0, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enrollments");

            migrationBuilder.DropColumn(
                name: "CurrentCapacity",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "MaxCapacity",
                table: "Lessons");

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
        }
    }
}
