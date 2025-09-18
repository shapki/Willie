namespace Willie.Models
{
    using System.ComponentModel.DataAnnotations;

    public partial class hits
    {
        [Key]
        public int idHit { get; set; }

        [Required]
        [StringLength(250)]
        public string descriptionHit { get; set; }
    }
}
