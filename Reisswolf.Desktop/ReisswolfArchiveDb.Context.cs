﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Reisswolf.Desktop
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Reisswolf_ArchiveEntities : DbContext
    {
        public Reisswolf_ArchiveEntities()
            : base("name=Reisswolf_ArchiveEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<FIBAIncome> FIBAIncome { get; set; }
        public virtual DbSet<FIBAOutgoing> FIBAOutgoing { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
