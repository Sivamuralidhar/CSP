using System.ComponentModel.DataAnnotations;

namespace CSP.Shared
{
    public class CSPProfileInfo
    {
        [Key]
        public int ProfileId { get; set; }
        public string? FullName { get; set; }
        public string? MobileNumber { get; set; }
        public string? EmailAddress { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyType { get; set; }

        public string? CompanyRegistrationDocValue { get; set; }
        public string? AllowEnterDataOfIncorporation { get; set; }
        public string? CompanyOfferingsAndDescription { get; set; }
        public string? CompanyLogo { get; set; }
        public string? CompanyINCertNumber { get; set; }
        public string? CompanyINCertValue { get; set; }
        public string? CompanyPAN { get; set; }
        public string? CompanyPANCert { get; set; }
        public string? CompanyGSTNumber { get; set; }
        public string? CompanyGSTCert { get; set; }
        public string? OfficeAddress { get; set; }

        public string? OfficeAddressProofType { get; set; }
        public string? FirmCertificationsValue { get; set; }
        public string? SelectedSkill { get; set; }
        public string? SkillCertificationsEntered { get; set; }

        public string? SkillCertificationsValue { get; set; }
        public string? SelectedCompetency { get; set; }
        public string? AcademicCertificationsValue { get; set; }
        public string? AddressType { get; set; }
        public string? Zip { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? AddressLine3 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public string? CurrentLocationMAP { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime UpdatedOn { get; set; }
        public DateTime UpdatedBy { get; set; }
    }
}
