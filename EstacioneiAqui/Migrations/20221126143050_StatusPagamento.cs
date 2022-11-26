using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstacioneiAqui.Migrations
{
    /// <inheritdoc />
    public partial class StatusPagamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Clientes");
        }
    }
}
