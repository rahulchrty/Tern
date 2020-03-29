using Microsoft.EntityFrameworkCore.Migrations;

namespace Tern.Data.Migrations
{
    public partial class SubTask_Remove_Descriptionv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubTasks_Tasks_FK_Task_TaskId",
                table: "SubTasks");

            migrationBuilder.DropIndex(
                name: "IX_SubTasks_FK_Task_TaskId",
                table: "SubTasks");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "SubTasks");

            migrationBuilder.DropColumn(
                name: "FK_Task_TaskId",
                table: "SubTasks");

            migrationBuilder.CreateIndex(
                name: "IX_SubTasks_TaskId",
                table: "SubTasks",
                column: "TaskId");

            migrationBuilder.AddForeignKey(
                name: "FK_Task_TaskId",
                table: "SubTasks",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "TaskId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Task_TaskId",
                table: "SubTasks");

            migrationBuilder.DropIndex(
                name: "IX_SubTasks_TaskId",
                table: "SubTasks");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "SubTasks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FK_Task_TaskId",
                table: "SubTasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SubTasks_FK_Task_TaskId",
                table: "SubTasks",
                column: "FK_Task_TaskId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubTasks_Tasks_FK_Task_TaskId",
                table: "SubTasks",
                column: "FK_Task_TaskId",
                principalTable: "Tasks",
                principalColumn: "TaskId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
