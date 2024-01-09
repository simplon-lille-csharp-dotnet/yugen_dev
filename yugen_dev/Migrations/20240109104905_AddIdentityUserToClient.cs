using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace yugen_dev.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentityUserToClient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Clients",
                newName: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_IdentityUserId",
                table: "Clients",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_AspNetUsers_IdentityUserId",
                table: "Clients",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_AspNetUsers_IdentityUserId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_IdentityUserId",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "IdentityUserId",
                table: "Clients",
                newName: "UserName");

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Clients",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Clients",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Clients",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Clients",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Clients",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Clients",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Clients",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Clients",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Clients",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Clients",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Clients",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}
