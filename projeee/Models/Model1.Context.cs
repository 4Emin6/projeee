﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace projeee.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class projesqlEntities : DbContext
    {
        public projesqlEntities()
            : base("name=projesqlEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Kullancılar> Kullancılar { get; set; }
        public virtual DbSet<MaçDetay> MaçDetay { get; set; }
        public virtual DbSet<Maçlar> Maçlar { get; set; }
        public virtual DbSet<Oyuncular> Oyuncular { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Takımlar> Takımlar { get; set; }
        public virtual DbSet<Turnuvalar> Turnuvalar { get; set; }
        public virtual DbSet<YetkiTürleri> YetkiTürleri { get; set; }
    }
}