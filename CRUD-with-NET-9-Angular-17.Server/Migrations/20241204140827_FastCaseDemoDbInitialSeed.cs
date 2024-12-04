using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUD_with_NET_9_Angular_17.Server.Migrations
{
    /// <inheritdoc />
    public partial class FastCaseDemoDbInitialSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cases",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CaseNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Defendant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Plaintiff = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Officer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BadgeNumber = table.Column<int>(type: "int", nullable: false),
                    DescriptionOfIncident = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cases", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cases");
        }
    }
}
