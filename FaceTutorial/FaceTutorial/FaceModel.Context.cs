﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FaceTutorial
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PersonEntities1 : DbContext
    {
        public PersonEntities1()
            : base("name=PersonEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<persondata> persondata { get; set; }
        public virtual DbSet<PersonItem> PersonItem { get; set; }
    }
}
