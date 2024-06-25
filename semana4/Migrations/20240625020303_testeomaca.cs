using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace semana4.Migrations
{
    /// <inheritdoc />
    public partial class testeomaca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83a341f2-3c8d-4c1a-8366-36e0fd96732e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc63ac26-99a5-4908-90b5-a0e6e200d50d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2324d9d2-db82-45b5-a3bc-cd10b1313c77", null, "User", "USER" },
                    { "f6ee64c0-bf2c-4359-9532-cc2e2b339bb1", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2324d9d2-db82-45b5-a3bc-cd10b1313c77");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6ee64c0-bf2c-4359-9532-cc2e2b339bb1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "83a341f2-3c8d-4c1a-8366-36e0fd96732e", null, "Admin", "ADMIN" },
                    { "fc63ac26-99a5-4908-90b5-a0e6e200d50d", null, "User", "USER" }
                });
        }
    }
}
