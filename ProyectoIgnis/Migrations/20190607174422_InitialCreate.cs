using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoIgnis.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    MailAdress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HourLoad = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Client = table.Column<string>(nullable: true),
                    Level = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Technician",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    MailAdress = table.Column<string>(nullable: true),
                    Level = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technician", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProjectAllocated",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HourLoad = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Client = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    Level = table.Column<string>(nullable: true),
                    TechnicianID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectAllocated", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProjectAllocated_Technician_TechnicianID",
                        column: x => x.TechnicianID,
                        principalTable: "Technician",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectAllocated_TechnicianID",
                table: "ProjectAllocated",
                column: "TechnicianID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "ProjectAllocated");

            migrationBuilder.DropTable(
                name: "Technician");
        }
    }
}
