using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuthTutorial.Migrations
{
    /// <inheritdoc />
    public partial class updateuserentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
        name: "MificName",
        table: "AspNetUsers",
        type: "text",
        nullable: false,
        defaultValue: "");

            migrationBuilder.AddColumn<string>(
        name: "MificName2",
        table: "AspNetUsers",
        type: "text",
        nullable: false,
        defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
        name: "MificName",
        table: "AspNetUsers");

            migrationBuilder.DropColumn(
        name: "MificName2",
        table: "AspNetUsers");
        }
    }
}
