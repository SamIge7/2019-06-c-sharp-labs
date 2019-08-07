using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Core_Entity_ToDoList_01.Migrations
{
    public partial class linktables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Task",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Task_CategoryID",
                table: "Task",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Task_Category_CategoryID",
                table: "Task",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Task_Category_CategoryID",
                table: "Task");

            migrationBuilder.DropIndex(
                name: "IX_Task_CategoryID",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Task");
        }
    }
}
