﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESchool.Models
{
    public class ESchoolContext : DbContext
    {
        public ESchoolContext(DbContextOptions<ESchoolContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseTeacher>()
               .HasKey(ct => new { ct.TeacherId, ct.CourseId });
        }
        public DbSet<Teacher> ESchools { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<CourseTeacher> CourseTeachers { get; set; }
    }
}
