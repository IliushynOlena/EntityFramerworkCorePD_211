using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramerworkCorePD_211.Migrations
{
    /// <inheritdoc />
    public partial class AddRating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Flights",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Number",
                keyValue: 1,
                column: "Rating",
                value: null);

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Number",
                keyValue: 2,
                column: "Rating",
                value: null);

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Number",
                keyValue: 3,
                column: "Rating",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Flights");
        }
    }
}
