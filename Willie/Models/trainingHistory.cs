namespace Willie.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("trainingHistory")]
    public partial class trainingHistory
    {
        [Key]
        public int idHistory { get; set; }

        [Column(TypeName = "date")]
        public DateTime date { get; set; }

        public int studentOneId { get; set; }

        public int studentTwoBoxerId { get; set; }

        public int programId { get; set; }

        [StringLength(250)]
        public string comment { get; set; }
    }
}
