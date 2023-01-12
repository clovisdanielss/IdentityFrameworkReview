using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ComandaZap.Migrations
{
    /// <inheritdoc />
    public partial class NewRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a612b3fd-ab04-4df3-bca2-6540b9604430");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a71f6549-8091-4027-a9f4-3f79c23e2f77");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8d588bf6-c6ee-45ae-9d1a-a0711db9bbc4", null, "Customer", null },
                    { "fbca6623-5544-46ef-9b46-88190fa2f7df", null, "ApplicationOwner", null },
                    { "ff6ae8c9-f5aa-4186-aa99-c5bdd5763443", null, "Company", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d588bf6-c6ee-45ae-9d1a-a0711db9bbc4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fbca6623-5544-46ef-9b46-88190fa2f7df");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff6ae8c9-f5aa-4186-aa99-c5bdd5763443");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a612b3fd-ab04-4df3-bca2-6540b9604430", null, "Company", null },
                    { "a71f6549-8091-4027-a9f4-3f79c23e2f77", null, "Customer", null }
                });
        }
    }
}
