using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FirstApp.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(name: "Course Name", type: "VARCHAR(225)", maxLength: 225, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(15,2)", precision: 15, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Offices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(128)", maxLength: 128, nullable: false),
                    OfficeLocation = table.Column<string>(type: "VARCHAR(225)", maxLength: 225, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(225)", maxLength: 225, nullable: false),
                    officeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instructors_Offices_officeId",
                        column: x => x.officeId,
                        principalTable: "Offices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Course Name", "Price" },
                values: new object[,]
                {
                    { 1, "Mathematics", 1000.00m },
                    { 2, "Physics", 2000.00m },
                    { 3, "Chemistry", 1500.00m },
                    { 4, "Biology", 1200.00m },
                    { 5, "Computer Science", 3000.00m }
                });

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Id", "Name", "OfficeLocation" },
                values: new object[,]
                {
                    { 1, "Off_05", "building A" },
                    { 2, "Off_12", "building B" },
                    { 3, "Off_32", "Adminstration" },
                    { 4, "Off_44", "IT Department" },
                    { 5, "Off_43", "IT Department" }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Name", "officeId" },
                values: new object[,]
                {
                    { 1, "Ahmed Abdullah", 1 },
                    { 2, "Yasmeen Mohammed", 2 },
                    { 3, "Khalid Hassan", 3 },
                    { 4, "Nadia Ali", 4 },
                    { 5, "Omar Ibrahim", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_officeId",
                table: "Instructors",
                column: "officeId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "Offices");
        }
    }
}
