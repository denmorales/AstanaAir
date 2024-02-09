using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AstanaAir.Infrastructure.Migrations
{
    public partial class AddDataToAirports_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 9, 14, 9, 44, 748, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 10, 2, 9, 44, 748, DateTimeKind.Unspecified).AddTicks(3741), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1001,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 9, 14, 9, 44, 748, DateTimeKind.Unspecified).AddTicks(3750), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 10, 2, 9, 44, 748, DateTimeKind.Unspecified).AddTicks(3751), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 9, 14, 9, 44, 748, DateTimeKind.Unspecified).AddTicks(3753), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 10, 6, 9, 44, 748, DateTimeKind.Unspecified).AddTicks(3754), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1003,
                columns: new[] { "Arrival", "Departure", "Destination" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 9, 14, 9, 44, 748, DateTimeKind.Unspecified).AddTicks(3755), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 9, 16, 9, 44, 748, DateTimeKind.Unspecified).AddTicks(3756), new TimeSpan(0, 3, 0, 0, 0)), "Алматы" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Hash", "Salt" },
                values: new object[] { "2113177F42C22FA0B7DAFA2A0386DAC5391752676B695C6DD0FB49684815854A047FCF4F028E92DECF971130899437F755420A07A5BE577EA4D87CE9447105EB", new byte[] { 28, 216, 180, 126, 231, 181, 173, 108, 242, 202, 52, 144, 13, 117, 207, 113, 37, 104, 135, 108, 222, 197, 190, 144, 61, 81, 74, 202, 171, 122, 88, 78, 70, 222, 0, 163, 241, 118, 170, 180, 118, 214, 78, 236, 158, 124, 74, 38, 176, 70, 204, 192, 251, 67, 59, 81, 213, 27, 46, 153, 81, 201, 52, 31 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Hash", "Salt" },
                values: new object[] { "8695581FE1348748FF4DC442FBCD26B02C2BE61AEE8CDE4F4131FE1AB4CE0D1C00F49ABA07C4ACE3BEE7899E2EA4FC38E146B1FC450DF4B6F549A487F3320614", new byte[] { 71, 56, 198, 162, 136, 73, 106, 112, 101, 232, 102, 174, 14, 252, 24, 129, 31, 138, 68, 149, 0, 172, 209, 254, 184, 61, 91, 207, 126, 118, 156, 4, 69, 127, 242, 60, 242, 25, 209, 183, 140, 2, 78, 232, 249, 186, 150, 175, 174, 43, 131, 140, 252, 46, 4, 3, 109, 72, 123, 102, 135, 100, 126, 48 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 9, 13, 15, 15, 127, DateTimeKind.Unspecified).AddTicks(1186), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 10, 1, 15, 15, 127, DateTimeKind.Unspecified).AddTicks(1211), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1001,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 9, 13, 15, 15, 127, DateTimeKind.Unspecified).AddTicks(1220), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 10, 1, 15, 15, 127, DateTimeKind.Unspecified).AddTicks(1221), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 9, 13, 15, 15, 127, DateTimeKind.Unspecified).AddTicks(1223), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 10, 5, 15, 15, 127, DateTimeKind.Unspecified).AddTicks(1223), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1003,
                columns: new[] { "Arrival", "Departure", "Destination" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 9, 13, 15, 15, 127, DateTimeKind.Unspecified).AddTicks(1224), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 9, 15, 15, 15, 127, DateTimeKind.Unspecified).AddTicks(1225), new TimeSpan(0, 3, 0, 0, 0)), "Астана" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Hash", "Salt" },
                values: new object[] { "D25155FF0A6E516CC453A58082BB365DBAFCBA0497EE95EDF9A8FD6D518EDC9E611E1F3AB921D8C482719B8643715E62405B9B750112D71462D1C699F8F46E88", new byte[] { 167, 80, 239, 146, 255, 30, 139, 159, 217, 238, 183, 214, 144, 228, 217, 33, 247, 252, 238, 196, 238, 214, 59, 134, 137, 171, 94, 136, 235, 124, 136, 239, 248, 133, 161, 138, 76, 4, 237, 18, 193, 103, 104, 28, 94, 135, 93, 186, 201, 58, 99, 57, 176, 110, 248, 163, 84, 103, 209, 46, 152, 239, 138, 137 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Hash", "Salt" },
                values: new object[] { "DE0188EDBF4ACB1D81ADCB6B11F6A97084A2B93249FA8373F14A60E2EBEF6481417AE5A6281F9035DF1B22C4696532080ABF21F51B3F59EA17EBFE16D0E6924D", new byte[] { 53, 178, 168, 62, 202, 65, 223, 94, 197, 216, 69, 101, 210, 74, 6, 89, 167, 240, 198, 149, 167, 80, 138, 136, 239, 11, 253, 10, 183, 3, 155, 8, 82, 49, 250, 31, 76, 235, 117, 152, 9, 151, 201, 146, 34, 77, 91, 71, 33, 255, 43, 177, 56, 194, 2, 87, 32, 221, 219, 47, 205, 232, 3, 161 } });
        }
    }
}
