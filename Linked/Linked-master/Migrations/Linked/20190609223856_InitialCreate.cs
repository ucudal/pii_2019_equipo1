﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Linked.Migrations.Linked
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "ScoreSheet",
                columns: table => new
                {
                    ScoreSheetID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(nullable: false),
                    Puntualidad = table.Column<int>(nullable: false),
                    Respeto = table.Column<int>(nullable: false),
                    Formalidad = table.Column<int>(nullable: false),
                    Profesionalismo = table.Column<int>(nullable: false),
                    Compromiso = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScoreSheet", x => x.ScoreSheetID);
                });

            migrationBuilder.CreateTable(
                name: "Technician",
                columns: table => new
                {
                    TechnicianID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    Role = table.Column<int>(nullable: false),
                    Level = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technician", x => x.TechnicianID);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    ProjectID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CompletionStatus = table.Column<bool>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Role = table.Column<int>(nullable: false),
                    Level = table.Column<int>(nullable: false),
                    ClientID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.ProjectID);
                    table.ForeignKey(
                        name: "FK_Project_Client_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Client",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FeedBack",
                columns: table => new
                {
                    TechnicianID = table.Column<int>(nullable: false),
                    ScoreSheetID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedBack", x => new { x.TechnicianID, x.ScoreSheetID });
                    table.ForeignKey(
                        name: "FK_FeedBack_ScoreSheet_ScoreSheetID",
                        column: x => x.ScoreSheetID,
                        principalTable: "ScoreSheet",
                        principalColumn: "ScoreSheetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FeedBack_Technician_TechnicianID",
                        column: x => x.TechnicianID,
                        principalTable: "Technician",
                        principalColumn: "TechnicianID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employ",
                columns: table => new
                {
                    TechnicianID = table.Column<int>(nullable: false),
                    ProjectID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employ", x => new { x.TechnicianID, x.ProjectID });
                    table.UniqueConstraint("AK_Employ_ProjectID_TechnicianID", x => new { x.ProjectID, x.TechnicianID });
                    table.ForeignKey(
                        name: "FK_Employ_Project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Project",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employ_Technician_TechnicianID",
                        column: x => x.TechnicianID,
                        principalTable: "Technician",
                        principalColumn: "TechnicianID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FeedBack_ScoreSheetID",
                table: "FeedBack",
                column: "ScoreSheetID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Project_ClientID",
                table: "Project",
                column: "ClientID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employ");

            migrationBuilder.DropTable(
                name: "FeedBack");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "ScoreSheet");

            migrationBuilder.DropTable(
                name: "Technician");

            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
