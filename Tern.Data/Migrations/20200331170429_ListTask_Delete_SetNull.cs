using Microsoft.EntityFrameworkCore.Migrations;

namespace Tern.Data.Migrations
{
    public partial class ListTask_Delete_SetNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_List_ListId",
                table: "Tasks");

            migrationBuilder.AddForeignKey(
                name: "FK_List_ListId",
                table: "Tasks",
                column: "ListId",
                principalTable: "Lists",
                principalColumn: "ListId",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_List_ListId",
                table: "Tasks");

            migrationBuilder.AddForeignKey(
                name: "FK_List_ListId",
                table: "Tasks",
                column: "ListId",
                principalTable: "Lists",
                principalColumn: "ListId");
        }
    }
}
