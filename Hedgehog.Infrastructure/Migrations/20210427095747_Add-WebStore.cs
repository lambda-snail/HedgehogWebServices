using Microsoft.EntityFrameworkCore.Migrations;

namespace Hedgehog.Infrastructure.Migrations
{
    public partial class AddWebStore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NavigationTitle",
                table: "WebStore",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WebStore_NavigationTitle",
                table: "WebStore",
                column: "NavigationTitle",
                unique: true,
                filter: "[NavigationTitle] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_WebStore_NavigationTitle",
                table: "WebStore");

            migrationBuilder.DropColumn(
                name: "NavigationTitle",
                table: "WebStore");
        }
    }
}
