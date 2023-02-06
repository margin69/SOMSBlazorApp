using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SOMSBlazorApp.Server.Migrations
{
    public partial class FKcreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ElementId",
                schema: "dbo",
                table: "Window",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WindowId",
                schema: "dbo",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Window_ElementId",
                schema: "dbo",
                table: "Window",
                column: "ElementId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_WindowId",
                schema: "dbo",
                table: "Order",
                column: "WindowId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Window_WindowId",
                schema: "dbo",
                table: "Order",
                column: "WindowId",
                principalSchema: "dbo",
                principalTable: "Window",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Window_Element_ElementId",
                schema: "dbo",
                table: "Window",
                column: "ElementId",
                principalSchema: "dbo",
                principalTable: "Element",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Window_WindowId",
                schema: "dbo",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Window_Element_ElementId",
                schema: "dbo",
                table: "Window");

            migrationBuilder.DropIndex(
                name: "IX_Window_ElementId",
                schema: "dbo",
                table: "Window");

            migrationBuilder.DropIndex(
                name: "IX_Order_WindowId",
                schema: "dbo",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "ElementId",
                schema: "dbo",
                table: "Window");

            migrationBuilder.DropColumn(
                name: "WindowId",
                schema: "dbo",
                table: "Order");
        }
    }
}
