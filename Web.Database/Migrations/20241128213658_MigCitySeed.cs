using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Database.Migrations
{
    /// <inheritdoc />
    public partial class MigCitySeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "dbo",
                table: "City",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "İstanbul" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "City",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
