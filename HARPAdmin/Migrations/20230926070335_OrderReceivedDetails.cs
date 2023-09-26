using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HARPAdmin.Migrations
{
    /// <inheritdoc />
    public partial class OrderReceivedDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderReceivedDetails",
                columns: table => new
                {
                    OrderReceivedDetailId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    OrderDetailId = table.Column<int>(type: "int", nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PSUOrderRepairResultId = table.Column<int>(type: "int", nullable: true),
                    PSUOrderRepairResultNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PSUOrderRepairResultCreatedBy = table.Column<int>(type: "int", nullable: true),
                    PSUOrderRepairResultCreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PSUOrderInventoryProductId = table.Column<int>(type: "int", nullable: true),
                    PSUOrderInventoryProductQty = table.Column<int>(type: "int", nullable: true),
                    PSUProductStatusId = table.Column<int>(type: "int", nullable: true),
                    NewSerialNumber = table.Column<int>(type: "int", nullable: true),
                    Createdby = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderReceivedDetails", x => x.OrderReceivedDetailId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderReceivedDetails");
        }
    }
}
