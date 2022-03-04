﻿// <auto-generated />
using DeltaSoftTask.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DeltaSoftTask.EF.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DeltaSoftTask.Core.Models.Member", b =>
                {
                    b.Property<int>("Member_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("MemberName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Member_Id");

                    b.ToTable("Members");

                    b.HasData(
                        new
                        {
                            Member_Id = 1,
                            Address = "mansoura",
                            Email = "sara@gmail.com",
                            IsDeleted = false,
                            MemberName = "sara",
                            Phone = "123456987"
                        },
                        new
                        {
                            Member_Id = 2,
                            Address = "mansoura",
                            Email = "hager@gmail.com",
                            IsDeleted = false,
                            MemberName = "hager",
                            Phone = "123456987"
                        },
                        new
                        {
                            Member_Id = 3,
                            Address = "mansoura",
                            Email = "Aya@gmail.com",
                            IsDeleted = false,
                            MemberName = "Aya",
                            Phone = "123456987"
                        },
                        new
                        {
                            Member_Id = 4,
                            Address = "mansoura",
                            Email = "mai@gmail.com",
                            IsDeleted = false,
                            MemberName = "mai",
                            Phone = "123456987"
                        });
                });

            modelBuilder.Entity("DeltaSoftTask.Core.Models.Task", b =>
                {
                    b.Property<int>("Task_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("FK_Member_Id")
                        .HasColumnType("int");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("deliver_date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Task_Id");

                    b.HasIndex("FK_Member_Id");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("DeltaSoftTask.Core.Models.Task", b =>
                {
                    b.HasOne("DeltaSoftTask.Core.Models.Member", "Member")
                        .WithMany()
                        .HasForeignKey("FK_Member_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });
#pragma warning restore 612, 618
        }
    }
}
