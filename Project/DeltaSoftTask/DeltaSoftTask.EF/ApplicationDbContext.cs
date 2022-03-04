using DeltaSoftTask.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeltaSoftTask.EF
{
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
            {
            }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Member> Members { get; set; }
    }
    
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>().HasData(
                new Member
                {
                    Member_Id = 1,
                    MemberName = "sara",
                    Email = "sara@gmail.com",
                    Address = "mansoura",
                    Phone = "123456987",
                    IsDeleted = false
                },
                new Member
                {
                    Member_Id = 2,
                    MemberName = "hager",
                    Email = "hager@gmail.com",
                    Address = "mansoura",
                    Phone = "123456987",
                    IsDeleted = false
                }
                ,
                new Member
                {
                    Member_Id = 3,
                    MemberName = "Aya",
                    Email = "Aya@gmail.com",
                    Address = "mansoura",
                    Phone = "123456987",
                    IsDeleted = false
                }
                ,
                new Member
                {
                    Member_Id = 4,
                    MemberName = "mai",
                    Email = "mai@gmail.com",
                    Address = "mansoura",
                    Phone = "123456987",
                    IsDeleted = false
                }
            );

        }
    }
}
