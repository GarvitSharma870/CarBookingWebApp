using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AvailableTime",
                table: "Cars",
                newName: "AvailabilityTo");

            migrationBuilder.AddColumn<DateTime>(
                name: "AvailabilityFrom",
                table: "Cars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "658f3e0c-8618-4643-8bf0-2e44f4495643", "AQAAAAIAAYagAAAAEG5ShD8z67A0OhAJ6o31Q04Hpy/qmTdnL3lCo0o2UaKGWWFh+qwSDpdYDcpyTgHzcg==", "8cf9bcc1-ef05-4608-a545-b84c4eb14fb1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf1fe34c-21dc-4a82-9981-f51b3f5b8149", "AQAAAAIAAYagAAAAEMB+5doRId8+hh7VQj8YH8Dc2MZBqyZrr7Ml+umn2shqGx0LYE5qf3tiTJgwE2Xrvg==", "388091b7-d281-422a-a414-f9375e228811" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 13, 19, 16, 998, DateTimeKind.Local).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 13, 19, 16, 998, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 13, 19, 16, 998, DateTimeKind.Local).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 13, 19, 16, 998, DateTimeKind.Local).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 13, 19, 16, 998, DateTimeKind.Local).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 13, 19, 16, 998, DateTimeKind.Local).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 13, 19, 16, 998, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 13, 19, 16, 998, DateTimeKind.Local).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 13, 19, 16, 998, DateTimeKind.Local).AddTicks(721));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 13, 19, 16, 998, DateTimeKind.Local).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 13, 19, 16, 999, DateTimeKind.Local).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 13, 19, 16, 999, DateTimeKind.Local).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 13, 19, 16, 999, DateTimeKind.Local).AddTicks(5445));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 13, 19, 16, 999, DateTimeKind.Local).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 13, 19, 16, 999, DateTimeKind.Local).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 13, 19, 16, 999, DateTimeKind.Local).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 13, 19, 16, 999, DateTimeKind.Local).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 13, 19, 16, 999, DateTimeKind.Local).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 13, 19, 16, 999, DateTimeKind.Local).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 13, 19, 16, 999, DateTimeKind.Local).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 13, 19, 16, 999, DateTimeKind.Local).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 13, 19, 16, 999, DateTimeKind.Local).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 13, 19, 16, 999, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 13, 19, 16, 999, DateTimeKind.Local).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 13, 19, 16, 999, DateTimeKind.Local).AddTicks(5465));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvailabilityFrom",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "AvailabilityTo",
                table: "Cars",
                newName: "AvailableTime");

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
    }
}
