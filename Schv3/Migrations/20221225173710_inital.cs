using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Schv3.Migrations
{
    /// <inheritdoc />
    public partial class inital : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classrooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Size = table.Column<int>(type: "INTEGER", nullable: false),
                    Building = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classrooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    GroupCode = table.Column<string>(type: "TEXT", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    Institute = table.Column<string>(type: "TEXT", nullable: false),
                    course = table.Column<int>(type: "INTEGER", nullable: false),
                    education = table.Column<int>(type: "INTEGER", nullable: false),
                    studyform = table.Column<int>(name: "study_form", type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.GroupCode);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LName = table.Column<string>(type: "TEXT", nullable: false),
                    FName = table.Column<string>(type: "TEXT", nullable: false),
                    MName = table.Column<string>(type: "TEXT", nullable: false),
                    Post = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Hours = table.Column<int>(type: "INTEGER", nullable: false),
                    IdteacherId = table.Column<int>(name: "Id_teacherId", type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subjects_Teachers_Id_teacherId",
                        column: x => x.IdteacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdSubjectId = table.Column<int>(name: "Id_SubjectId", type: "INTEGER", nullable: false),
                    IdTeacherId = table.Column<int>(name: "Id_TeacherId", type: "INTEGER", nullable: false),
                    IdClassroom = table.Column<int>(name: "Id_Classroom", type: "INTEGER", nullable: false),
                    ClassType = table.Column<int>(type: "INTEGER", nullable: false),
                    Comment = table.Column<int>(type: "INTEGER", nullable: false),
                    GroupCodeGroupCode = table.Column<string>(name: "Group_CodeGroupCode", type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Classes_Groups_Group_CodeGroupCode",
                        column: x => x.GroupCodeGroupCode,
                        principalTable: "Groups",
                        principalColumn: "GroupCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Classes_Subjects_Id_SubjectId",
                        column: x => x.IdSubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Classes_Teachers_Id_TeacherId",
                        column: x => x.IdTeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    date = table.Column<string>(type: "TEXT", nullable: false),
                    Id1ClassId = table.Column<int>(name: "Id_1ClassId", type: "INTEGER", nullable: false),
                    Id2ClassId = table.Column<int>(name: "Id_2ClassId", type: "INTEGER", nullable: false),
                    Id3ClassId = table.Column<int>(name: "Id_3ClassId", type: "INTEGER", nullable: false),
                    Id4ClassId = table.Column<int>(name: "Id_4ClassId", type: "INTEGER", nullable: false),
                    Id5ClassId = table.Column<int>(name: "Id_5ClassId", type: "INTEGER", nullable: false),
                    Id6ClassId = table.Column<int>(name: "Id_6ClassId", type: "INTEGER", nullable: false),
                    Id7ClassId = table.Column<int>(name: "Id_7ClassId", type: "INTEGER", nullable: false),
                    Id8ClassId = table.Column<int>(name: "Id_8ClassId", type: "INTEGER", nullable: false),
                    week = table.Column<int>(type: "INTEGER", nullable: false),
                    GroupidGroupCode = table.Column<string>(name: "Group_idGroupCode", type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schedules_Classes_Id_1ClassId",
                        column: x => x.Id1ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schedules_Classes_Id_2ClassId",
                        column: x => x.Id2ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schedules_Classes_Id_3ClassId",
                        column: x => x.Id3ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schedules_Classes_Id_4ClassId",
                        column: x => x.Id4ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schedules_Classes_Id_5ClassId",
                        column: x => x.Id5ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schedules_Classes_Id_6ClassId",
                        column: x => x.Id6ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schedules_Classes_Id_7ClassId",
                        column: x => x.Id7ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schedules_Classes_Id_8ClassId",
                        column: x => x.Id8ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schedules_Groups_Group_idGroupCode",
                        column: x => x.GroupidGroupCode,
                        principalTable: "Groups",
                        principalColumn: "GroupCode",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_Subjects_Id_teacherId",
                table: "Subjects",
                column: "Id_teacherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Classrooms");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
