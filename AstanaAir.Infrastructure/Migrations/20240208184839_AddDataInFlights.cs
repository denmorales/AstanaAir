using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AstanaAir.Infrastructure.Migrations
{
    public partial class AddDataInFlights : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "Arrival", "Departure", "Destination", "Origin", "Status" },
                values: new object[,]
                {
                    { 1000, new DateTimeOffset(new DateTime(2024, 2, 8, 21, 48, 39, 11, DateTimeKind.Unspecified).AddTicks(4808), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 9, 9, 48, 39, 11, DateTimeKind.Unspecified).AddTicks(4833), new TimeSpan(0, 3, 0, 0, 0)), "Аэропорт2", "Аэропорт1", "InTime" },
                    { 1001, new DateTimeOffset(new DateTime(2024, 2, 8, 21, 48, 39, 11, DateTimeKind.Unspecified).AddTicks(4843), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 9, 9, 48, 39, 11, DateTimeKind.Unspecified).AddTicks(4844), new TimeSpan(0, 3, 0, 0, 0)), "Аэропорт4", "Аэропорт3", "Cancelled" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Hash", "Salt" },
                values: new object[] { "3E47526631F5D3119446D6547C8E04061A85A14AD253EAEE2289AF421880D1248A343C48892C46065DB5E6A7D9AB80BD79A05673DBEECFB3D4BDCB9D1B225C44", new byte[] { 55, 58, 240, 164, 181, 135, 94, 59, 39, 190, 65, 20, 183, 117, 205, 50, 14, 141, 45, 36, 115, 49, 39, 52, 247, 52, 141, 0, 194, 224, 240, 236, 41, 90, 187, 88, 160, 188, 99, 47, 41, 124, 165, 58, 118, 193, 81, 182, 225, 1, 45, 64, 115, 107, 164, 244, 39, 180, 236, 68, 160, 32, 101, 227 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Hash", "Salt" },
                values: new object[] { "D8E2F7EB9088CB4CA995E23A165ED1AB19A07B034DD5BA5DC48B9B3CB044D76D7FC11D5E7ED5286C79579B95620D35C82108FFE2B955B7B0A149477A4935A32A", new byte[] { 164, 163, 156, 234, 31, 42, 162, 154, 5, 93, 179, 223, 216, 58, 76, 199, 39, 12, 0, 242, 107, 125, 152, 14, 181, 179, 65, 253, 167, 21, 185, 124, 142, 124, 213, 78, 35, 57, 66, 18, 6, 81, 120, 228, 228, 233, 40, 176, 106, 89, 126, 249, 210, 165, 193, 70, 98, 118, 45, 127, 33, 69, 130, 132 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1001);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Hash", "Salt" },
                values: new object[] { "69D5BC1EE68A756C8884D676BE1AD4DDAC993D96201942481B9B0B31BD2008D6D0080EAB4F3A0DF85622656A35F0F3D8568AF3E2678D29ACC1A3A3CE9EDE3B4A", new byte[] { 208, 227, 116, 237, 165, 244, 165, 26, 159, 31, 248, 3, 209, 125, 105, 4, 155, 245, 142, 0, 159, 170, 223, 52, 207, 102, 209, 232, 133, 45, 124, 63, 13, 44, 39, 30, 218, 9, 217, 39, 94, 104, 54, 35, 179, 237, 36, 158, 67, 66, 71, 105, 197, 251, 164, 58, 161, 147, 222, 10, 199, 178, 6, 194 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Hash", "Salt" },
                values: new object[] { "D5E3193D9D2CC38BE1DFC6857D3AE88CF58A76D13B64429D4D37382B27515C78E1D89F5E714057823DBBC0058ABDE87FD5B97E8544A68F8D34469513B7BE433D", new byte[] { 133, 224, 134, 34, 0, 185, 149, 180, 189, 168, 177, 108, 248, 160, 109, 27, 173, 151, 101, 189, 222, 3, 223, 225, 205, 0, 143, 171, 98, 205, 132, 215, 105, 124, 214, 71, 116, 132, 247, 66, 100, 75, 216, 222, 213, 185, 21, 50, 226, 84, 181, 89, 207, 0, 82, 68, 95, 175, 92, 98, 92, 218, 114, 207 } });
        }
    }
}
