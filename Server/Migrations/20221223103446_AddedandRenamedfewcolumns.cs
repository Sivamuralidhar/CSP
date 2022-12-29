using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSP.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedandRenamedfewcolumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SkillCertfications",
                table: "GeekProfiles",
                newName: "SkillCertificateValue");

            migrationBuilder.RenameColumn(
                name: "SelectedLanguage",
                table: "GeekProfiles",
                newName: "SelectedSecondarySkill");

            migrationBuilder.RenameColumn(
                name: "SecondarySkill",
                table: "GeekProfiles",
                newName: "SelectedPrimarySkill");

            migrationBuilder.RenameColumn(
                name: "PrimarySkill",
                table: "GeekProfiles",
                newName: "SelectedPreferredLanguage");

            migrationBuilder.RenameColumn(
                name: "HighestQualificationCert",
                table: "GeekProfiles",
                newName: "HighestQualificationCertValue");

            migrationBuilder.RenameColumn(
                name: "AcademicCertificationsCertificate",
                table: "GeekProfiles",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "AcademicCertifications",
                table: "GeekProfiles",
                newName: "AcademicCertificationsValue");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SkillCertificateValue",
                table: "GeekProfiles",
                newName: "SkillCertfications");

            migrationBuilder.RenameColumn(
                name: "SelectedSecondarySkill",
                table: "GeekProfiles",
                newName: "SelectedLanguage");

            migrationBuilder.RenameColumn(
                name: "SelectedPrimarySkill",
                table: "GeekProfiles",
                newName: "SecondarySkill");

            migrationBuilder.RenameColumn(
                name: "SelectedPreferredLanguage",
                table: "GeekProfiles",
                newName: "PrimarySkill");

            migrationBuilder.RenameColumn(
                name: "HighestQualificationCertValue",
                table: "GeekProfiles",
                newName: "HighestQualificationCert");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "GeekProfiles",
                newName: "AcademicCertificationsCertificate");

            migrationBuilder.RenameColumn(
                name: "AcademicCertificationsValue",
                table: "GeekProfiles",
                newName: "AcademicCertifications");
        }
    }
}
