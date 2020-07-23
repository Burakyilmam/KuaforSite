namespace Tez.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Randevu")]
    public partial class Randevu
    {
        [Key]
        public int Randevu_ID { get; set; }

        [StringLength(50)]
        public string Randevu_AD { get; set; }

        [StringLength(100)]
        public string Randevu_SOYAD { get; set; }

        [StringLength(50)]
        public string Randevu_TEL { get; set; }

        [StringLength(100)]
        public string Randevu_EPOSTA { get; set; }

        [StringLength(50)]
        public string Randevu_TÜR { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Randevu_TARİH { get; set; }

        [StringLength(50)]
        public string Randevu_SAAT { get; set; }
    }
}
