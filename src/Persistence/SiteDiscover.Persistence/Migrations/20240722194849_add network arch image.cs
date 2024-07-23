using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteDiscover.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addnetworkarchimage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NetworkArchitectureUploadedFiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NetworkArchitectureId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UploadedFileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NetworkArchitectureUploadedFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NetworkArchitectureUploadedFiles_NetworkArchitectures_NetworkArchitectureId",
                        column: x => x.NetworkArchitectureId,
                        principalTable: "NetworkArchitectures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NetworkArchitectureUploadedFiles_UploadedFiles_UploadedFileId",
                        column: x => x.UploadedFileId,
                        principalTable: "UploadedFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NetworkArchitectureUploadedFiles_NetworkArchitectureId",
                table: "NetworkArchitectureUploadedFiles",
                column: "NetworkArchitectureId");

            migrationBuilder.CreateIndex(
                name: "IX_NetworkArchitectureUploadedFiles_UploadedFileId",
                table: "NetworkArchitectureUploadedFiles",
                column: "UploadedFileId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NetworkArchitectureUploadedFiles");
        }
    }
}
