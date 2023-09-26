using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HARPAdmin.Migrations
{
    /// <inheritdoc />
    public partial class CompanyMaster : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "companyMasters",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<int>(type: "int", nullable: false),
                    ACHRouting = table.Column<int>(type: "int", nullable: false),
                    ACHAccount = table.Column<int>(type: "int", nullable: false),
                    ACHBank1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ACHBank2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ACHBank3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ACHCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ACHState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WITo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WIRouting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WIAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WIAccountName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPOBtc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPOEth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPOUsdt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FFCACCOUNT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FFCACCOUNTNAME = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companyMasters", x => x.CompanyId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "companyMasters");
        }
    }
}
