﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Login
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class progPOEEntities1 : DbContext
    {
        public progPOEEntities1()
            : base("name=progPOEEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Lecturer> Lecturers { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Student_Course> Student_Course { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<Test_Student> Test_Student { get; set; }
    }
}