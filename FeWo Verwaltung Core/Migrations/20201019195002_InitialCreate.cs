using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FeWo_Verwaltung_Core.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Vorname = table.Column<string>(nullable: false),
                    Nachname = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Ort = table.Column<string>(nullable: true),
                    Plz = table.Column<int>(nullable: false),
                    Strasse = table.Column<string>(nullable: true),
                    Hausnummer = table.Column<int>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MietWohnungen",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: false),
                    Beschreibung = table.Column<string>(nullable: false),
                    Ort = table.Column<string>(nullable: false),
                    Strasse = table.Column<string>(nullable: false),
                    Plz = table.Column<int>(nullable: false),
                    Hausnummer = table.Column<int>(nullable: false),
                    VermierterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MietWohnungen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MietWohnungen_Users_VermierterId",
                        column: x => x.VermierterId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VermietetSet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ankunft = table.Column<DateTime>(nullable: false),
                    Abreise = table.Column<DateTime>(nullable: false),
                    MieterId = table.Column<int>(nullable: true),
                    MietWohnungId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VermietetSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VermietetSet_MietWohnungen_MietWohnungId",
                        column: x => x.MietWohnungId,
                        principalTable: "MietWohnungen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VermietetSet_Users_MieterId",
                        column: x => x.MieterId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MietWohnungen_VermierterId",
                table: "MietWohnungen",
                column: "VermierterId");

            migrationBuilder.CreateIndex(
                name: "IX_VermietetSet_MietWohnungId",
                table: "VermietetSet",
                column: "MietWohnungId");

            migrationBuilder.CreateIndex(
                name: "IX_VermietetSet_MieterId",
                table: "VermietetSet",
                column: "MieterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VermietetSet");

            migrationBuilder.DropTable(
                name: "MietWohnungen");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
