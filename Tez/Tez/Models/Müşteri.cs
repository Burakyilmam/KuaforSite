namespace Tez.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Müşteri
    {
        [Key]
        public int Müşteri_ID { get; set; }

        [StringLength(50)]
        public string Müşteri_AD { get; set; }

        [StringLength(100)]
        public string Müşteri_SOYAD { get; set; }

        [StringLength(100)]
        public string Müşteri_KULLANICI { get; set; }

        [StringLength(50)]
        public string Müşteri_ŞİFRE { get; set; }

        [StringLength(11)]
        public String Müşteri_TEL { get; set; }

        [StringLength(100)]
        public String Müşteri_EPOSTA { get; set; }
    }
}
