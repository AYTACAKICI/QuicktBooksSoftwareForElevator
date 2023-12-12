using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ElevatorProject.DataAccessLayer.Migrations
{
    public partial class mig_addOffer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    OfferID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfFloor = table.Column<int>(type: "int", nullable: false),
                    ElevatorType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoorType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngineType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElectronicSystemType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descriptions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    DateOfRequestForProposal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfSubmitionOfOffer = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.OfferID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Offers");
        }
    }
}
