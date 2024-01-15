using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Cars",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6605d88b-ba1b-4ba8-aa51-60304b0c8f76", "AQAAAAIAAYagAAAAEJHQsKCBm6tIzdJrMCUtO6qjFZev3HCpXxhI+mojzoBEJo6BFIHU0zzTk92D/ZRARg==", "173ca127-6f24-4f12-bc74-f94c290cd04e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85d36a11-708a-43d2-9186-aecbfbe94834", "AQAAAAIAAYagAAAAEOxlXnmsdAq9HW4bzEq4QU/t/z0FUpThA9a6oW3PNIPvMlNd5uuUTBo7esGoVnrGqQ==", "4c9b6b9f-6a05-4db7-8cdf-d429810810e7" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 57, 18, 616, DateTimeKind.Local).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 57, 18, 616, DateTimeKind.Local).AddTicks(79));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 57, 18, 616, DateTimeKind.Local).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 57, 18, 616, DateTimeKind.Local).AddTicks(85));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 57, 18, 616, DateTimeKind.Local).AddTicks(87));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 57, 18, 616, DateTimeKind.Local).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 57, 18, 616, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 57, 18, 616, DateTimeKind.Local).AddTicks(94));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 57, 18, 616, DateTimeKind.Local).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 57, 18, 616, DateTimeKind.Local).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 57, 18, 617, DateTimeKind.Local).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 57, 18, 617, DateTimeKind.Local).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 57, 18, 617, DateTimeKind.Local).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 57, 18, 617, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 57, 18, 617, DateTimeKind.Local).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 57, 18, 617, DateTimeKind.Local).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 57, 18, 617, DateTimeKind.Local).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 57, 18, 617, DateTimeKind.Local).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 57, 18, 617, DateTimeKind.Local).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 57, 18, 617, DateTimeKind.Local).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 57, 18, 617, DateTimeKind.Local).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 57, 18, 617, DateTimeKind.Local).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 57, 18, 617, DateTimeKind.Local).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 57, 18, 617, DateTimeKind.Local).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 57, 18, 617, DateTimeKind.Local).AddTicks(6311));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Cars");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "962f9a3f-2c4f-4541-824b-581371973a13", "AQAAAAIAAYagAAAAEGnYZMxp9cW0/WMIULZSOGHC/PXCiA6oCDY6RotYcXl1uP9fTQdNEI6CdzwZfhz3bA==", "4d63cfad-db2d-4f94-a3d2-bb06033ce2d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d85a933-3ac2-483d-be0e-297d00a6c173", "AQAAAAIAAYagAAAAEHFj1/Kma6uwT399GM0XktVRQ6oVuOZGNLPGrkApwb8OIYnoJ2FQeLAZYGG2oC+qjQ==", "87a63da6-3b7f-4982-a046-5b07012e6f37" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 8, 17, 342, DateTimeKind.Local).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 8, 17, 342, DateTimeKind.Local).AddTicks(3843));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 8, 17, 342, DateTimeKind.Local).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 8, 17, 342, DateTimeKind.Local).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 8, 17, 342, DateTimeKind.Local).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 8, 17, 342, DateTimeKind.Local).AddTicks(3847));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 8, 17, 342, DateTimeKind.Local).AddTicks(3848));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 8, 17, 342, DateTimeKind.Local).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 8, 17, 342, DateTimeKind.Local).AddTicks(3853));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 8, 17, 342, DateTimeKind.Local).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 8, 17, 343, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 8, 17, 343, DateTimeKind.Local).AddTicks(1334));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 8, 17, 343, DateTimeKind.Local).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 8, 17, 343, DateTimeKind.Local).AddTicks(1336));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 8, 17, 343, DateTimeKind.Local).AddTicks(1338));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 8, 17, 343, DateTimeKind.Local).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 8, 17, 343, DateTimeKind.Local).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 8, 17, 343, DateTimeKind.Local).AddTicks(1342));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 8, 17, 343, DateTimeKind.Local).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 8, 17, 343, DateTimeKind.Local).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 8, 17, 343, DateTimeKind.Local).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 8, 17, 343, DateTimeKind.Local).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 8, 17, 343, DateTimeKind.Local).AddTicks(1348));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 8, 17, 343, DateTimeKind.Local).AddTicks(1349));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 11, 8, 17, 343, DateTimeKind.Local).AddTicks(1350));
        }
    }
}
