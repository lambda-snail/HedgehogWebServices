using Microsoft.EntityFrameworkCore.Migrations;

namespace Hedgehog.Infrastructure.Migrations
{
    public partial class WebStoreDescriptionAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StoreDescription",
                table: "WebStore",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StoreDescription",
                table: "WebStore");
        }
    }
}
