using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Schv3.Migrations
{
    /// <inheritdoc />
    public partial class AddedGroupIdToSchedule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Group_idGroupCode",
                table: "Schedules",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_Group_idGroupCode",
                table: "Schedules",
                column: "Group_idGroupCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Groups_Group_idGroupCode",
                table: "Schedules",
                column: "Group_idGroupCode",
                principalTable: "Groups",
                principalColumn: "GroupCode",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Groups_Group_idGroupCode",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_Group_idGroupCode",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "Group_idGroupCode",
                table: "Schedules");
        }
    }
}
