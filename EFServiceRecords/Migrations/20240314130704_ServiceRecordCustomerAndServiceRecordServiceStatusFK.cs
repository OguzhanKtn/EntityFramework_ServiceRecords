using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFServiceRecords.Migrations
{
    /// <inheritdoc />
    public partial class ServiceRecordCustomerAndServiceRecordServiceStatusFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Service_Records",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServiceStatusId",
                table: "Service_Records",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Service_Records_CustomerId",
                table: "Service_Records",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_Records_ServiceStatusId",
                table: "Service_Records",
                column: "ServiceStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Service_Records_Customers_CustomerId",
                table: "Service_Records",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Service_Records_Service_Status_ServiceStatusId",
                table: "Service_Records",
                column: "ServiceStatusId",
                principalTable: "Service_Status",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Service_Records_Customers_CustomerId",
                table: "Service_Records");

            migrationBuilder.DropForeignKey(
                name: "FK_Service_Records_Service_Status_ServiceStatusId",
                table: "Service_Records");

            migrationBuilder.DropIndex(
                name: "IX_Service_Records_CustomerId",
                table: "Service_Records");

            migrationBuilder.DropIndex(
                name: "IX_Service_Records_ServiceStatusId",
                table: "Service_Records");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Service_Records");

            migrationBuilder.DropColumn(
                name: "ServiceStatusId",
                table: "Service_Records");
        }
    }
}
