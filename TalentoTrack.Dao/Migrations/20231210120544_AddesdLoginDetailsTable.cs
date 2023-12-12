﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TalentoTrack.Dao.Migrations
{
    /// <inheritdoc />
    public partial class AddesdLoginDetailsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "tbl_user");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_user",
                table: "tbl_user",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "tbl_login_details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_login_details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_login_details_tbl_user_UserId",
                        column: x => x.UserId,
                        principalTable: "tbl_user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_login_details_UserId",
                table: "tbl_login_details",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_login_details");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_user",
                table: "tbl_user");

            migrationBuilder.RenameTable(
                name: "tbl_user",
                newName: "User");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");
        }
    }
}
