﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dal
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities2 : DbContext
    {
        public Entities2()
            : base("name=Entities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<College> College { get; set; }
        public virtual DbSet<Conversation> Conversation { get; set; }
        public virtual DbSet<ConversationStatus> ConversationStatus { get; set; }
        public virtual DbSet<Diploma> Diploma { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EResource> EResource { get; set; }
        public virtual DbSet<Faculty> Faculty { get; set; }
        public virtual DbSet<Intersted> Intersted { get; set; }
        public virtual DbSet<PersonStatus> PersonStatus { get; set; }
        public virtual DbSet<PLogging> PLogging { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<Preparatory> Preparatory { get; set; }
        public virtual DbSet<Question> Question { get; set; }
        public virtual DbSet<Repository> Repository { get; set; }
        public virtual DbSet<Resource> Resource { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<Visitors_Day> Visitors_Day { get; set; }
        public virtual DbSet<VLogging> VLogging { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
