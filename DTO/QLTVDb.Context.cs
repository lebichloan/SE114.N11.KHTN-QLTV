﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLTVDb : DbContext
    {

        private static QLTVDb instance;
        public static QLTVDb Instance
        {
            get
            {
                if (instance == null) instance = new QLTVDb();
                return instance;
            }
            set
            { instance = value; }
        }
        public QLTVDb()
            : base("name=QLTVDb")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BCLUOTMUONTHEOTHELOAI> BCLUOTMUONTHEOTHELOAIs { get; set; }
        public virtual DbSet<BCSACHTRATRE> BCSACHTRATREs { get; set; }
        public virtual DbSet<CHUCNANG> CHUCNANGs { get; set; }
        public virtual DbSet<CT_BCLUOTMUONTHEOTHELOAI> CT_BCLUOTMUONTHEOTHELOAI { get; set; }
        public virtual DbSet<CT_PHIEUNHAP> CT_PHIEUNHAP { get; set; }
        public virtual DbSet<CUONSACH> CUONSACHes { get; set; }
        public virtual DbSet<DOCGIA> DOCGIAs { get; set; }
        public virtual DbSet<LOAIDOCGIA> LOAIDOCGIAs { get; set; }
        public virtual DbSet<NGUOIDUNG> NGUOIDUNGs { get; set; }
        public virtual DbSet<NHOMNGUOIDUNG> NHOMNGUOIDUNGs { get; set; }
        public virtual DbSet<PHIEUMUONTRA> PHIEUMUONTRAs { get; set; }
        public virtual DbSet<PHIEUNHAPSACH> PHIEUNHAPSACHes { get; set; }
        public virtual DbSet<PHIEUTHU> PHIEUTHUs { get; set; }
        public virtual DbSet<SACH> SACHes { get; set; }
        public virtual DbSet<TACGIA> TACGIAs { get; set; }
        public virtual DbSet<THAMSO> THAMSOes { get; set; }
        public virtual DbSet<THELOAI> THELOAIs { get; set; }
        public virtual DbSet<TUASACH> TUASACHes { get; set; }
    }
}
