using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Studentmgt.Migrations
{
    /// <inheritdoc />
    public partial class Initial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    strStudentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    strCourseId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strStudentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strStudentMobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strStudentEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strCeatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dtmCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    strUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dtmUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.strStudentId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
