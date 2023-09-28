﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Asp_dotnetCore_masterDetails.Models;

#nullable disable

namespace Asp_dotnetCore_masterDetails.Migrations
{
    [DbContext(typeof(CandidateDbContext))]
    [Migration("20230511040528_ScriptA")]
    partial class ScriptA
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Asp_dotnetCore_masterDetails.Models.Candidate", b =>
                {
                    b.Property<int>("CandidateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CandidateId"), 1L, 1);

                    b.Property<string>("CandidateName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Fresher")
                        .HasColumnType("bit");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CandidateId");

                    b.ToTable("Candidates");
                });

            modelBuilder.Entity("Asp_dotnetCore_masterDetails.Models.CandidateSkills", b =>
                {
                    b.Property<int>("CandidateSkillsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CandidateSkillsId"), 1L, 1);

                    b.Property<int>("CandidateId")
                        .HasColumnType("int");

                    b.Property<int>("SkillsId")
                        .HasColumnType("int");

                    b.HasKey("CandidateSkillsId");

                    b.HasIndex("CandidateId");

                    b.HasIndex("SkillsId");

                    b.ToTable("CandidateSkills");
                });

            modelBuilder.Entity("Asp_dotnetCore_masterDetails.Models.Skills", b =>
                {
                    b.Property<int>("SkillsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SkillsId"), 1L, 1);

                    b.Property<string>("SkillsName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SkillsId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("Asp_dotnetCore_masterDetails.Models.CandidateSkills", b =>
                {
                    b.HasOne("Asp_dotnetCore_masterDetails.Models.Candidate", "Candidate")
                        .WithMany("CandidateSkills")
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Asp_dotnetCore_masterDetails.Models.Skills", "Skills")
                        .WithMany("CandidateSkills")
                        .HasForeignKey("SkillsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidate");

                    b.Navigation("Skills");
                });

            modelBuilder.Entity("Asp_dotnetCore_masterDetails.Models.Candidate", b =>
                {
                    b.Navigation("CandidateSkills");
                });

            modelBuilder.Entity("Asp_dotnetCore_masterDetails.Models.Skills", b =>
                {
                    b.Navigation("CandidateSkills");
                });
#pragma warning restore 612, 618
        }
    }
}
