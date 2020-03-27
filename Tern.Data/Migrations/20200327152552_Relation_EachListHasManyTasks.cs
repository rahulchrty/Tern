using Microsoft.EntityFrameworkCore.Migrations;

namespace Tern.Data.Migrations
{
    public partial class Relation_EachListHasManyTasks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ListId",
                table: "Tasks",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_ListId",
                table: "Tasks",
                column: "ListId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Lists_ListId",
                table: "Tasks",
                column: "ListId",
                principalTable: "Lists",
                principalColumn: "ListId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Lists_ListId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_ListId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "ListId",
                table: "Tasks");
        }
    }
}
