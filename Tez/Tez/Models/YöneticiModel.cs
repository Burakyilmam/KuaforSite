namespace Tez.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class YöneticiModel : DbContext
    {
        public YöneticiModel()
            : base("name=YöneticiModel")
        {
        }

        public virtual DbSet<Yönetici> Yönetici { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Yönetici>()
                .Property(e => e.Yönetici_KULLANICI)
                .IsUnicode(false);

            modelBuilder.Entity<Yönetici>()
                .Property(e => e.Yönetici_ŞİFRE)
                .IsUnicode(false);
        }
    }
}
