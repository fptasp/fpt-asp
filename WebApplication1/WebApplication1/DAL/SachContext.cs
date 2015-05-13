using System;
using WebApplication1.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using WebApplication1.Controllers;

namespace WebApplication1.DAL
{
    public class SachContext : DbContext
    {
    
        public SachContext() : base("SachContext")
        {
        }

        public DbSet<Sach> Sachs { get; set; }
        public DbSet<LinkNhaXB> LinkNhaXBs { get; set; }
        public DbSet<LinkTacgia> LinkTacgias { get; set; }
        public DbSet<LinkLoaiSach> LinkLoaiSachs { get; set; }
        public DbSet<NhaXB> NhaXBs { get; set; }
        public DbSet<Tacgia> Tacgias { get; set; }
        public DbSet<LoaiSach> LoaiSachs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}