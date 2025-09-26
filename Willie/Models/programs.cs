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

        [Required]
        [StringLength(250)]
        public string typeProgram { get; set; }

        [Required]
        [StringLength(50)]
        public string hits { get; set; }
    }
}
