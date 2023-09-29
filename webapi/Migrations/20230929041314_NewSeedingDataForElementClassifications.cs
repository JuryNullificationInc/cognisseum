using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace webapi.Migrations
{
    /// <inheritdoc />
    public partial class NewSeedingDataForElementClassifications : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ElementClassification",
                columns: new[] { "Id", "ElementId", "Guid", "IPAdded", "IPModified", "IsActive", "TimeAdded", "TimeModified", "TypeId", "UserAddedId", "UserModifiedId" },
                values: new object[,]
                {
                    { 119L, 1L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 13L, "1", "1" },
                    { 120L, 6L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 13L, "1", "1" },
                    { 121L, 7L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 13L, "1", "1" },
                    { 122L, 8L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 13L, "1", "1" },
                    { 123L, 9L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 14L, "1", "1" },
                    { 124L, 15L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 14L, "1", "1" },
                    { 125L, 16L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 14L, "1", "1" },
                    { 126L, 17L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 14L, "1", "1" },
                    { 127L, 35L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 14L, "1", "1" },
                    { 128L, 53L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 14L, "1", "1" },
                    { 129L, 3L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 14L, "1", "1" },
                    { 130L, 11L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 14L, "1", "1" },
                    { 131L, 19L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 14L, "1", "1" },
                    { 132L, 4L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 14L, "1", "1" },
                    { 133L, 12L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 14L, "1", "1" },
                    { 134L, 20L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 14L, "1", "1" },
                    { 135L, 5L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 14L, "1", "1" },
                    { 136L, 13L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 14L, "1", "1" },
                    { 137L, 14L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 14L, "1", "1" },
                    { 138L, 2L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 14L, "1", "1" },
                    { 139L, 10L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 14L, "1", "1" },
                    { 140L, 18L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 14L, "1", "1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ElementClassification",
                keyColumn: "Id",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "ElementClassification",
                keyColumn: "Id",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "ElementClassification",
                keyColumn: "Id",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "ElementClassification",
                keyColumn: "Id",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "ElementClassification",
                keyColumn: "Id",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "ElementClassification",
                keyColumn: "Id",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "ElementClassification",
                keyColumn: "Id",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "ElementClassification",
                keyColumn: "Id",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                table: "ElementClassification",
                keyColumn: "Id",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                table: "ElementClassification",
                keyColumn: "Id",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                table: "ElementClassification",
                keyColumn: "Id",
                keyValue: 129L);

            migrationBuilder.DeleteData(
                table: "ElementClassification",
                keyColumn: "Id",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                table: "ElementClassification",
                keyColumn: "Id",
                keyValue: 131L);

            migrationBuilder.DeleteData(
                table: "ElementClassification",
                keyColumn: "Id",
                keyValue: 132L);

            migrationBuilder.DeleteData(
                table: "ElementClassification",
                keyColumn: "Id",
                keyValue: 133L);

            migrationBuilder.DeleteData(
                table: "ElementClassification",
                keyColumn: "Id",
                keyValue: 134L);

            migrationBuilder.DeleteData(
                table: "ElementClassification",
                keyColumn: "Id",
                keyValue: 135L);

            migrationBuilder.DeleteData(
                table: "ElementClassification",
                keyColumn: "Id",
                keyValue: 136L);

            migrationBuilder.DeleteData(
                table: "ElementClassification",
                keyColumn: "Id",
                keyValue: 137L);

            migrationBuilder.DeleteData(
                table: "ElementClassification",
                keyColumn: "Id",
                keyValue: 138L);

            migrationBuilder.DeleteData(
                table: "ElementClassification",
                keyColumn: "Id",
                keyValue: 139L);

            migrationBuilder.DeleteData(
                table: "ElementClassification",
                keyColumn: "Id",
                keyValue: 140L);
        }
    }
}
