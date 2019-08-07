using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Core_Entity_ToDoList_01.Migrations
{
    public partial class athleticsmeetings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AthleticsMeetings",
                columns: table => new
                {
                    AthleticsMeetingsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MeetingName = table.Column<string>(nullable: true),
                    MeetingLocation = table.Column<string>(nullable: true),
                    MeetingDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AthleticsMeetings", x => x.AthleticsMeetingsID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AthleticsMeetings");
        }
    }
}
