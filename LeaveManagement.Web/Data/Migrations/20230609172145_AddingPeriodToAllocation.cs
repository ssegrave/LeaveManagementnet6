using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46c743da-ca3d-4f70-afa7-f189dbff4ba0",
                column: "ConcurrencyStamp",
                value: "75ee8172-3358-4449-a019-b0c7854d5bc1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ca84589-4e6b-4f51-b598-ff541ecb40af",
                column: "ConcurrencyStamp",
                value: "8d93fe83-9914-4d82-a645-f2a56db1d869");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c5311496-09bb-4e58-ad1a-ad2f5f52ce14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81b74942-abac-42e8-a2a2-d3501f468b40", "AQAAAAEAACcQAAAAEH5b6dkj2lxUoXPpUvchfsdwpwuSRpGNfEj/fWC5u1rtTQXlmMgojjXQFRlfHKZO5Q==", "a0b40b78-3e37-4e65-a383-fa5ce8441a59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e49865a3-78b1-4ea6-8936-20b2a9831938",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0ed27fb-47d4-41de-a896-af1822d24e71", "AQAAAAEAACcQAAAAEJeuNl5Q7rSNHO8Kw8i25DJZOspJZHlP02rokaaPN4b+09rhqRURt1y/8JRNDuMQPg==", "a95a7400-3290-436e-8e73-322b0ae224d8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                column: "ConcurrencyStamp",
                value: "fb93b017-f84d-4d63-9881-dda47280dbc5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c5311496-09bb-4e58-ad1a-ad2f5f52ce14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "516183bb-10a0-4821-bf27-bf773c827340", "AQAAAAEAACcQAAAAEMxX+AQBn6UIu6EVAmGeCCxqHkw/ZB3Fy0vYLJpOiPENS4nR372oiwJWFnqE9ksFNg==", "710cb9a8-81d6-4e79-b29f-df86044df621" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e49865a3-78b1-4ea6-8936-20b2a9831938",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb06bf32-ce9d-4599-9762-834f936e4c96", "AQAAAAEAACcQAAAAEGe2nX1NirSfM2fGcEw7sjwEc6xETS0kknG3oFT17kdpEg/Ei1Kf/ktPYKPIDLeOLg==", "cb215f23-b10f-4d0f-bcd1-1072a7db3e82" });
        }
    }
}
