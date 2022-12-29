using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSP.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedandRenamedColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SkillCertifications",
                table: "CSPProfiles",
                newName: "SkillCertificationEntered");

            migrationBuilder.RenameColumn(
                name: "Skill",
                table: "CSPProfiles",
                newName: "SelectedSkill");

            migrationBuilder.RenameColumn(
                name: "FirmCertifications",
                table: "CSPProfiles",
                newName: "FirmCertificationsValue");

            migrationBuilder.RenameColumn(
                name: "CompanyRegistrationDoc",
                table: "CSPProfiles",
                newName: "CompanyRegistrationDocValue");

            migrationBuilder.RenameColumn(
                name: "AddressProof",
                table: "CSPProfiles",
                newName: "AddressProofType");

            migrationBuilder.AddColumn<string>(
                name: "AcademicCertificationsValue",
                table: "CSPProfiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyGSTNumber",
                table: "CSPProfiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyINCertValue",
                table: "CSPProfiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyPANCert",
                table: "CSPProfiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyType",
                table: "CSPProfiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SelectedCompetency",
                table: "CSPProfiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SkillCertificationsValue",
                table: "CSPProfiles",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcademicCertificationsValue",
                table: "CSPProfiles");

            migrationBuilder.DropColumn(
                name: "CompanyGSTNumber",
                table: "CSPProfiles");

            migrationBuilder.DropColumn(
                name: "CompanyINCertValue",
                table: "CSPProfiles");

            migrationBuilder.DropColumn(
                name: "CompanyPANCert",
                table: "CSPProfiles");

            migrationBuilder.DropColumn(
                name: "CompanyType",
                table: "CSPProfiles");

            migrationBuilder.DropColumn(
                name: "SelectedCompetency",
                table: "CSPProfiles");

            migrationBuilder.DropColumn(
                name: "SkillCertificationsValue",
                table: "CSPProfiles");

            migrationBuilder.RenameColumn(
                name: "SkillCertificationEntered",
                table: "CSPProfiles",
                newName: "SkillCertifications");

            migrationBuilder.RenameColumn(
                name: "SelectedSkill",
                table: "CSPProfiles",
                newName: "Skill");

            migrationBuilder.RenameColumn(
                name: "FirmCertificationsValue",
                table: "CSPProfiles",
                newName: "FirmCertifications");

            migrationBuilder.RenameColumn(
                name: "CompanyRegistrationDocValue",
                table: "CSPProfiles",
                newName: "CompanyRegistrationDoc");

            migrationBuilder.RenameColumn(
                name: "AddressProofType",
                table: "CSPProfiles",
                newName: "AddressProof");
        }
    }
}
