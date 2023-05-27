using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CorrectMistakes.Data.Migrations
{
    /// <inheritdoc />
    public partial class sdsa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7e6c2d2a-dc83-4bab-b7a9-98ae31ee16ec"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4b8d3dc0-0bbc-4d3a-b507-a54a2cc353b4", "AQAAAAIAAYagAAAAEMrQm8HYWd/HPE/okoA6VLsaWeS8srCNvEMoC+MnUi4nuf5sDDjoTyK3xdtabKJQnw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7e6c2d5a-dc83-4bab-b7a9-98ae31ee16ec"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d600801a-c8fa-48eb-bf57-6fd49c03fb99", "AQAAAAIAAYagAAAAEHXQGmajPN8SM6nOueJmzYrX9LrzOBCKQ29woDg4b4LrrDmF18oORuWyfMXsnDXdCA==" });
        }
    }
}
