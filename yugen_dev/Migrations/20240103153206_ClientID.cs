using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace yugen_dev.Migrations
{
    /// <inheritdoc />
    public partial class ClientID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fk_ClientId",
                table: "Reviews");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Fk_ClientId",
                table: "Reviews",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
