using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AstanaAir.Infrastructure.Migrations
{
    public partial class ChangeContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 9, 15, 56, 31, 768, DateTimeKind.Unspecified).AddTicks(1697), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 10, 3, 56, 31, 768, DateTimeKind.Unspecified).AddTicks(1723), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1001,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 9, 15, 56, 31, 768, DateTimeKind.Unspecified).AddTicks(1734), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 10, 3, 56, 31, 768, DateTimeKind.Unspecified).AddTicks(1735), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 9, 15, 56, 31, 768, DateTimeKind.Unspecified).AddTicks(1737), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 10, 7, 56, 31, 768, DateTimeKind.Unspecified).AddTicks(1737), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1003,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 9, 15, 56, 31, 768, DateTimeKind.Unspecified).AddTicks(1739), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 9, 17, 56, 31, 768, DateTimeKind.Unspecified).AddTicks(1739), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Hash", "Salt" },
                values: new object[] { "3B95F0CF766513ECBBCA7870E753B8019A93787FB40415B26C2EBCAED07723281087970F332EEB9DC625151840A92547CE51A55C6F68D2F1865D5033D3CE276C", new byte[] { 205, 72, 112, 252, 58, 227, 158, 112, 11, 254, 121, 105, 195, 236, 103, 248, 20, 212, 94, 181, 179, 140, 246, 113, 44, 55, 79, 87, 102, 235, 171, 154, 77, 0, 55, 50, 140, 207, 246, 213, 108, 243, 153, 3, 238, 57, 200, 72, 163, 251, 243, 2, 141, 138, 68, 157, 228, 156, 226, 186, 195, 109, 248, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Hash", "Salt" },
                values: new object[] { "00EB51B68787DFCCF321DECC440FCABC95E10D6805C4A2C60D8913C92BB891C0739642E395275B19A234D18D595A05DDFB2B7DF2AB0DFA552064A0D1F153373C", new byte[] { 247, 14, 130, 84, 133, 167, 156, 85, 14, 151, 58, 30, 30, 195, 13, 184, 213, 192, 242, 135, 69, 209, 210, 38, 228, 190, 62, 236, 157, 227, 136, 73, 237, 216, 37, 160, 162, 141, 64, 66, 99, 73, 79, 182, 13, 135, 96, 68, 164, 121, 253, 176, 216, 181, 50, 245, 193, 219, 94, 234, 0, 20, 226, 102 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 9, 14, 9, 44, 748, DateTimeKind.Unspecified).AddTicks(3755), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 9, 16, 9, 44, 748, DateTimeKind.Unspecified).AddTicks(3756), new TimeSpan(0, 3, 0, 0, 0)) });

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
    }
}
