﻿// <auto-generated />
using System;
using CSP.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CSP.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CSP.Shared.CSPProfileInfo", b =>
                {
                    b.Property<int>("ProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProfileId"));

                    b.Property<string>("AcademicCertificationsValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AllowEnterDataOfIncorporation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyGSTCert")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyGSTNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyINCertNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyINCertValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyLogo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyOfferingsAndDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyPAN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyPANCert")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyRegistrationDocValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("CurrentLocationMAP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirmCertificationsValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OfficeAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OfficeAddressProofType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SelectedCompetency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SelectedSkill")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkillCertificationsEntered")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkillCertificationsValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedBy")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProfileId");

                    b.ToTable("CSPProfiles");
                });

            modelBuilder.Entity("CSP.Shared.GeekProfileInfo", b =>
                {
                    b.Property<int>("GeekProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GeekProfileId"));

                    b.Property<string>("AcademicCertificationsValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedOn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HighestQualification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HighestQualificationCertValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileBriefDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePhoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SelectedPreferredLanguage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SelectedPrimarySkill")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SelectedSecondarySkill")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkillCertificateValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedOn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GeekProfileId");

                    b.ToTable("GeekProfiles");
                });
#pragma warning restore 612, 618
        }
    }
}
