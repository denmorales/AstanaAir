using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AstanaAir.Infrastructure.Migrations
{
    public partial class AddDataToAirports : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "Arrival", "Departure", "Destination", "Origin", "Status" },
                values: new object[,]
                {
                    { 1002, new DateTimeOffset(new DateTime(2024, 2, 9, 13, 15, 15, 127, DateTimeKind.Unspecified).AddTicks(1223), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 10, 5, 15, 15, 127, DateTimeKind.Unspecified).AddTicks(1223), new TimeSpan(0, 3, 0, 0, 0)), "Магадан", "Внуково", "InTime" },
                    { 1003, new DateTimeOffset(new DateTime(2024, 2, 9, 13, 15, 15, 127, DateTimeKind.Unspecified).AddTicks(1224), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 9, 15, 15, 15, 127, DateTimeKind.Unspecified).AddTicks(1225), new TimeSpan(0, 3, 0, 0, 0)), "Астана", "Екатеринбург", "InTime" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1003);

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 9, 13, 6, 20, 661, DateTimeKind.Unspecified).AddTicks(5693), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 10, 1, 6, 20, 661, DateTimeKind.Unspecified).AddTicks(5720), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1001,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 9, 13, 6, 20, 661, DateTimeKind.Unspecified).AddTicks(5731), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 10, 1, 6, 20, 661, DateTimeKind.Unspecified).AddTicks(5732), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Hash", "Salt" },
                values: new object[] { "929E3998E77C0626C0FA4BCA88305DAEE7F874E52DF367A34BE3FA80DC0E6844869B4DCE6EE73FF9B6654ECD826AB12951054B4EDB9BA074C6DBD0709F77344C", new byte[] { 175, 186, 81, 95, 139, 85, 40, 73, 86, 91, 111, 105, 251, 32, 0, 32, 141, 210, 182, 234, 98, 66, 203, 217, 19, 120, 73, 240, 223, 212, 54, 1, 85, 57, 64, 236, 134, 141, 195, 24, 81, 85, 10, 78, 69, 217, 95, 200, 181, 246, 102, 127, 246, 246, 177, 210, 12, 103, 92, 38, 182, 41, 230, 112 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Hash", "Salt" },
                values: new object[] { "C153B0CBEF7746F4C24E3DD9E8761F80AD0BEBBACE93731A7FADF60C2EFAF744C5875D2DC4C1F35A8B4EC6241528A8C7BF70B88F7107685CF7AA7E0D2BFDE827", new byte[] { 220, 249, 165, 150, 125, 41, 140, 4, 77, 28, 154, 199, 161, 106, 57, 125, 234, 238, 250, 21, 61, 145, 234, 24, 231, 77, 165, 40, 213, 176, 210, 194, 115, 254, 214, 181, 17, 241, 240, 39, 10, 102, 67, 36, 39, 37, 28, 18, 100, 216, 142, 249, 91, 119, 139, 40, 24, 70, 2, 238, 120, 242, 106, 240 } });
        }
    }
}
