using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MFR.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Industry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Industry", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RotationLaw",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RotationPeriod = table.Column<int>(type: "int", nullable: false),
                    CoolingPeriod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RotationLaw", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsSecRegistrant = table.Column<bool>(type: "bit", nullable: false),
                    IsListedOnStockExchange = table.Column<bool>(type: "bit", nullable: false),
                    IsListedOnGhanaAlternativeMarket = table.Column<bool>(type: "bit", nullable: false),
                    RotationLawId = table.Column<int>(type: "int", nullable: true),
                    PredecessorAuditor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GlobalGroupAuditor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentCompanyCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpectedRotationYear = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContactName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsContactAlumni = table.Column<bool>(type: "bit", nullable: false),
                    CeoName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoardChairName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CfoName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AltContactName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AltContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AltContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAltContactAlumni = table.Column<bool>(type: "bit", nullable: false),
                    IsClientSalesforce = table.Column<bool>(type: "bit", nullable: false),
                    IndustryId = table.Column<int>(type: "int", nullable: true),
                    SubIndustryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Client_Industry_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Client_Industry_SubIndustryId",
                        column: x => x.SubIndustryId,
                        principalTable: "Industry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Client_RotationLaw_RotationLawId",
                        column: x => x.RotationLawId,
                        principalTable: "RotationLaw",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Client_IndustryId",
                table: "Client",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_RotationLawId",
                table: "Client",
                column: "RotationLawId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_SubIndustryId",
                table: "Client",
                column: "SubIndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_ClientId",
                table: "Service",
                column: "ClientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "Industry");

            migrationBuilder.DropTable(
                name: "RotationLaw");
        }
    }
}
