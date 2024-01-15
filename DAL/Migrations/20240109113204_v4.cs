using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Cars",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae311760-df53-415d-87b7-413c39eeb0aa", "AQAAAAIAAYagAAAAEFU7AFBcWO/FDylb4K48GRLdB2n1qooRfgIr8DnRjJx4WPfdYGxdhwAiqe1oDYVXnw==", "17e9a1e9-ee77-4ce4-aaee-f0dba336224d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb64310a-f229-4808-8c80-582075cc228c", "AQAAAAIAAYagAAAAEL5dyW1sWViOc9tsNV6R8VtzG3Jl+qKDhAknBQkTrLERpi+f8t1LyydIbWH5hk3c0g==", "0ca774f5-b35d-412a-820d-9234439b2546" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 17, 2, 2, 917, DateTimeKind.Local).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 17, 2, 2, 917, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 17, 2, 2, 917, DateTimeKind.Local).AddTicks(2893));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 17, 2, 2, 917, DateTimeKind.Local).AddTicks(2896));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 17, 2, 2, 917, DateTimeKind.Local).AddTicks(2898));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 17, 2, 2, 917, DateTimeKind.Local).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 17, 2, 2, 917, DateTimeKind.Local).AddTicks(2903));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 17, 2, 2, 917, DateTimeKind.Local).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 17, 2, 2, 917, DateTimeKind.Local).AddTicks(2908));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 17, 2, 2, 917, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 17, 2, 2, 920, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 17, 2, 2, 920, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 17, 2, 2, 920, DateTimeKind.Local).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 17, 2, 2, 920, DateTimeKind.Local).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 17, 2, 2, 920, DateTimeKind.Local).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 17, 2, 2, 920, DateTimeKind.Local).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 17, 2, 2, 920, DateTimeKind.Local).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 17, 2, 2, 920, DateTimeKind.Local).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 17, 2, 2, 920, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 17, 2, 2, 920, DateTimeKind.Local).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 17, 2, 2, 920, DateTimeKind.Local).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 17, 2, 2, 920, DateTimeKind.Local).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 17, 2, 2, 920, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 17, 2, 2, 920, DateTimeKind.Local).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 17, 2, 2, 920, DateTimeKind.Local).AddTicks(918));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Cars");

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
    }
}
