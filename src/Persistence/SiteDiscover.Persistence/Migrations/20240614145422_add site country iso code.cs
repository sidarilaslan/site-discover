﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteDiscover.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addsitecountryisocode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CountryISO",
                table: "Sites",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountryISO",
                table: "Sites");
        }
    }
}