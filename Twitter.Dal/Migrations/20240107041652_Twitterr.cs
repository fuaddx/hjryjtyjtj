using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Twitter.Dal.Migrations
{
    /// <inheritdoc />
    public partial class Twitterr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Topics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 7, 8, 16, 52, 662, DateTimeKind.Local).AddTicks(2763),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 7, 8, 15, 37, 86, DateTimeKind.Local).AddTicks(1099));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 7, 4, 16, 52, 661, DateTimeKind.Utc).AddTicks(6870),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 7, 4, 15, 37, 85, DateTimeKind.Utc).AddTicks(5155));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDay",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 7, 8, 16, 52, 661, DateTimeKind.Local).AddTicks(4958),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 7, 8, 15, 37, 85, DateTimeKind.Local).AddTicks(3091));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Topics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 7, 8, 15, 37, 86, DateTimeKind.Local).AddTicks(1099),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 7, 8, 16, 52, 662, DateTimeKind.Local).AddTicks(2763));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 7, 4, 15, 37, 85, DateTimeKind.Utc).AddTicks(5155),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 7, 4, 16, 52, 661, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDay",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 7, 8, 15, 37, 85, DateTimeKind.Local).AddTicks(3091),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 7, 8, 16, 52, 661, DateTimeKind.Local).AddTicks(4958));
        }
    }
}
