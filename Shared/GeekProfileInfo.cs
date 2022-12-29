using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSP.Shared
{
    public class GeekProfileInfo
    { 
        [Key]
        public int GeekProfileId { get; set; }
        public string? FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public string? HighestQualification { get; set; }

        //[Column("HighestQualificationCertValue")]
        public string? HighestQualificationCertValue { get; set; }
        public string? ProfileBriefDescription { get; set; }
        public string? ProfilePhoto { get; set; }
        //[Column("AcademicCertificationsValue")]
        public string? AcademicCertificationsValue { get; set; }
        //[Column("SelectedPreferredLanguage")]
        public string? SelectedPreferredLanguage { get; set; }
        //[Column("SelectedPrimarySkill")]
        public string? SelectedPrimarySkill { get; set; }
        //[Column("SelectedSecondarySkill")]
        public string? SelectedSecondarySkill { get; set; }
        //[Column("SkillCertificateValue")]
        public string? SkillCertificateValue { get; set; }
        public string? CreatedOn { get; set; } = DateTime.Now.ToString();
        public string? UpdatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }

    }
}
