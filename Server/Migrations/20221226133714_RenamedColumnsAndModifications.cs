using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSP.Server.Migrations
{
    /// <inheritdoc />
    public partial class RenamedColumnsAndModifications : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SkillCertificationEntered",
                table: "CSPProfiles",
                newName: "SkillCertificationsEntered");

            migrationBuilder.RenameColumn(
                name: "AddressProofType",
                table: "CSPProfiles",
                newName: "OfficeAddressProofType");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SkillCertificationsEntered",
                table: "CSPProfiles",
                newName: "SkillCertificationEntered");

            migrationBuilder.RenameColumn(
                name: "OfficeAddressProofType",
                table: "CSPProfiles",
                newName: "AddressProofType");
        }
    }
}
