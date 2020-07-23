namespace Tez.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class YorumModel : DbContext
    {
        public YorumModel()
            : base("name=YorumModel")
        {
        }

        public virtual DbSet<Yorum> Yorum { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Yorum>()
                .Property(e => e.Yorum_AD)
                .IsUnicode(false);

            modelBuilder.Entity<Yorum>()
                .Property(e => e.Yorum_SOYAD)
                .IsUnicode(false);

            modelBuilder.Entity<Yorum>()
                .Property(e => e.Yorum_YORUM)
                .IsUnicode(false);

            modelBuilder.Entity<Yorum>()
                .Property(e => e.Hizmet_Türü)
                .IsUnicode(false);
        }
    }
}
