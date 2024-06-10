using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CurrentLogs_Offers_OfferId",
                table: "CurrentLogs");

            migrationBuilder.DropIndex(
                name: "IX_CurrentLogs_OfferId",
                table: "CurrentLogs");

            migrationBuilder.DropColumn(
                name: "OfferId",
                table: "CurrentLogs");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentLogs_CurrentId",
                table: "CurrentLogs",
                column: "CurrentId");

            migrationBuilder.AddForeignKey(
                name: "FK_CurrentLogs_Currents_CurrentId",
                table: "CurrentLogs",
                column: "CurrentId",
                principalTable: "Currents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CurrentLogs_Currents_CurrentId",
                table: "CurrentLogs");

            migrationBuilder.DropIndex(
                name: "IX_CurrentLogs_CurrentId",
                table: "CurrentLogs");

            migrationBuilder.AddColumn<int>(
                name: "OfferId",
                table: "CurrentLogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CurrentLogs_OfferId",
                table: "CurrentLogs",
                column: "OfferId");

            migrationBuilder.AddForeignKey(
                name: "FK_CurrentLogs_Offers_OfferId",
                table: "CurrentLogs",
                column: "OfferId",
                principalTable: "Offers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
