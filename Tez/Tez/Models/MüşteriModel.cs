namespace Tez.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MüşteriModel : DbContext
    {
        public MüşteriModel()
            : base("name=MüşteriModel")
        {
        }

        public virtual DbSet<Müşteri> Müşteri { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Müşteri>()
                .Property(e => e.Müşteri_AD)
                .IsUnicode(false);

            modelBuilder.Entity<Müşteri>()
                .Property(e => e.Müşteri_SOYAD)
                .IsUnicode(false);

            modelBuilder.Entity<Müşteri>()
                .Property(e => e.Müşteri_KULLANICI)
                .IsUnicode(false);

            modelBuilder.Entity<Müşteri>()
                .Property(e => e.Müşteri_ŞİFRE)
                .IsUnicode(false);

            modelBuilder.Entity<Müşteri>()
                .Property(e => e.Müşteri_TEL)
                .IsUnicode(false);

            modelBuilder.Entity<Müşteri>()
                .Property(e => e.Müşteri_EPOSTA)
                .IsUnicode(false);
        }
    }
}
