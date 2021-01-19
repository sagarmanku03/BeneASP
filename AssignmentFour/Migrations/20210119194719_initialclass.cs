using System;
using System.IO;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssignmentFour.Migrations
{
    public partial class initialclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Plan",
                columns: table => new
                {
                    PlanCode = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanDescription = table.Column<string>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plan", x => x.PlanCode);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    StaffCode = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Birth = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.StaffCode);
                });

            migrationBuilder.CreateTable(
                name: "Benefit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanCode = table.Column<int>(nullable: false),
                    StaffCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Benefit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Benefit_Plan_PlanCode",
                        column: x => x.PlanCode,
                        principalTable: "Plan",
                        principalColumn: "PlanCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Benefit_Staff_StaffCode",
                        column: x => x.StaffCode,
                        principalTable: "Staff",
                        principalColumn: "StaffCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Job",
                columns: table => new
                {
                    JobCode = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    isAvailable = table.Column<bool>(nullable: false),
                    StaffCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job", x => x.JobCode);
                    table.ForeignKey(
                        name: "FK_Job_Staff_StaffCode",
                        column: x => x.StaffCode,
                        principalTable: "Staff",
                        principalColumn: "StaffCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Benefit_PlanCode",
                table: "Benefit",
                column: "PlanCode");

            migrationBuilder.CreateIndex(
                name: "IX_Benefit_StaffCode",
                table: "Benefit",
                column: "StaffCode");

            migrationBuilder.CreateIndex(
                name: "IX_Job_StaffCode",
                table: "Job",
                column: "StaffCode");

            var sqlFile = Path.Combine(".//Data/Database Script", @"Data.sql");
            migrationBuilder.Sql(File.ReadAllText(sqlFile));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Benefit");

            migrationBuilder.DropTable(
                name: "Job");

            migrationBuilder.DropTable(
                name: "Plan");

            migrationBuilder.DropTable(
                name: "Staff");
        }
    }
}
