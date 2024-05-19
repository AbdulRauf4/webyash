using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace yash_gems.Migrations
{
    /// <inheritdoc />
    public partial class diamonds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DimMst",
                columns: table => new
                {
                    D_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Style_Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DimQlty = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DimSubType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Dim_Crt = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    Dim_Pcs = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    Dim_Gm = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    Dim_Size = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    Dim_Rate = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    Dim_Amt = table.Column<decimal>(type: "numeric(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DimMst", x => x.D_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DimMst");
        }
    }
}
