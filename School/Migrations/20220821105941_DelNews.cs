using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School.Migrations
{
    public partial class DelNews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SchoolNews");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "719b00a8-062b-4848-967e-b85a6cdb9d51");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7cda2e5-f323-489c-b61f-1e3640a35ee3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5588bae-2fd6-48f8-a228-497beb9fa4fb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "377420b3-aeb3-4c7a-b80f-73adb9769d9e", "b7cc1f8f-863b-4540-ad34-a18ccb45ceda" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "377420b3-aeb3-4c7a-b80f-73adb9769d9e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b7cc1f8f-863b-4540-ad34-a18ccb45ceda");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "117eca69-3b3e-4674-8cf9-ae8d3a3269bd", "4", "Parent", "PARENT" },
                    { "161c63a6-0607-49cb-b1d0-764b1c070954", "1", "Admin", "ADMIN" },
                    { "537a1147-6926-4720-9dcd-9900e684aee9", "3", "Pupil", "PUPIL" },
                    { "8a0ae399-8789-41bf-8741-20e3a0f8d3f1", "2", "Teacher", "TEACHER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a8586721-a94a-4190-9a2e-1ea9fee86485", 0, "avadvd", "admin@gmail.com", true, "Admin", "Adminov", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEPX/vR4pII/iu8RFSEMWT2LJb7R+d5ocppDyE1WgdLfcW5uwp5CPFNFEDTCdoRzl0w==", "1234567890", false, "avebgdfvs", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "161c63a6-0607-49cb-b1d0-764b1c070954", "a8586721-a94a-4190-9a2e-1ea9fee86485" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "117eca69-3b3e-4674-8cf9-ae8d3a3269bd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "537a1147-6926-4720-9dcd-9900e684aee9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a0ae399-8789-41bf-8741-20e3a0f8d3f1");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "161c63a6-0607-49cb-b1d0-764b1c070954", "a8586721-a94a-4190-9a2e-1ea9fee86485" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "161c63a6-0607-49cb-b1d0-764b1c070954");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8586721-a94a-4190-9a2e-1ea9fee86485");

            migrationBuilder.CreateTable(
                name: "SchoolNews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CretedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NewsName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewsText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PathIcon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolNews", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "377420b3-aeb3-4c7a-b80f-73adb9769d9e", "1", "Admin", "ADMIN" },
                    { "719b00a8-062b-4848-967e-b85a6cdb9d51", "4", "Parent", "PARENT" },
                    { "b7cda2e5-f323-489c-b61f-1e3640a35ee3", "2", "Teacher", "TEACHER" },
                    { "c5588bae-2fd6-48f8-a228-497beb9fa4fb", "3", "Pupil", "PUPIL" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b7cc1f8f-863b-4540-ad34-a18ccb45ceda", 0, "avadvd", "admin@gmail.com", true, "Admin", "Adminov", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEBjQBgx1+g57aawaFFN7T7rw3yjxolQ/1sMieHay6eU5RP7pKcXy9p+/4Je2i1KNBw==", "1234567890", false, "avebgdfvs", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "377420b3-aeb3-4c7a-b80f-73adb9769d9e", "b7cc1f8f-863b-4540-ad34-a18ccb45ceda" });
        }
    }
}
