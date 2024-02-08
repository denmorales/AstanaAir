using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AstanaAir.Infrastructure.Migrations
{
    public partial class AlterUsersRemovePasswordAddHashAddSalt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "Hash");

            migrationBuilder.AddColumn<byte[]>(
                name: "Salt",
                table: "Users",
                type: "bytea",
                nullable: false,
                defaultValue: new byte[0]);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salt",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Hash",
                table: "Users",
                newName: "Password");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "pass1");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "pass2");
        }
    }
}
