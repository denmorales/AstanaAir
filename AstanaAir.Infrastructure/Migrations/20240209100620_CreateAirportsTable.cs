using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AstanaAir.Infrastructure.Migrations
{
    public partial class CreateAirportsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Airports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Offset = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airports", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Airports",
                columns: new[] { "Id", "Code", "Name", "Offset" },
                values: new object[,]
                {
                    { 1, "VNK", "Внуково", (short)3 },
                    { 2, "EKB", "Екатеринбург", (short)5 },
                    { 3, "SRT", "Саратов", (short)4 },
                    { 4, "ALM", "Алматы", (short)6 },
                    { 5, "MGD", "Магадан", (short)11 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Airports");

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 8, 21, 48, 39, 11, DateTimeKind.Unspecified).AddTicks(4808), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 9, 9, 48, 39, 11, DateTimeKind.Unspecified).AddTicks(4833), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1001,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 8, 21, 48, 39, 11, DateTimeKind.Unspecified).AddTicks(4843), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 9, 9, 48, 39, 11, DateTimeKind.Unspecified).AddTicks(4844), new TimeSpan(0, 3, 0, 0, 0)) });

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
    }
}
