using Microsoft.EntityFrameworkCore.Migrations;

namespace FAQ.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<string>(nullable: false),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    TopicId = table.Column<string>(nullable: false),
                    TopicName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.TopicId);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ask = table.Column<string>(nullable: true),
                    Answer = table.Column<string>(nullable: true),
                    CategoryId = table.Column<string>(nullable: true),
                    TopicId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionId);
                    table.ForeignKey(
                        name: "FK_Questions_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Questions_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "TopicId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { "O", "Opinion" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { "G", "General" });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "TopicId", "TopicName" },
                values: new object[] { "C", "Code" });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "TopicId", "TopicName" },
                values: new object[] { "L", "Leisure" });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "TopicId", "TopicName" },
                values: new object[] { "S", "School" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "Answer", "Ask", "CategoryId", "TopicId" },
                values: new object[] { 1, "ReactJS with Typescript", "What's the framework/language combination for creating web apps?", "G", "C" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "Answer", "Ask", "CategoryId", "TopicId" },
                values: new object[] { 3, "SASS. Modular, functional, no semicolons or braces!", "What's the best CSS framework and why?", "O", "C" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "Answer", "Ask", "CategoryId", "TopicId" },
                values: new object[] { 4, "The sound a legendary makes when it drops releases catastrophic amounts of dopamimne.", "Why is Diablo 3 so addictive?", "G", "L" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "Answer", "Ask", "CategoryId", "TopicId" },
                values: new object[] { 5, "Stanley Kubrick's 1968 masterpiece '2001: A Space Odyssey'", "What is the greatest piece of 20th century art?", "O", "L" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "Answer", "Ask", "CategoryId", "TopicId" },
                values: new object[] { 2, "Because it's your last semester before graduation!", "Why is ASP.NET Core MVC so hard?", "G", "S" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "Answer", "Ask", "CategoryId", "TopicId" },
                values: new object[] { 6, "Ace Gayhart, obviously. Who else could compare?", "Who is the greatest professor at Tri-C?", "O", "S" });

            migrationBuilder.CreateIndex(
                name: "IX_Questions_CategoryId",
                table: "Questions",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_TopicId",
                table: "Questions",
                column: "TopicId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Topics");
        }
    }
}
