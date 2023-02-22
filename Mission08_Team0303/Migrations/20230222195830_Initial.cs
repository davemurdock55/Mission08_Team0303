using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission08_Team0303.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Task",
                columns: table => new
                {
                    TaskId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    task = table.Column<string>(nullable: false),
                    DueDate = table.Column<string>(nullable: true),
                    Quadrant = table.Column<int>(nullable: false),
                    Category = table.Column<string>(nullable: true),
                    Completed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Task", x => x.TaskId);
                });

            migrationBuilder.InsertData(
                table: "Task",
                columns: new[] { "TaskId", "Category", "Completed", "DueDate", "Quadrant", "task" },
                values: new object[] { 1, "Home", false, "Tuesday", 4, "Do laundry" });

            migrationBuilder.InsertData(
                table: "Task",
                columns: new[] { "TaskId", "Category", "Completed", "DueDate", "Quadrant", "task" },
                values: new object[] { 2, "Church", false, "Sunday", 2, "Write talk" });

            migrationBuilder.InsertData(
                table: "Task",
                columns: new[] { "TaskId", "Category", "Completed", "DueDate", "Quadrant", "task" },
                values: new object[] { 3, "Work", true, null, 1, "Go to work" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Task");
        }
    }
}
