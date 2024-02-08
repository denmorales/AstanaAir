using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AstanaAir.Infrastructure.Migrations
{
    public partial class AlterUsersAlterFlightAlterRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "character varying(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Roles",
                type: "character varying(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Origin",
                table: "Flights",
                type: "character varying(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Destination",
                table: "Flights",
                type: "character varying(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

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

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Code",
                table: "Roles",
                column: "Code",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_UserName",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Roles_Code",
                table: "Roles");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Roles",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "Origin",
                table: "Flights",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "Destination",
                table: "Flights",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(256)",
                oldMaxLength: 256);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Hash", "Salt" },
                values: new object[] { "9D93F5BF540C13024D5F162B121B1B2683EBEBEA93F59CCCDF1ACB0935975481FDA9037B1F9F44080DBC32666A39E1C83BFF9ADA776E7A6D6C8FBFB10C10853A", new byte[] { 169, 31, 44, 94, 7, 136, 31, 50, 212, 153, 147, 111, 171, 36, 114, 200, 145, 105, 153, 94, 19, 175, 170, 120, 246, 45, 122, 58, 60, 62, 134, 134, 208, 212, 243, 43, 123, 109, 102, 28, 238, 112, 107, 213, 83, 244, 34, 118, 55, 214, 214, 44, 237, 73, 183, 64, 191, 26, 234, 25, 93, 117, 71, 135 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Hash", "Salt" },
                values: new object[] { "5DEBAD4B96E1C84F66A3966295531734A0DE58015876CA67F34D20D443504C6E7B6D89D2C0FF50D831C5CF6220F5323514813307AF97BD5F4C047B34573C9AFF", new byte[] { 241, 179, 55, 28, 171, 129, 200, 209, 37, 126, 253, 79, 63, 254, 253, 220, 238, 200, 98, 204, 74, 201, 254, 187, 198, 84, 217, 166, 249, 3, 238, 144, 139, 237, 162, 26, 213, 144, 91, 219, 218, 120, 166, 251, 220, 188, 28, 90, 190, 88, 114, 125, 111, 47, 224, 106, 9, 136, 22, 10, 142, 47, 137, 83 } });
        }
    }
}
