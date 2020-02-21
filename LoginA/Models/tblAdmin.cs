namespace LoginA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblAdmin")]
    public partial class tblAdmin
    {
        public int id { get; set; }

        public string admin_id { get; set; }

        [StringLength(100)]
        public string ad_soyad { get; set; }

        [StringLength(55)]
        public string eposta { get; set; }

        [StringLength(25)]
        public string rol { get; set; }

        [StringLength(50)]
        public string parolatekrar { get; set; }

        [StringLength(50)]
        public string parola { get; set; }

        public int? durum { get; set; }

        public string foto { get; set; }
    }
}
