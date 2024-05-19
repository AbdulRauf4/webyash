using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace yash_gems.Migrations
{
    /// <inheritdoc />
    public partial class category : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CatMst",
                columns: table => new
                {
                    Cat_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Cat_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatMst", x => x.Cat_ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CatMst");
        }
    }
}
