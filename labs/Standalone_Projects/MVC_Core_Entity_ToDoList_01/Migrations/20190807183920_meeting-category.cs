using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Core_Entity_ToDoList_01.Migrations
{
    public partial class meetingcategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MeetingCategoryID",
                table: "AthleticsMeetings",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MeetingCategory",
                columns: table => new
                {
                    MeetingCategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingCategory", x => x.MeetingCategoryID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AthleticsMeetings_MeetingCategoryID",
                table: "AthleticsMeetings",
                column: "MeetingCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_AthleticsMeetings_MeetingCategory_MeetingCategoryID",
                table: "AthleticsMeetings",
                column: "MeetingCategoryID",
                principalTable: "MeetingCategory",
                principalColumn: "MeetingCategoryID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AthleticsMeetings_MeetingCategory_MeetingCategoryID",
                table: "AthleticsMeetings");

            migrationBuilder.DropTable(
                name: "MeetingCategory");

            migrationBuilder.DropIndex(
                name: "IX_AthleticsMeetings_MeetingCategoryID",
                table: "AthleticsMeetings");

            migrationBuilder.DropColumn(
                name: "MeetingCategoryID",
                table: "AthleticsMeetings");
        }
    }
}
