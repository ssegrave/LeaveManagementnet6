using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46c743da-ca3d-4f70-afa7-f189dbff4ba0",
                column: "ConcurrencyStamp",
                value: "ded85e5e-f70e-447d-915f-aed895306ef8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ca84589-4e6b-4f51-b598-ff541ecb40af",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "fb93b017-f84d-4d63-9881-dda47280dbc5", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c5311496-09bb-4e58-ad1a-ad2f5f52ce14",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "516183bb-10a0-4821-bf27-bf773c827340", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEMxX+AQBn6UIu6EVAmGeCCxqHkw/ZB3Fy0vYLJpOiPENS4nR372oiwJWFnqE9ksFNg==", "710cb9a8-81d6-4e79-b29f-df86044df621", "user@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e49865a3-78b1-4ea6-8936-20b2a9831938",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "cb06bf32-ce9d-4599-9762-834f936e4c96", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEGe2nX1NirSfM2fGcEw7sjwEc6xETS0kknG3oFT17kdpEg/Ei1Kf/ktPYKPIDLeOLg==", "cb215f23-b10f-4d0f-bcd1-1072a7db3e82", "admin@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46c743da-ca3d-4f70-afa7-f189dbff4ba0",
                column: "ConcurrencyStamp",
                value: "9c7564ff-5a03-48b6-9753-c1193124ce28");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ca84589-4e6b-4f51-b598-ff541ecb40af",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "0fef15e7-d0ca-4f8b-afe4-cd0b0978b81e", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c5311496-09bb-4e58-ad1a-ad2f5f52ce14",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "316507d6-0186-4a83-9f7e-8a552c018f19", false, null, "AQAAAAEAACcQAAAAEB6Gl4zEMDtLyo65fcZ3IG7adR79EIJWBZuKig/4JcrxhE7hN4Apxg2cDWLcKWfJqQ==", "72f478e7-073b-46df-bed4-06170ca36bca", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e49865a3-78b1-4ea6-8936-20b2a9831938",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c71e51c4-878c-48ec-81eb-039d01c30e44", false, null, "AQAAAAEAACcQAAAAEJnU/xAmHH2yFCRaQB2mjMvv8XLx4XocTUHIK19XnjfC3XBKJbOzBnoHRR6lqs6qJw==", "085d30c8-794e-4813-95cc-bacae6e35383", null });
        }
    }
}
