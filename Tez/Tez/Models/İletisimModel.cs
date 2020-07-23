namespace Tez.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class İletisimModel : DbContext
    {
        public İletisimModel()
            : base("name=İletisimModel")
        {
        }

        public virtual DbSet<İletisim> İletisim { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<İletisim>()
                .Property(e => e.İletisim_AD)
                .IsUnicode(false);

            modelBuilder.Entity<İletisim>()
                .Property(e => e.İletisim_SOYAD)
                .IsUnicode(false);

            modelBuilder.Entity<İletisim>()
                .Property(e => e.İletisim_TEL)
                .IsUnicode(false);

            modelBuilder.Entity<İletisim>()
                .Property(e => e.İletisim_MESAJ)
                .IsUnicode(false);
        }
    }
}
