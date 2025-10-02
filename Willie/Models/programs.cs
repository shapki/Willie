namespace Willie.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class programs
    {
        [Key]
        public int idProgram { get; set; }

        public int studentOneBoxerId { get; set; }

        public int studentTwoBoxerId { get; set; }

        [Required]
        [StringLength(50)]
        public string hits { get; set; }

        public virtual boxerTypes boxerTypes { get; set; }

        public virtual boxerTypes boxerTypes1 { get; set; }
    }
}
