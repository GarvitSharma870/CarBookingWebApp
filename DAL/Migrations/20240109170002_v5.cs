using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class v5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BookingFrom",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "BookingTo",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "842a9936-a2d1-4db6-8b6d-4a0bec44c282", "AQAAAAIAAYagAAAAEJwxEK5VpBNGe4OgiJopoxGU7vOR4T4aHek1KO0WSDEel4kLPD3W87mrDL0fx0jcRw==", "cedec27f-931e-4267-aa2d-20198b424043" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3364f3d-368d-409d-98d9-042134daeeb3", "AQAAAAIAAYagAAAAEK6uXrCPPD1MCSfrB6GijEzsoZrUM7xU9gWjHgQEAD0fdlROUmmd0NXrWhJYZGSw1g==", "c64fc847-e40e-4586-94c0-1ebab88c8ff0" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 22, 30, 2, 196, DateTimeKind.Local).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 22, 30, 2, 196, DateTimeKind.Local).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 22, 30, 2, 196, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 22, 30, 2, 196, DateTimeKind.Local).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 22, 30, 2, 196, DateTimeKind.Local).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 22, 30, 2, 196, DateTimeKind.Local).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 22, 30, 2, 196, DateTimeKind.Local).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 22, 30, 2, 196, DateTimeKind.Local).AddTicks(6403));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 22, 30, 2, 196, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 22, 30, 2, 196, DateTimeKind.Local).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 22, 30, 2, 198, DateTimeKind.Local).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 22, 30, 2, 198, DateTimeKind.Local).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 22, 30, 2, 198, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 22, 30, 2, 198, DateTimeKind.Local).AddTicks(853));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 22, 30, 2, 198, DateTimeKind.Local).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 22, 30, 2, 198, DateTimeKind.Local).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 22, 30, 2, 198, DateTimeKind.Local).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 22, 30, 2, 198, DateTimeKind.Local).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 22, 30, 2, 198, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 22, 30, 2, 198, DateTimeKind.Local).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 22, 30, 2, 198, DateTimeKind.Local).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 22, 30, 2, 198, DateTimeKind.Local).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 22, 30, 2, 198, DateTimeKind.Local).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 22, 30, 2, 198, DateTimeKind.Local).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2024, 1, 9, 22, 30, 2, 198, DateTimeKind.Local).AddTicks(883));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookingFrom",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "BookingTo",
                table: "Bookings");

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
    }
}
