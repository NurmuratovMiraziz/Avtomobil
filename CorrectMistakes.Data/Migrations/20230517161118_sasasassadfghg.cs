using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CorrectMistakes.Data.Migrations
{
    /// <inheritdoc />
    public partial class sasasassadfghg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7e6c2d2a-dc83-4bab-b7a9-98ae31ee16ec"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5f7e3cb3-62bf-40d2-907a-6567fe946c96", "AQAAAAIAAYagAAAAENzTllRVSnJcOfYVtLTB9XSPoh7i3FOyqc1FTJpxHR6tEBDiSjsWSF0RllzYEh44FQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7e6c2d5a-dc83-4bab-b7a9-98ae31ee16ec"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "be56bb00-2f94-4ffa-a52a-f2aef79bdcc1", "AQAAAAIAAYagAAAAEE2YX+eNhQiwBPtIJR0EWm0U/eSNWYH0rgx1sRsfqXrqHJcbP3zLJvHOnAHRbKcubQ==" });
        }
    }
}
