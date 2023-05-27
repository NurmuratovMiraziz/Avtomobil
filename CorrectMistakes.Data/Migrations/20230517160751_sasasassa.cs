using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CorrectMistakes.Data.Migrations
{
    /// <inheritdoc />
    public partial class sasasassa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AutosalonId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Autosalons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autosalons", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7e6c2d2a-dc83-4bab-b7a9-98ae31ee16ec"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "5f7e3cb3-62bf-40d2-907a-6567fe946c96", "MIRAZIZ", "AQAAAAIAAYagAAAAENzTllRVSnJcOfYVtLTB9XSPoh7i3FOyqc1FTJpxHR6tEBDiSjsWSF0RllzYEh44FQ==", "Miraziz" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7e6c2d5a-dc83-4bab-b7a9-98ae31ee16ec"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "be56bb00-2f94-4ffa-a52a-f2aef79bdcc1", "AQAAAAIAAYagAAAAEE2YX+eNhQiwBPtIJR0EWm0U/eSNWYH0rgx1sRsfqXrqHJcbP3zLJvHOnAHRbKcubQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_AutosalonId",
                table: "Cars",
                column: "AutosalonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Autosalons_AutosalonId",
                table: "Cars",
                column: "AutosalonId",
                principalTable: "Autosalons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Autosalons_AutosalonId",
                table: "Cars");

            migrationBuilder.DropTable(
                name: "Autosalons");

            migrationBuilder.DropIndex(
                name: "IX_Cars_AutosalonId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "AutosalonId",
                table: "Cars");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7e6c2d2a-dc83-4bab-b7a9-98ae31ee16ec"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "efbcc843-4375-4c40-991c-11eecb22acf1", "MIRAZIZ0626", "AQAAAAIAAYagAAAAEIWaD8G6ZeuqIchghFRMBX/xFWA7E2+5/QWxvAVU7I9gxJvUBgPLKgygpBWt4z0/1g==", "Miraziz0626" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7e6c2d5a-dc83-4bab-b7a9-98ae31ee16ec"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "03c80845-f1db-4a65-9ee9-3e91bf47b7b4", "AQAAAAIAAYagAAAAEJUJVT9XKV1Vbcgs4KlzfZoJpNWh4Xm4FyEAg4dfMCmDpfT3L3ODXPE6xFlmMhHQ2w==" });
        }
    }
}
