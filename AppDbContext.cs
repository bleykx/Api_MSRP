using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API_MSPR.Model;

namespace API_MSPR
{
    public class AppDbContext : DbContext
    {
        public DbSet<QRCode> QRCodes { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<InfoQR> InfoQRs { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) //En passant une instance de DbContextOptions<Type>, on va permettre la configuration depuis "l'extérieur" et éviter ainsi d'overrider OnConfiguring
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var QRCodeEntity = modelBuilder.Entity<QRCode>();

            QRCodeEntity.HasKey(a => a.ID);

            var PromotionEntity = modelBuilder.Entity<Promotion>();

            PromotionEntity.HasKey(p => p.ID);

            var InfoQREntity = modelBuilder.Entity<InfoQR>();

            InfoQREntity.HasKey(i => new { i.IdPromo, i.IdQRCode });

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ApiMSPR;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            base.OnConfiguring(optionsBuilder);
        }
    }
}