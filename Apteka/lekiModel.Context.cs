﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Apteka
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class db_lekiContext : DbContext
    {
        public db_lekiContext()
            : base("name=db_lekiContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<t_informacje> t_informacje { get; set; }
        public DbSet<t_inter> t_inter { get; set; }
        public DbSet<t_leki> t_leki { get; set; }
        public DbSet<t_producenci> t_producenci { get; set; }
        public DbSet<t_produkty> t_produkty { get; set; }
        public DbSet<t_refundacja> t_refundacja { get; set; }
        public DbSet<t_sklad> t_sklad { get; set; }
        public DbSet<t_sklepy> t_sklepy { get; set; }
        public DbSet<t_substancje> t_substancje { get; set; }
        public DbSet<t_syno> t_syno { get; set; }
        public DbSet<t_users> t_users { get; set; }
        public DbSet<t_zamowienia> t_zamowienia { get; set; }
        public DbSet<t_CartItems> t_CartItems { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
