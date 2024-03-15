using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFServiceRecords.Migrations
{
    /// <inheritdoc />
    public partial class WorkAssigmentTableCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Work_Assignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffId = table.Column<int>(type: "int", nullable: true),
                    ServiceRecordId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Work_Assignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Work_Assignments_Service_Records_ServiceRecordId",
                        column: x => x.ServiceRecordId,
                        principalTable: "Service_Records",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Work_Assignments_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Work_Assignments_ServiceRecordId",
                table: "Work_Assignments",
                column: "ServiceRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Work_Assignments_StaffId",
                table: "Work_Assignments",
                column: "StaffId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Work_Assignments");
        }
    }
}
