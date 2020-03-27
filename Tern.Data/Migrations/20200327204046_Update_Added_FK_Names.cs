using Microsoft.EntityFrameworkCore.Migrations;

namespace Tern.Data.Migrations
{
    public partial class Update_Added_FK_Names : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Lists_ListId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Status_StatusId",
                table: "Tasks");

            migrationBuilder.AddForeignKey(
                name: "FK_List_ListId",
                table: "Tasks",
                column: "ListId",
                principalTable: "Lists",
                principalColumn: "ListId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Status_StatusId",
                table: "Tasks",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "StatusId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_List_ListId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Status_StatusId",
                table: "Tasks");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Lists_ListId",
                table: "Tasks",
                column: "ListId",
                principalTable: "Lists",
                principalColumn: "ListId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Status_StatusId",
                table: "Tasks",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "StatusId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
