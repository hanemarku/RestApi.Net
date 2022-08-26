﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using restApiProject.Data;

#nullable disable

namespace restApiProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220826153114_newclass")]
    partial class newclass
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ClassLibraryModels.Employee_Project", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId", "ProjectId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Employee_Projects");
                });

            modelBuilder.Entity("ClassLibraryModels.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("ClassLibraryModels.Taskk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("ClassLibraryModels.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            EmailAddress = "null",
                            Lastname = "lastname",
                            Name = "name",
                            PasswordHash = new byte[] { 76, 13, 158, 199, 83, 244, 123, 15, 120, 190, 48, 90, 18, 125, 117, 73, 175, 206, 104, 190, 21, 173, 30, 18, 168, 239, 234, 134, 47, 86, 254, 146, 211, 68, 234, 197, 182, 237, 213, 173, 36, 25, 150, 89, 225, 211, 143, 190, 238, 74, 0, 69, 102, 135, 99, 197, 173, 163, 190, 114, 133, 220, 17, 14 },
                            PasswordSalt = new byte[] { 210, 239, 70, 92, 144, 191, 222, 110, 139, 175, 65, 73, 6, 178, 40, 241, 44, 176, 4, 50, 59, 167, 100, 208, 195, 10, 223, 106, 43, 10, 138, 73, 196, 23, 174, 250, 51, 143, 147, 96, 54, 220, 73, 3, 216, 163, 146, 165, 158, 183, 233, 229, 94, 57, 203, 23, 166, 52, 111, 211, 81, 58, 59, 117, 39, 180, 99, 10, 249, 232, 184, 10, 6, 116, 219, 25, 89, 150, 43, 166, 254, 213, 246, 37, 240, 25, 27, 0, 63, 114, 173, 77, 160, 40, 108, 200, 179, 39, 87, 14, 102, 230, 126, 180, 158, 80, 210, 211, 69, 112, 7, 121, 41, 19, 176, 176, 211, 65, 193, 136, 17, 234, 185, 185, 73, 96, 15, 22 },
                            Role = "Administrator",
                            Username = "administrator"
                        });
                });

            modelBuilder.Entity("EmployeeProject", b =>
                {
                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectsId")
                        .HasColumnType("int");

                    b.HasKey("ProjectId", "ProjectsId");

                    b.HasIndex("ProjectsId");

                    b.ToTable("EmployeeProject");
                });

            modelBuilder.Entity("ClassLibraryModels.Employee", b =>
                {
                    b.HasBaseType("ClassLibraryModels.User");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasIndex("userId");

                    b.HasDiscriminator().HasValue("Employee");
                });

            modelBuilder.Entity("ClassLibraryModels.Employee_Project", b =>
                {
                    b.HasOne("ClassLibraryModels.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassLibraryModels.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("ClassLibraryModels.Taskk", b =>
                {
                    b.HasOne("ClassLibraryModels.Employee", "Employee")
                        .WithMany("Tasks")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassLibraryModels.Project", "Project")
                        .WithMany("Tasks")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("EmployeeProject", b =>
                {
                    b.HasOne("ClassLibraryModels.Employee", null)
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassLibraryModels.Project", null)
                        .WithMany()
                        .HasForeignKey("ProjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClassLibraryModels.Employee", b =>
                {
                    b.HasOne("ClassLibraryModels.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("ClassLibraryModels.Project", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("ClassLibraryModels.Employee", b =>
                {
                    b.Navigation("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
