﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AmicaRentDBEntities : DbContext
    {
        public AmicaRentDBEntities()
            : base("name=AmicaRentDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Arac> Arac { get; set; }
        public virtual DbSet<AracGrup> AracGrup { get; set; }
        public virtual DbSet<AracKasaTipi> AracKasaTipi { get; set; }
        public virtual DbSet<AracMarka> AracMarka { get; set; }
        public virtual DbSet<AracModel> AracModel { get; set; }
        public virtual DbSet<AracRenk> AracRenk { get; set; }
        public virtual DbSet<AracYakitTuru> AracYakitTuru { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Cari> Cari { get; set; }
        public virtual DbSet<CariEhliyet> CariEhliyet { get; set; }
        public virtual DbSet<CariSehir> CariSehir { get; set; }
        public virtual DbSet<CariUyruk> CariUyruk { get; set; }
        public virtual DbSet<EhliyetSinif> EhliyetSinif { get; set; }
        public virtual DbSet<EkstraHizmetler> EkstraHizmetler { get; set; }
        public virtual DbSet<EkSurucu> EkSurucu { get; set; }
        public virtual DbSet<Islem> Islem { get; set; }
        public virtual DbSet<IslemEkstraHizmetler> IslemEkstraHizmetler { get; set; }
        public virtual DbSet<IslemTahsilat> IslemTahsilat { get; set; }
        public virtual DbSet<KanGrubu> KanGrubu { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<Lokasyon> Lokasyon { get; set; }
        public virtual DbSet<OdemeTipi> OdemeTipi { get; set; }
        public virtual DbSet<Servis> Servis { get; set; }
        public virtual DbSet<ServisFirma> ServisFirma { get; set; }
    }
}
