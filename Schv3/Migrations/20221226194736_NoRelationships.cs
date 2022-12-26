using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Schv3.Migrations
{
    /// <inheritdoc />
    public partial class NoRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Groups_Group_CodeGroupCode",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Subjects_Id_SubjectId",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Teachers_Id_TeacherId",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Classes_Id_1ClassId",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Classes_Id_2ClassId",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Classes_Id_3ClassId",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Classes_Id_4ClassId",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Classes_Id_5ClassId",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Classes_Id_6ClassId",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Classes_Id_7ClassId",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Classes_Id_8ClassId",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Groups_Group_idGroupCode",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Teachers_Id_teacherId",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_Id_teacherId",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_Group_idGroupCode",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_Id_1ClassId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_Id_2ClassId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_Id_3ClassId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_Id_4ClassId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_Id_5ClassId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_Id_6ClassId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_Id_7ClassId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_Id_8ClassId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Classes_Group_CodeGroupCode",
                table: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Classes_Id_SubjectId",
                table: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Classes_Id_TeacherId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "Group_idGroupCode",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "Group_CodeGroupCode",
                table: "Classes");

            migrationBuilder.RenameColumn(
                name: "Id_teacherId",
                table: "Subjects",
                newName: "Id_teacher");

            migrationBuilder.RenameColumn(
                name: "Id_8ClassId",
                table: "Schedules",
                newName: "Id_8Class");

            migrationBuilder.RenameColumn(
                name: "Id_7ClassId",
                table: "Schedules",
                newName: "Id_7Class");

            migrationBuilder.RenameColumn(
                name: "Id_6ClassId",
                table: "Schedules",
                newName: "Id_6Class");

            migrationBuilder.RenameColumn(
                name: "Id_5ClassId",
                table: "Schedules",
                newName: "Id_5Class");

            migrationBuilder.RenameColumn(
                name: "Id_4ClassId",
                table: "Schedules",
                newName: "Id_4Class");

            migrationBuilder.RenameColumn(
                name: "Id_3ClassId",
                table: "Schedules",
                newName: "Id_3Class");

            migrationBuilder.RenameColumn(
                name: "Id_2ClassId",
                table: "Schedules",
                newName: "Id_2Class");

            migrationBuilder.RenameColumn(
                name: "Id_1ClassId",
                table: "Schedules",
                newName: "Id_1Class");

            migrationBuilder.RenameColumn(
                name: "Id_TeacherId",
                table: "Classes",
                newName: "Id_Teacher");

            migrationBuilder.RenameColumn(
                name: "Id_SubjectId",
                table: "Classes",
                newName: "Id_Subject");

            migrationBuilder.AddColumn<int>(
                name: "Group_id",
                table: "Schedules",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Group_Code",
                table: "Classes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Group_id",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "Group_Code",
                table: "Classes");

            migrationBuilder.RenameColumn(
                name: "Id_teacher",
                table: "Subjects",
                newName: "Id_teacherId");

            migrationBuilder.RenameColumn(
                name: "Id_8Class",
                table: "Schedules",
                newName: "Id_8ClassId");

            migrationBuilder.RenameColumn(
                name: "Id_7Class",
                table: "Schedules",
                newName: "Id_7ClassId");

            migrationBuilder.RenameColumn(
                name: "Id_6Class",
                table: "Schedules",
                newName: "Id_6ClassId");

            migrationBuilder.RenameColumn(
                name: "Id_5Class",
                table: "Schedules",
                newName: "Id_5ClassId");

            migrationBuilder.RenameColumn(
                name: "Id_4Class",
                table: "Schedules",
                newName: "Id_4ClassId");

            migrationBuilder.RenameColumn(
                name: "Id_3Class",
                table: "Schedules",
                newName: "Id_3ClassId");

            migrationBuilder.RenameColumn(
                name: "Id_2Class",
                table: "Schedules",
                newName: "Id_2ClassId");

            migrationBuilder.RenameColumn(
                name: "Id_1Class",
                table: "Schedules",
                newName: "Id_1ClassId");

            migrationBuilder.RenameColumn(
                name: "Id_Teacher",
                table: "Classes",
                newName: "Id_TeacherId");

            migrationBuilder.RenameColumn(
                name: "Id_Subject",
                table: "Classes",
                newName: "Id_SubjectId");

            migrationBuilder.AddColumn<string>(
                name: "Group_idGroupCode",
                table: "Schedules",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Group_CodeGroupCode",
                table: "Classes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_Id_teacherId",
                table: "Subjects",
                column: "Id_teacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_Group_idGroupCode",
                table: "Schedules",
                column: "Group_idGroupCode");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_Id_1ClassId",
                table: "Schedules",
                column: "Id_1ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_Id_2ClassId",
                table: "Schedules",
                column: "Id_2ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_Id_3ClassId",
                table: "Schedules",
                column: "Id_3ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_Id_4ClassId",
                table: "Schedules",
                column: "Id_4ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_Id_5ClassId",
                table: "Schedules",
                column: "Id_5ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_Id_6ClassId",
                table: "Schedules",
                column: "Id_6ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_Id_7ClassId",
                table: "Schedules",
                column: "Id_7ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_Id_8ClassId",
                table: "Schedules",
                column: "Id_8ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_Group_CodeGroupCode",
                table: "Classes",
                column: "Group_CodeGroupCode");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_Id_SubjectId",
                table: "Classes",
                column: "Id_SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_Id_TeacherId",
                table: "Classes",
                column: "Id_TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Groups_Group_CodeGroupCode",
                table: "Classes",
                column: "Group_CodeGroupCode",
                principalTable: "Groups",
                principalColumn: "GroupCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Subjects_Id_SubjectId",
                table: "Classes",
                column: "Id_SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Teachers_Id_TeacherId",
                table: "Classes",
                column: "Id_TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Classes_Id_1ClassId",
                table: "Schedules",
                column: "Id_1ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Classes_Id_2ClassId",
                table: "Schedules",
                column: "Id_2ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Classes_Id_3ClassId",
                table: "Schedules",
                column: "Id_3ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Classes_Id_4ClassId",
                table: "Schedules",
                column: "Id_4ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Classes_Id_5ClassId",
                table: "Schedules",
                column: "Id_5ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Classes_Id_6ClassId",
                table: "Schedules",
                column: "Id_6ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Classes_Id_7ClassId",
                table: "Schedules",
                column: "Id_7ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Classes_Id_8ClassId",
                table: "Schedules",
                column: "Id_8ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Groups_Group_idGroupCode",
                table: "Schedules",
                column: "Group_idGroupCode",
                principalTable: "Groups",
                principalColumn: "GroupCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Teachers_Id_teacherId",
                table: "Subjects",
                column: "Id_teacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
