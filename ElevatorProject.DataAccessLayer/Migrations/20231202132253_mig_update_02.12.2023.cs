using Microsoft.EntityFrameworkCore.Migrations;

namespace ElevatorProject.DataAccessLayer.Migrations
{
    public partial class mig_update_02122023 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ElevatorRevision");

            migrationBuilder.CreateIndex(
                name: "IX_Revisions_ElevatorID",
                table: "Revisions",
                column: "ElevatorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Revisions_Elevators_ElevatorID",
                table: "Revisions",
                column: "ElevatorID",
                principalTable: "Elevators",
                principalColumn: "ElevatorID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Revisions_Elevators_ElevatorID",
                table: "Revisions");

            migrationBuilder.DropIndex(
                name: "IX_Revisions_ElevatorID",
                table: "Revisions");

            migrationBuilder.CreateTable(
                name: "ElevatorRevision",
                columns: table => new
                {
                    ElevatorsElevatorID = table.Column<int>(type: "int", nullable: false),
                    RevisionsRevisionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElevatorRevision", x => new { x.ElevatorsElevatorID, x.RevisionsRevisionID });
                    table.ForeignKey(
                        name: "FK_ElevatorRevision_Elevators_ElevatorsElevatorID",
                        column: x => x.ElevatorsElevatorID,
                        principalTable: "Elevators",
                        principalColumn: "ElevatorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ElevatorRevision_Revisions_RevisionsRevisionID",
                        column: x => x.RevisionsRevisionID,
                        principalTable: "Revisions",
                        principalColumn: "RevisionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ElevatorRevision_RevisionsRevisionID",
                table: "ElevatorRevision",
                column: "RevisionsRevisionID");
        }
    }
}
