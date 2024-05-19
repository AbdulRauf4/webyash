using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace yash_gems.Migrations
{
    /// <inheritdoc />
    public partial class dimsubqlty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DimQltySubMst",
                columns: table => new
                {
                    DimSubType_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DimQlty = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DimSubType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DimQltySubMst", x => x.DimSubType_ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DimQltySubMst");
        }
    }
}
