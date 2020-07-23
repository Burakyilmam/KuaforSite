namespace Tez.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class İletisim
    {
        [Key]
        public int İletisim_ID { get; set; }

        [StringLength(50)]
        public string İletisim_AD { get; set; }

        [StringLength(100)]
        public string İletisim_SOYAD { get; set; }

        [StringLength(100)]
        public string İletisim_TEL { get; set; }

        [Column(TypeName = "date")]
        public DateTime? İletisim_TARİH { get; set; }

        [StringLength(300)]
        public string İletisim_MESAJ { get; set; }
    }
}
