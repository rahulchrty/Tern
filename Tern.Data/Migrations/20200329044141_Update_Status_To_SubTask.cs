using Microsoft.EntityFrameworkCore.Migrations;

namespace Tern.Data.Migrations
{
    public partial class Update_Status_To_SubTask : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Status_StatusId",
                table: "Tasks");

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "SubTasks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SubTasks_StatusId",
                table: "SubTasks",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Status_SubTask_StatusId",
                table: "SubTasks",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Status_Task_StatusId",
                table: "Tasks",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "StatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Status_SubTask_StatusId",
                table: "SubTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Status_Task_StatusId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_SubTasks_StatusId",
                table: "SubTasks");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "SubTasks");

            migrationBuilder.AddForeignKey(
                name: "FK_Status_StatusId",
                table: "Tasks",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "StatusId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
