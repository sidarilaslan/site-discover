using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteDiscover.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addentitiesrealationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "SiteId",
                table: "ServerRooms",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SiteId",
                table: "MeetingRooms",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SiteId",
                table: "ITContacts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SiteId",
                table: "GeneralInformations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SiteId",
                table: "DigitalSignages",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_ServerRooms_SiteId",
                table: "ServerRooms",
                column: "SiteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MeetingRooms_SiteId",
                table: "MeetingRooms",
                column: "SiteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ITContacts_SiteId",
                table: "ITContacts",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralInformations_SiteId",
                table: "GeneralInformations",
                column: "SiteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DigitalSignages_SiteId",
                table: "DigitalSignages",
                column: "SiteId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DigitalSignages_Sites_SiteId",
                table: "DigitalSignages",
                column: "SiteId",
                principalTable: "Sites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GeneralInformations_Sites_SiteId",
                table: "GeneralInformations",
                column: "SiteId",
                principalTable: "Sites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ITContacts_Sites_SiteId",
                table: "ITContacts",
                column: "SiteId",
                principalTable: "Sites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MeetingRooms_Sites_SiteId",
                table: "MeetingRooms",
                column: "SiteId",
                principalTable: "Sites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServerRooms_Sites_SiteId",
                table: "ServerRooms",
                column: "SiteId",
                principalTable: "Sites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DigitalSignages_Sites_SiteId",
                table: "DigitalSignages");

            migrationBuilder.DropForeignKey(
                name: "FK_GeneralInformations_Sites_SiteId",
                table: "GeneralInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_ITContacts_Sites_SiteId",
                table: "ITContacts");

            migrationBuilder.DropForeignKey(
                name: "FK_MeetingRooms_Sites_SiteId",
                table: "MeetingRooms");

            migrationBuilder.DropForeignKey(
                name: "FK_ServerRooms_Sites_SiteId",
                table: "ServerRooms");

            migrationBuilder.DropIndex(
                name: "IX_ServerRooms_SiteId",
                table: "ServerRooms");

            migrationBuilder.DropIndex(
                name: "IX_MeetingRooms_SiteId",
                table: "MeetingRooms");

            migrationBuilder.DropIndex(
                name: "IX_ITContacts_SiteId",
                table: "ITContacts");

            migrationBuilder.DropIndex(
                name: "IX_GeneralInformations_SiteId",
                table: "GeneralInformations");

            migrationBuilder.DropIndex(
                name: "IX_DigitalSignages_SiteId",
                table: "DigitalSignages");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "ServerRooms");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "MeetingRooms");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "ITContacts");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "GeneralInformations");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "DigitalSignages");
        }
    }
}
