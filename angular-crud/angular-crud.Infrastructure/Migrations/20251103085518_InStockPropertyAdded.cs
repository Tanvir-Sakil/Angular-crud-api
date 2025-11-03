using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace angular_crud.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InStockPropertyAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "inStock",
                table: "Items",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "inStock",
                table: "Items");
        }
    }
}
