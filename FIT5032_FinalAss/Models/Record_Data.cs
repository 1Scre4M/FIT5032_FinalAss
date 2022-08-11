namespace FIT5032_FinalAss.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Record_Data
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(50)]
        public string first_name { get; set; }

        [StringLength(50)]
        public string gender { get; set; }

        [StringLength(50)]
        public string ICD10 { get; set; }

        [StringLength(50)]
        public string Drug { get; set; }
    }
}
