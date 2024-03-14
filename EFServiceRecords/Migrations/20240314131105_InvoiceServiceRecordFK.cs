using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFServiceRecords.Migrations
{
    /// <inheritdoc />
    public partial class InvoiceServiceRecordFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ServiceRecordId",
                table: "Invoices",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ServiceRecordId",
                table: "Invoices",
                column: "ServiceRecordId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Service_Records_ServiceRecordId",
                table: "Invoices",
                column: "ServiceRecordId",
                principalTable: "Service_Records",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Service_Records_ServiceRecordId",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_ServiceRecordId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "ServiceRecordId",
                table: "Invoices");
        }
    }
}
