using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeacherMVCCore.Models
{

    public partial class TeacherContext : DbContext
    {
        public TeacherContext()
        {
        }

        public TeacherContext(DbContextOptions<TeacherContext> options)
            : base(options)
        {
        }

        public virtual DbSet<StudentInfo> StudentInfos { get; set; }
        public virtual DbSet<TeacherInfo> TeacherInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // optionsBuilder.UseSqlServer("Server=DESKTOP-RHVL91S\\SQLEXPRESS1;Database=Teacher;User Id=sa; Password=Sql123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<StudentInfo>(entity =>
            {
                entity.HasKey(e => e.StudentId);

                entity.ToTable("StudentInfo");

                entity.Property(e => e.StudentId).ValueGeneratedNever();

                entity.Property(e => e.Grade).HasMaxLength(50);

                entity.Property(e => e.StudentName).HasMaxLength(50);
            });

            modelBuilder.Entity<TeacherInfo>(entity =>
            {
                entity.HasKey(e => e.TeacherId);

                entity.ToTable("TeacherInfo");

                entity.Property(e => e.TeacherId).ValueGeneratedNever();

                entity.Property(e => e.TeacherName).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
