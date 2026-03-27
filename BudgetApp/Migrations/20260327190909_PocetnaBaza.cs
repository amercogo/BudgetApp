using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BudgetApp.Migrations
{
    /// <inheritdoc />
    public partial class PocetnaBaza : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KategorijaTroska",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Naziv = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KategorijaTroska", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Korisnici",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: false),
                    Napravljeno = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnici", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrioritetTroska",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Naziv = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrioritetTroska", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SigurnostPlate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Naziv = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SigurnostPlate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tagovi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Naziv = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tagovi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BudgetPlan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Naziv = table.Column<string>(type: "TEXT", nullable: false),
                    UkupanPrihodPlana = table.Column<decimal>(type: "TEXT", nullable: false),
                    KorisnikId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudgetPlan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BudgetPlan_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Troskovi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Naziv = table.Column<string>(type: "TEXT", nullable: false),
                    Opis = table.Column<string>(type: "TEXT", nullable: false),
                    Ukupno = table.Column<decimal>(type: "TEXT", nullable: false),
                    Napomena = table.Column<string>(type: "TEXT", nullable: false),
                    Datum = table.Column<DateTime>(type: "TEXT", nullable: false),
                    KorisnikId = table.Column<int>(type: "INTEGER", nullable: false),
                    KategorijaTroskaId = table.Column<int>(type: "INTEGER", nullable: false),
                    PrioritetTroskaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Troskovi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Troskovi_KategorijaTroska_KategorijaTroskaId",
                        column: x => x.KategorijaTroskaId,
                        principalTable: "KategorijaTroska",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Troskovi_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Troskovi_PrioritetTroska_PrioritetTroskaId",
                        column: x => x.PrioritetTroskaId,
                        principalTable: "PrioritetTroska",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prihodi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Naziv = table.Column<string>(type: "TEXT", nullable: false),
                    Opis = table.Column<string>(type: "TEXT", nullable: false),
                    Ukupno = table.Column<decimal>(type: "TEXT", nullable: false),
                    Napomena = table.Column<string>(type: "TEXT", nullable: false),
                    Datum = table.Column<DateTime>(type: "TEXT", nullable: false),
                    KorisnikId = table.Column<int>(type: "INTEGER", nullable: false),
                    TagoviId = table.Column<int>(type: "INTEGER", nullable: false),
                    SigurnostPlateId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prihodi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prihodi_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prihodi_SigurnostPlate_SigurnostPlateId",
                        column: x => x.SigurnostPlateId,
                        principalTable: "SigurnostPlate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prihodi_Tagovi_TagoviId",
                        column: x => x.TagoviId,
                        principalTable: "Tagovi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BudgetPlanTrosakKategorija",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IznosKm = table.Column<decimal>(type: "TEXT", nullable: false),
                    ProcenatPlana = table.Column<decimal>(type: "TEXT", nullable: false),
                    KategorijaTroskaId = table.Column<int>(type: "INTEGER", nullable: false),
                    BudgetPlanId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudgetPlanTrosakKategorija", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BudgetPlanTrosakKategorija_BudgetPlan_BudgetPlanId",
                        column: x => x.BudgetPlanId,
                        principalTable: "BudgetPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BudgetPlanTrosakKategorija_KategorijaTroska_KategorijaTroskaId",
                        column: x => x.KategorijaTroskaId,
                        principalTable: "KategorijaTroska",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BudgetPlan_KorisnikId",
                table: "BudgetPlan",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_BudgetPlanTrosakKategorija_BudgetPlanId",
                table: "BudgetPlanTrosakKategorija",
                column: "BudgetPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_BudgetPlanTrosakKategorija_KategorijaTroskaId",
                table: "BudgetPlanTrosakKategorija",
                column: "KategorijaTroskaId");

            migrationBuilder.CreateIndex(
                name: "IX_Prihodi_KorisnikId",
                table: "Prihodi",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Prihodi_SigurnostPlateId",
                table: "Prihodi",
                column: "SigurnostPlateId");

            migrationBuilder.CreateIndex(
                name: "IX_Prihodi_TagoviId",
                table: "Prihodi",
                column: "TagoviId");

            migrationBuilder.CreateIndex(
                name: "IX_Troskovi_KategorijaTroskaId",
                table: "Troskovi",
                column: "KategorijaTroskaId");

            migrationBuilder.CreateIndex(
                name: "IX_Troskovi_KorisnikId",
                table: "Troskovi",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Troskovi_PrioritetTroskaId",
                table: "Troskovi",
                column: "PrioritetTroskaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BudgetPlanTrosakKategorija");

            migrationBuilder.DropTable(
                name: "Prihodi");

            migrationBuilder.DropTable(
                name: "Troskovi");

            migrationBuilder.DropTable(
                name: "BudgetPlan");

            migrationBuilder.DropTable(
                name: "SigurnostPlate");

            migrationBuilder.DropTable(
                name: "Tagovi");

            migrationBuilder.DropTable(
                name: "KategorijaTroska");

            migrationBuilder.DropTable(
                name: "PrioritetTroska");

            migrationBuilder.DropTable(
                name: "Korisnici");
        }
    }
}
