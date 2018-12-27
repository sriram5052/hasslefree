﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using hasslefreeAPI.Entities;

namespace hasslefreeAPI.Migrations
{
    [DbContext(typeof(HassleFreeContext))]
    partial class HassleFreeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("hasslefreeAPI.Entities.Accounts", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AccountID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountName")
                        .IsRequired();

                    b.Property<int?>("CampaignId")
                        .HasColumnName("CampaignID");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("smalldatetime");

                    b.Property<string>("DetailDescription");

                    b.Property<string>("Employees")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<bool?>("FlagActive")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.Property<short?>("IndustryId")
                        .HasColumnName("IndustryID");

                    b.Property<short?>("IndustrySubTypeId")
                        .HasColumnName("IndustrySubTypeID");

                    b.Property<short?>("LeadSource");

                    b.Property<int>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDateTime")
                        .HasColumnType("smalldatetime");

                    b.Property<int?>("ParentId")
                        .HasColumnName("ParentID");

                    b.Property<string>("Turnover")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Type")
                        .HasMaxLength(50);

                    b.Property<string>("Website")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("WorkPhoneAlternate")
                        .HasColumnName("WorkPhone_Alternate")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("WorkPhoneMain")
                        .HasColumnName("WorkPhone_Main")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.HasKey("AccountId");

                    b.ToTable("Accounts","dbo");
                });

            modelBuilder.Entity("hasslefreeAPI.Entities.Activities", b =>
                {
                    b.Property<int>("ActivityId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ActivityEndTime")
                        .HasColumnType("smalldatetime");

                    b.Property<string>("ActivityLocation")
                        .IsRequired();

                    b.Property<int?>("ActivityOwner");

                    b.Property<DateTime>("ActivityStartTime")
                        .HasColumnType("smalldatetime");

                    b.Property<short>("ActivitySubTypeId");

                    b.Property<string>("ActivityTitle")
                        .IsRequired();

                    b.Property<short>("ActivityTypeId");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("smalldatetime");

                    b.Property<bool?>("FlagActive")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.Property<int>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDateTime")
                        .HasColumnType("smalldatetime");

                    b.Property<int?>("ReferenceId")
                        .HasColumnName("ReferenceID");

                    b.Property<int?>("Source");

                    b.Property<short>("StatusId");

                    b.HasKey("ActivityId");

                    b.ToTable("Activities","dbo");
                });

            modelBuilder.Entity("hasslefreeAPI.Entities.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AddressID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId")
                        .HasColumnName("AccountID");

                    b.Property<string>("AddressLine1");

                    b.Property<string>("AddressLine2");

                    b.Property<string>("AddressLine3");

                    b.Property<string>("City")
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .HasMaxLength(50);

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("smalldatetime");

                    b.Property<bool?>("FlagActive")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("Landmark")
                        .HasMaxLength(100);

                    b.Property<int>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDateTime")
                        .HasColumnType("smalldatetime");

                    b.Property<string>("Pincode")
                        .HasMaxLength(50);

                    b.Property<string>("Remarks")
                        .HasMaxLength(100);

                    b.Property<string>("State")
                        .HasMaxLength(50);

                    b.Property<int?>("Type");

                    b.HasKey("AddressId");

                    b.HasIndex("AccountId");

                    b.ToTable("Address","dbo");
                });

            modelBuilder.Entity("hasslefreeAPI.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("hasslefreeAPI.Entities.Competitors", b =>
                {
                    b.Property<int>("CompetitorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("Amount")
                        .HasColumnType("money");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("smalldatetime");

                    b.Property<bool?>("FlagActive")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.Property<int>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDateTime")
                        .HasColumnType("smalldatetime");

                    b.Property<string>("Name")
                        .IsUnicode(false);

                    b.Property<int?>("RefernceId");

                    b.Property<string>("Remarks")
                        .IsUnicode(false);

                    b.Property<int?>("Source");

                    b.HasKey("CompetitorId");

                    b.ToTable("Competitors","dbo");
                });

            modelBuilder.Entity("hasslefreeAPI.Entities.Contacts", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ContactID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AccountId")
                        .HasColumnName("AccountID");

                    b.Property<string>("AddressLine1")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("AddressLine2")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("AddressLine3")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<int?>("CampaignId")
                        .HasColumnName("CampaignID");

                    b.Property<string>("City")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("ContactFirstName")
                        .IsUnicode(false);

                    b.Property<string>("ContactLastName")
                        .IsUnicode(false);

                    b.Property<short?>("ContactTypeId");

                    b.Property<short?>("Country");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("smalldatetime");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Department")
                        .IsUnicode(false);

                    b.Property<string>("Designation")
                        .IsUnicode(false);

                    b.Property<string>("Email")
                        .IsUnicode(false);

                    b.Property<string>("Facebook")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<bool?>("FlagActive")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.Property<int>("GenderId")
                        .HasColumnName("GenderID");

                    b.Property<string>("GooglePlus")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("MobilePhone")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDateTime")
                        .HasColumnType("smalldatetime");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("State")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Twitter")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("WorkPhone")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("ContactId");

                    b.HasIndex("AccountId");

                    b.ToTable("Contacts","dbo");
                });

            modelBuilder.Entity("hasslefreeAPI.Entities.Documents", b =>
                {
                    b.Property<int>("DocumentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("smalldatetime");

                    b.Property<string>("FileName")
                        .IsRequired();

                    b.Property<bool?>("FlagActive")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.Property<int>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDateTime")
                        .HasColumnType("smalldatetime");

                    b.Property<int?>("ReferenceId");

                    b.Property<int?>("Source");

                    b.Property<string>("Type")
                        .HasMaxLength(50);

                    b.HasKey("DocumentId");

                    b.ToTable("Documents","dbo");
                });

            modelBuilder.Entity("hasslefreeAPI.Entities.Leads", b =>
                {
                    b.Property<int>("LeadId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AccountId")
                        .HasColumnName("AccountID");

                    b.Property<string>("AddressLine1")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("AddressLine2")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("AddressLine3")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("City")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("CompanyAddressLine1")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("CompanyAddressLine2")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("CompanyAddressLine3")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("CompanyCity")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<short?>("CompanyCountry");

                    b.Property<string>("CompanyName")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("CompanyPostalCode")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("CompanyState")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("CompanyTurnover")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("CompanyWebsite")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<int?>("ContactId")
                        .HasColumnName("ContactID");

                    b.Property<bool?>("Converted")
                        .HasColumnName("CONVERTED");

                    b.Property<short?>("Country");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("smalldatetime");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("DetailDescription");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<bool?>("FlagActive")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.Property<short?>("IndustryId")
                        .HasColumnName("IndustryID");

                    b.Property<short?>("IndustrySubTypeId")
                        .HasColumnName("IndustrySubTypeID");

                    b.Property<DateTime?>("LeadDate")
                        .HasColumnType("smalldatetime");

                    b.Property<string>("LeadFirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("LeadLastName")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<int?>("LeadOwnerExecutiveId");

                    b.Property<short?>("LeadSource");

                    b.Property<string>("MobilePhone")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDateTime")
                        .HasColumnType("smalldatetime");

                    b.Property<int?>("OpportunityId")
                        .HasColumnName("OpportunityID");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<short?>("SalesStage");

                    b.Property<short?>("Salutation");

                    b.Property<string>("State")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("WorkPhone")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("LeadId");

                    b.HasIndex("AccountId");

                    b.ToTable("Leads","dbo");
                });

            modelBuilder.Entity("hasslefreeAPI.Entities.Notes", b =>
                {
                    b.Property<int>("NotesId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActivityId");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("smalldatetime");

                    b.Property<bool>("FlagActive");

                    b.Property<int>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDateTime")
                        .HasColumnType("smalldatetime");

                    b.Property<string>("Notes1")
                        .IsRequired()
                        .HasColumnName("Notes");

                    b.HasKey("NotesId");

                    b.ToTable("Notes","dbo");
                });

            modelBuilder.Entity("hasslefreeAPI.Entities.ProductList", b =>
                {
                    b.Property<int>("ProductListId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("Amount")
                        .HasColumnType("money");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("smalldatetime");

                    b.Property<double?>("Discount");

                    b.Property<bool?>("FlagActive")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.Property<int>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDateTime")
                        .HasColumnType("smalldatetime");

                    b.Property<int>("ProductId");

                    b.Property<short?>("Quantity");

                    b.Property<decimal?>("Rate")
                        .HasColumnType("money");

                    b.Property<int?>("ReferenceId")
                        .HasColumnName("ReferenceID");

                    b.Property<int?>("Source");

                    b.Property<decimal?>("TaxAmount")
                        .HasColumnType("money");

                    b.Property<short?>("Uom")
                        .HasColumnName("UOM");

                    b.HasKey("ProductListId");

                    b.ToTable("ProductList","dbo");
                });

            modelBuilder.Entity("hasslefreeAPI.Entities.Products", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("smalldatetime");

                    b.Property<bool?>("FlagActive")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.Property<int>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDateTime")
                        .HasColumnType("smalldatetime");

                    b.Property<string>("Name")
                        .IsUnicode(false);

                    b.Property<short>("ProductType");

                    b.Property<decimal?>("Rate")
                        .HasColumnType("money");

                    b.HasKey("ProductId");

                    b.ToTable("Products","dbo");
                });

            modelBuilder.Entity("hasslefreeAPI.Entities.ReferenceLookup", b =>
                {
                    b.Property<short>("ReferenceLookupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ReferenceLookupID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("smalldatetime");

                    b.Property<bool?>("FlagActive")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.Property<int>("ModifiedBy");

                    b.Property<DateTime>("ModifiedDateTime")
                        .HasColumnType("smalldatetime");

                    b.Property<short?>("OrderId");

                    b.Property<string>("SubCategory")
                        .HasMaxLength(50);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("ReferenceLookupId");

                    b.ToTable("ReferenceLookup","dbo");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("hasslefreeAPI.Entities.Address", b =>
                {
                    b.HasOne("hasslefreeAPI.Entities.Accounts", "Account")
                        .WithMany("Address")
                        .HasForeignKey("AccountId")
                        .HasConstraintName("FK_dbo.Address_dbo.Accounts_AccountID");
                });

            modelBuilder.Entity("hasslefreeAPI.Entities.Contacts", b =>
                {
                    b.HasOne("hasslefreeAPI.Entities.Accounts", "Account")
                        .WithMany("Contacts")
                        .HasForeignKey("AccountId")
                        .HasConstraintName("FK_dbo.Contacts_dbo.Accounts_AccountID");
                });

            modelBuilder.Entity("hasslefreeAPI.Entities.Leads", b =>
                {
                    b.HasOne("hasslefreeAPI.Entities.Accounts", "Account")
                        .WithMany("Leads")
                        .HasForeignKey("AccountId")
                        .HasConstraintName("FK_dbo.Leads_dbo.Accounts_AccountID");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("hasslefreeAPI.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("hasslefreeAPI.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("hasslefreeAPI.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("hasslefreeAPI.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
