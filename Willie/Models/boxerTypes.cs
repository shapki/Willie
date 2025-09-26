namespace Willie.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class boxerTypes
    {
        [Key]
        public int idBoxer { get; set; }

        [Required]
        [StringLength(80)]
        public string boxerType { get; set; }
    }
}
