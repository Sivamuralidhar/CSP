using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSP.Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedDBTableNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GeekProfiles",
                table: "GeekProfiles");

            migrationBuilder.RenameTable(
                name: "GeekProfiles",
                newName: "CSPGeekProfiles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CSPGeekProfiles",
                table: "CSPGeekProfiles",
                column: "GeekProfileId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CSPGeekProfiles",
                table: "CSPGeekProfiles");

            migrationBuilder.RenameTable(
                name: "CSPGeekProfiles",
                newName: "GeekProfiles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GeekProfiles",
                table: "GeekProfiles",
                column: "GeekProfileId");
        }
    }
}
