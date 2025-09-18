namespace Willie.Models
{
    using System.ComponentModel.DataAnnotations;

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
