﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryForm
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SA45_TEAM08B_LIBRARYEntities1 : DbContext
    {
        public SA45_TEAM08B_LIBRARYEntities1()
            : base("name=SA45_TEAM08B_LIBRARYEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<IssueTran> IssueTrans { get; set; }
        public virtual DbSet<Member> Members { get; set; }
    }
}