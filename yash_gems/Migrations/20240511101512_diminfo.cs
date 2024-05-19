using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace yash_gems.Migrations
{
    /// <inheritdoc />
    public partial class diminfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DimInfoMst",
                columns: table => new
                {
                    DimID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DimType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DimSubType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DimCrt = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DimPrice = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DimImg = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DimInfoMst", x => x.DimID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DimInfoMst");
        }
    }
}
