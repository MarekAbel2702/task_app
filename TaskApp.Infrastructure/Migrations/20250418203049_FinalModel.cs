using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FinalModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Users_UserId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamUser_Teams_TeamId",
                table: "TeamUser");

            migrationBuilder.DropIndex(
                name: "IX_Projects_UserId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "TeamId",
                table: "TeamUser",
                newName: "TeamsId");

            migrationBuilder.RenameIndex(
                name: "IX_TeamUser_TeamId",
                table: "TeamUser",
                newName: "IX_TeamUser_TeamsId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamUser_Teams_TeamsId",
                table: "TeamUser",
                column: "TeamsId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeamUser_Teams_TeamsId",
                table: "TeamUser");

            migrationBuilder.RenameColumn(
                name: "TeamsId",
                table: "TeamUser",
                newName: "TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_TeamUser_TeamsId",
                table: "TeamUser",
                newName: "IX_TeamUser_TeamId");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Projects",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_UserId",
                table: "Projects",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Users_UserId",
                table: "Projects",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamUser_Teams_TeamId",
                table: "TeamUser",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
