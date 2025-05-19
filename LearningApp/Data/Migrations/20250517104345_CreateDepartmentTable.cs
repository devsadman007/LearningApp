using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearningApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateDepartmentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    short_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    deleteBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDEleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
