using Microsoft.EntityFrameworkCore.Migrations;

namespace ADETGrade.Migrations
{
    public partial class Adetgrades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Course = table.Column<string>(nullable: true),
                    YearSection = table.Column<string>(nullable: true),
                    PrelimQ1 = table.Column<float>(nullable: false),
                    PrelimQ2 = table.Column<float>(nullable: false),
                    PrelimQ3 = table.Column<float>(nullable: false),
                    PrelimA1 = table.Column<float>(nullable: false),
                    PrelimA2 = table.Column<float>(nullable: false),
                    PrelimA3 = table.Column<float>(nullable: false),
                    PrelimTotal = table.Column<float>(nullable: false),
                    MidtermQ1 = table.Column<float>(nullable: false),
                    MidtermQ2 = table.Column<float>(nullable: false),
                    MidtermQ3 = table.Column<float>(nullable: false),
                    MidtermA1 = table.Column<float>(nullable: false),
                    MidtermA2 = table.Column<float>(nullable: false),
                    MidtermA3 = table.Column<float>(nullable: false),
                    MidTermTotal = table.Column<float>(nullable: false),
                    PreFinalQ1 = table.Column<float>(nullable: false),
                    PreFinalQ2 = table.Column<float>(nullable: false),
                    PreFinalQ3 = table.Column<float>(nullable: false),
                    PreFinalA1 = table.Column<float>(nullable: false),
                    PreFinalA2 = table.Column<float>(nullable: false),
                    PreFinalA3 = table.Column<float>(nullable: false),
                    PreFinalTotal = table.Column<float>(nullable: false),
                    FinalQ1 = table.Column<float>(nullable: false),
                    FinalQ2 = table.Column<float>(nullable: false),
                    FinalQ3 = table.Column<float>(nullable: false),
                    FinalA1 = table.Column<float>(nullable: false),
                    FinalA2 = table.Column<float>(nullable: false),
                    FinalA3 = table.Column<float>(nullable: false),
                    FinalTotal = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Grades");
        }
    }
}
