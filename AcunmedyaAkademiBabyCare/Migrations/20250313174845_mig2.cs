using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcunmedyaAkademiBabyCare.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_BranchId",
                table: "Teams",
                column: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Branches_BranchId",
                table: "Teams",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Branches_BranchId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_BranchId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "Teams");
        }
    }
}
