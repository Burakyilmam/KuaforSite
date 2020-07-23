namespace Tez.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Yorum")]
    public partial class Yorum
    {
        [Key]
        public int Yorum_ID { get; set; }

        [StringLength(50)]
        public string Yorum_AD { get; set; }

        [StringLength(100)]
        public string Yorum_SOYAD { get; set; }

        [StringLength(300)]
        public string Yorum_YORUM { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Yorum_TARİH { get; set; }

        [StringLength(100)]
        public string Hizmet_Türü { get; set; }
    }
}
