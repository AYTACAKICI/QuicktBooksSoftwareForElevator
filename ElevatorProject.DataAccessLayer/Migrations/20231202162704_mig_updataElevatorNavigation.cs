using Microsoft.EntityFrameworkCore.Migrations;

namespace ElevatorProject.DataAccessLayer.Migrations
{
    public partial class mig_updataElevatorNavigation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Elevators_BuildingManagers_BuildingManagerID",
                table: "Elevators");

            migrationBuilder.DropIndex(
                name: "IX_Elevators_BuildingManagerID",
                table: "Elevators");

            migrationBuilder.DropColumn(
                name: "BuildingManagerID",
                table: "Elevators");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingManagers_ElevatorID",
                table: "BuildingManagers",
                column: "ElevatorID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingManagers_Elevators_ElevatorID",
                table: "BuildingManagers",
                column: "ElevatorID",
                principalTable: "Elevators",
                principalColumn: "ElevatorID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BuildingManagers_Elevators_ElevatorID",
                table: "BuildingManagers");

            migrationBuilder.DropIndex(
                name: "IX_BuildingManagers_ElevatorID",
                table: "BuildingManagers");

            migrationBuilder.AddColumn<int>(
                name: "BuildingManagerID",
                table: "Elevators",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Elevators_BuildingManagerID",
                table: "Elevators",
                column: "BuildingManagerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Elevators_BuildingManagers_BuildingManagerID",
                table: "Elevators",
                column: "BuildingManagerID",
                principalTable: "BuildingManagers",
                principalColumn: "BuildingManagerID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
