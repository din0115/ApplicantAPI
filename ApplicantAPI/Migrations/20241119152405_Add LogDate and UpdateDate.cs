using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApplicantAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddLogDateandUpdateDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LogDate",
                table: "Applicants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Applicants",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LogDate",
                table: "Applicants");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Applicants");
        }
    }
}
