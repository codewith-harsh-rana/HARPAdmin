using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HARPAdmin.Migrations
{
    /// <inheritdoc />
    public partial class ShippedDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "shippedDetails",
                columns: table => new
                {
                    ShippedDetailId = table.Column<int>(type: "int", nullable: false),
                    ShippedId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    OrderDetailId = table.Column<int>(type: "int", nullable: false),
                    OrderReceivedDetailId = table.Column<int>(type: "int", nullable: false),
                    WUPreTestId = table.Column<int>(type: "int", nullable: false),
                    Createdby = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shippedDetails", x => x.ShippedDetailId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "shippedDetails");
        }
    }
}
