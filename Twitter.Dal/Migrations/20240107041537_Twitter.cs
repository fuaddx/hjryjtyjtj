using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Twitter.Dal.Migrations
{
    /// <inheritdoc />
    public partial class Twitter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Topics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 7, 8, 15, 37, 86, DateTimeKind.Local).AddTicks(1099),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 7, 0, 41, 52, 160, DateTimeKind.Local).AddTicks(2056));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 7, 4, 15, 37, 85, DateTimeKind.Utc).AddTicks(5155),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 6, 20, 41, 52, 159, DateTimeKind.Utc).AddTicks(6272));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDay",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 7, 8, 15, 37, 85, DateTimeKind.Local).AddTicks(3091),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 7, 0, 41, 52, 159, DateTimeKind.Local).AddTicks(4128));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Topics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 7, 0, 41, 52, 160, DateTimeKind.Local).AddTicks(2056),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 7, 8, 15, 37, 86, DateTimeKind.Local).AddTicks(1099));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 6, 20, 41, 52, 159, DateTimeKind.Utc).AddTicks(6272),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 7, 4, 15, 37, 85, DateTimeKind.Utc).AddTicks(5155));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDay",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 7, 0, 41, 52, 159, DateTimeKind.Local).AddTicks(4128),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 7, 8, 15, 37, 85, DateTimeKind.Local).AddTicks(3091));
        }
    }
}
