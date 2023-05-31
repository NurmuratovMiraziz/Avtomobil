using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CorrectMistakes.Data.Migrations
{
    /// <inheritdoc />
    public partial class MijozCarboglanish : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Mijozs_MijozId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_MijozId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "MijozId",
                table: "Cars");

            migrationBuilder.CreateTable(
                name: "CarMijoz",
                columns: table => new
                {
                    CarsId = table.Column<int>(type: "int", nullable: false),
                    MijozId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarMijoz", x => new { x.CarsId, x.MijozId });
                    table.ForeignKey(
                        name: "FK_CarMijoz_Cars_CarsId",
                        column: x => x.CarsId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarMijoz_Mijozs_MijozId",
                        column: x => x.MijozId,
                        principalTable: "Mijozs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7e6c2d2a-dc83-4bab-b7a9-98ae31ee16ec"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "794a1171-3cf1-4632-bed4-5abe6cacc207", "AQAAAAIAAYagAAAAELGgc3xLQs0yfaOCU4S+Tdjg8v2kWt/pkJlVYlB8XqDtCmT1Ruk3J6LVyBPjWWg2tw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7e6c2d5a-dc83-4bab-b7a9-98ae31ee16ec"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e9998c9a-b4d8-40cd-ae68-ce06f2cd734d", "AQAAAAIAAYagAAAAEOyHJTLmhJ7Lf749fxfdZ0EvKWqmaDFXr2zZfylNgsH4UBxP2/nTPvqV76hnI3Qvyg==" });

            migrationBuilder.CreateIndex(
                name: "IX_CarMijoz_MijozId",
                table: "CarMijoz",
                column: "MijozId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarMijoz");

            migrationBuilder.AddColumn<int>(
                name: "MijozId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7e6c2d2a-dc83-4bab-b7a9-98ae31ee16ec"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dab0d49b-b684-4169-97e5-da77bb90f9ca", "AQAAAAIAAYagAAAAEIdSQIRpjWgzE8v+OeNxcTxFE6/P2i+M8oQjwwuCrxiQfj8Ko1CyegyGOAgpFh7oJA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7e6c2d5a-dc83-4bab-b7a9-98ae31ee16ec"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cb27c792-faed-492b-b949-591faab97567", "AQAAAAIAAYagAAAAEC24dp+tHkcrZFS0wAPTkfDoGO3faArFpyv1WKdYgU3y9eoD1pynogMkBE4dY1Mgtw==" });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_MijozId",
                table: "Cars",
                column: "MijozId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Mijozs_MijozId",
                table: "Cars",
                column: "MijozId",
                principalTable: "Mijozs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
