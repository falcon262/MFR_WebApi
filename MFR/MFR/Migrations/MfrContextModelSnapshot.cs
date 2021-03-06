// <auto-generated />
using System;
using MFR.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MFR.Migrations
{
    [DbContext(typeof(MfrContext))]
    partial class MfrContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "Latin1_General_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MFR.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AltContactEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AltContactName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AltContactPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BoardChairName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CeoName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CfoName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExpectedRotationYear")
                        .HasColumnType("datetime2");

                    b.Property<string>("GlobalGroupAuditor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IndustryId")
                        .HasColumnType("int");

                    b.Property<bool>("IsAltContactAlumni")
                        .HasColumnType("bit");

                    b.Property<bool>("IsClientSalesforce")
                        .HasColumnType("bit");

                    b.Property<bool>("IsContactAlumni")
                        .HasColumnType("bit");

                    b.Property<bool>("IsListedOnGhanaAlternativeMarket")
                        .HasColumnType("bit");

                    b.Property<bool>("IsListedOnStockExchange")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSecRegistrant")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentCompanyCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PredecessorAuditor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RotationLawId")
                        .HasColumnType("int");

                    b.Property<int?>("SubIndustryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "IndustryId" }, "IX_Client_IndustryId");

                    b.HasIndex(new[] { "RotationLawId" }, "IX_Client_RotationLawId");

                    b.HasIndex(new[] { "SubIndustryId" }, "IX_Client_SubIndustryId");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("MFR.Models.Industry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Industry");
                });

            modelBuilder.Entity("MFR.Models.RotationLaw", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CoolingPeriod")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RotationPeriod")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("RotationLaw");
                });

            modelBuilder.Entity("MFR.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "ClientId" }, "IX_Service_ClientId");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("MFR.Models.Client", b =>
                {
                    b.HasOne("MFR.Models.Industry", "Industry")
                        .WithMany("ClientIndustries")
                        .HasForeignKey("IndustryId");

                    b.HasOne("MFR.Models.RotationLaw", "RotationLaw")
                        .WithMany("Clients")
                        .HasForeignKey("RotationLawId");

                    b.HasOne("MFR.Models.Industry", "SubIndustry")
                        .WithMany("ClientSubIndustries")
                        .HasForeignKey("SubIndustryId");

                    b.Navigation("Industry");

                    b.Navigation("RotationLaw");

                    b.Navigation("SubIndustry");
                });

            modelBuilder.Entity("MFR.Models.Industry", b =>
                {
                    b.Navigation("ClientIndustries");

                    b.Navigation("ClientSubIndustries");
                });

            modelBuilder.Entity("MFR.Models.RotationLaw", b =>
                {
                    b.Navigation("Clients");
                });
#pragma warning restore 612, 618
        }
    }
}
