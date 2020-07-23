namespace Tez.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RandevuModel : DbContext
    {
        public RandevuModel()
            : base("name=RandevuModel")
        {
        }

        public virtual DbSet<Randevu> Randevu { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Randevu>()
                .Property(e => e.Randevu_AD)
                .IsUnicode(false);

            modelBuilder.Entity<Randevu>()
                .Property(e => e.Randevu_SOYAD)
                .IsUnicode(false);

            modelBuilder.Entity<Randevu>()
                .Property(e => e.Randevu_TEL)
                .IsUnicode(false);

            modelBuilder.Entity<Randevu>()
                .Property(e => e.Randevu_EPOSTA)
                .IsUnicode(false);

            modelBuilder.Entity<Randevu>()
                .Property(e => e.Randevu_TÜR)
                .IsUnicode(false);

            modelBuilder.Entity<Randevu>()
                .Property(e => e.Randevu_SAAT)
                .IsUnicode(false);
        }
    }
}
