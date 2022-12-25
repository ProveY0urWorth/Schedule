﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Schv3.Data;

#nullable disable

namespace Schv3.Migrations
{
    [DbContext(typeof(AppDataDbContext))]
    [Migration("20221225114628_AddedGroupIdToSchedule")]
    partial class AddedGroupIdToSchedule
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("Schv3.Models.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClassType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Comment")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Id_Classroom")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Id_SubjectId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Id_TeacherId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Id_SubjectId");

                    b.HasIndex("Id_TeacherId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("Schv3.Models.ClassRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Building")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Size")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Classrooms");
                });

            modelBuilder.Entity("Schv3.Models.Group", b =>
                {
                    b.Property<string>("GroupCode")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ClassId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Institute")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("course")
                        .HasColumnType("INTEGER");

                    b.Property<int>("education")
                        .HasColumnType("INTEGER");

                    b.Property<int>("study_form")
                        .HasColumnType("INTEGER");

                    b.HasKey("GroupCode");

                    b.HasIndex("ClassId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Schv3.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Group_idGroupCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Id_1ClassId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Id_2ClassId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Id_3ClassId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Id_4ClassId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Id_5ClassId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Id_6ClassId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Id_7ClassId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Id_8ClassId")
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("date")
                        .HasColumnType("TEXT");

                    b.Property<int>("week")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Group_idGroupCode");

                    b.HasIndex("Id_1ClassId");

                    b.HasIndex("Id_2ClassId");

                    b.HasIndex("Id_3ClassId");

                    b.HasIndex("Id_4ClassId");

                    b.HasIndex("Id_5ClassId");

                    b.HasIndex("Id_6ClassId");

                    b.HasIndex("Id_7ClassId");

                    b.HasIndex("Id_8ClassId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("Schv3.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Hours")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("Schv3.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Post")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("SubjectId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Schv3.Models.Class", b =>
                {
                    b.HasOne("Schv3.Models.Subject", "Id_Subject")
                        .WithMany()
                        .HasForeignKey("Id_SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Schv3.Models.Teacher", "Id_Teacher")
                        .WithMany()
                        .HasForeignKey("Id_TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Id_Subject");

                    b.Navigation("Id_Teacher");
                });

            modelBuilder.Entity("Schv3.Models.Group", b =>
                {
                    b.HasOne("Schv3.Models.Class", null)
                        .WithMany("Group_Code")
                        .HasForeignKey("ClassId");
                });

            modelBuilder.Entity("Schv3.Models.Schedule", b =>
                {
                    b.HasOne("Schv3.Models.Group", "Group_id")
                        .WithMany()
                        .HasForeignKey("Group_idGroupCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Schv3.Models.Class", "Id_1Class")
                        .WithMany()
                        .HasForeignKey("Id_1ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Schv3.Models.Class", "Id_2Class")
                        .WithMany()
                        .HasForeignKey("Id_2ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Schv3.Models.Class", "Id_3Class")
                        .WithMany()
                        .HasForeignKey("Id_3ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Schv3.Models.Class", "Id_4Class")
                        .WithMany()
                        .HasForeignKey("Id_4ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Schv3.Models.Class", "Id_5Class")
                        .WithMany()
                        .HasForeignKey("Id_5ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Schv3.Models.Class", "Id_6Class")
                        .WithMany()
                        .HasForeignKey("Id_6ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Schv3.Models.Class", "Id_7Class")
                        .WithMany()
                        .HasForeignKey("Id_7ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Schv3.Models.Class", "Id_8Class")
                        .WithMany()
                        .HasForeignKey("Id_8ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group_id");

                    b.Navigation("Id_1Class");

                    b.Navigation("Id_2Class");

                    b.Navigation("Id_3Class");

                    b.Navigation("Id_4Class");

                    b.Navigation("Id_5Class");

                    b.Navigation("Id_6Class");

                    b.Navigation("Id_7Class");

                    b.Navigation("Id_8Class");
                });

            modelBuilder.Entity("Schv3.Models.Teacher", b =>
                {
                    b.HasOne("Schv3.Models.Subject", null)
                        .WithMany("Id_teacher")
                        .HasForeignKey("SubjectId");
                });

            modelBuilder.Entity("Schv3.Models.Class", b =>
                {
                    b.Navigation("Group_Code");
                });

            modelBuilder.Entity("Schv3.Models.Subject", b =>
                {
                    b.Navigation("Id_teacher");
                });
#pragma warning restore 612, 618
        }
    }
}
