using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "46c743da-ca3d-4f70-afa7-f189dbff4ba0", "9c7564ff-5a03-48b6-9753-c1193124ce28", "Administrator", "ADMINISTRATOR" },
                    { "4ca84589-4e6b-4f51-b598-ff541ecb40af", "0fef15e7-d0ca-4f8b-afe4-cd0b0978b81e", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "c5311496-09bb-4e58-ad1a-ad2f5f52ce14", 0, "316507d6-0186-4a83-9f7e-8a552c018f19", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "Sytem", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEB6Gl4zEMDtLyo65fcZ3IG7adR79EIJWBZuKig/4JcrxhE7hN4Apxg2cDWLcKWfJqQ==", null, false, "72f478e7-073b-46df-bed4-06170ca36bca", null, false, null },
                    { "e49865a3-78b1-4ea6-8936-20b2a9831938", 0, "c71e51c4-878c-48ec-81eb-039d01c30e44", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "Sytem", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEJnU/xAmHH2yFCRaQB2mjMvv8XLx4XocTUHIK19XnjfC3XBKJbOzBnoHRR6lqs6qJw==", null, false, "085d30c8-794e-4813-95cc-bacae6e35383", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4ca84589-4e6b-4f51-b598-ff541ecb40af", "c5311496-09bb-4e58-ad1a-ad2f5f52ce14" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "46c743da-ca3d-4f70-afa7-f189dbff4ba0", "e49865a3-78b1-4ea6-8936-20b2a9831938" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4ca84589-4e6b-4f51-b598-ff541ecb40af", "c5311496-09bb-4e58-ad1a-ad2f5f52ce14" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "46c743da-ca3d-4f70-afa7-f189dbff4ba0", "e49865a3-78b1-4ea6-8936-20b2a9831938" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46c743da-ca3d-4f70-afa7-f189dbff4ba0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ca84589-4e6b-4f51-b598-ff541ecb40af");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c5311496-09bb-4e58-ad1a-ad2f5f52ce14");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e49865a3-78b1-4ea6-8936-20b2a9831938");
        }
    }
}
