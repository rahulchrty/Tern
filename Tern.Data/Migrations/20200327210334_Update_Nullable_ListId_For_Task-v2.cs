using Microsoft.EntityFrameworkCore.Migrations;

namespace Tern.Data.Migrations
{
    public partial class Update_Nullable_ListId_For_Taskv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ListId",
                table: "Tasks",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ListId",
                table: "Tasks",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
