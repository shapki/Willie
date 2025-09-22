namespace Willie.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class students
    {
        [Key]
        public int idStudent { get; set; }

        [Column(TypeName = "date")]
        public DateTime dateBirth { get; set; }

        [Required]
        [StringLength(150)]
        public string fullName { get; set; }

        [StringLength(50)]
        public string phone { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [Required]
        [StringLength(50)]
        public string numcard { get; set; }

        public int height { get; set; }

        public int DominantHandId { get; set; }

        public int genderId { get; set; }

        public virtual dominantHand dominantHand { get; set; }

        public virtual gender gender { get; set; }

        public bool isNew()
        {
            return idStudent == 0;
        }
    }
}
