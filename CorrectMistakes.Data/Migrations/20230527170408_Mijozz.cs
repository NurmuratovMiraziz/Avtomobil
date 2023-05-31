using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CorrectMistakes.Data.Migrations
{
    /// <inheritdoc />
    public partial class Mijozz : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MijozId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Mijozs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mijozs", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Mijozs_MijozId",
                table: "Cars");

            migrationBuilder.DropTable(
                name: "Mijozs");

            migrationBuilder.DropIndex(
                name: "IX_Cars_MijozId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "MijozId",
                table: "Cars");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7e6c2d2a-dc83-4bab-b7a9-98ae31ee16ec"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "95025d83-d5ad-469f-963a-e155c43db98a", "AQAAAAIAAYagAAAAEK13JtNEwbxrXk+qP989BnU78z5ayfCqRRbK86ffxeOZ8mR40VUxZZTXc9AVY0JeEw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7e6c2d5a-dc83-4bab-b7a9-98ae31ee16ec"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "791da5f4-251c-4b91-9ff5-1d036d47b1dd", "AQAAAAIAAYagAAAAEBX//NCw/KPx7i79TO0XHGBh7NC6fdwC65VJge2tjGpmtIjsdDmCvSDQTt1PARP+1Q==" });
        }
    }
}
