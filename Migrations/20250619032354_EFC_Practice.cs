using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkCorePractice.Migrations
{
    /// <inheritdoc />
    public partial class EFC_Practice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    s_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    full_name = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    c_gpa = table.Column<decimal>(type: "DECIMAL(3,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.s_id);
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
