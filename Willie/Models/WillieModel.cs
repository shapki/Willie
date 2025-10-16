using System.Data.Entity;

namespace Willie.Models
{
    public partial class WillieModel : DbContext
    {

        public WillieModel()
            : base("name=WillieModel")
        {
        }

        public virtual DbSet<boxerTypes> boxerTypes { get; set; }
        public virtual DbSet<dominantHand> dominantHand { get; set; }
        public virtual DbSet<gender> gender { get; set; }
        public virtual DbSet<hits> hits { get; set; }
        public virtual DbSet<programs> programs { get; set; }
        public virtual DbSet<students> students { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<trainingHistory> trainingHistory { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<boxerTypes>()
                .HasMany(e => e.programs)
                .WithRequired(e => e.boxerTypes)
                .HasForeignKey(e => e.studentOneBoxerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<boxerTypes>()
                .HasMany(e => e.programs1)
                .WithRequired(e => e.boxerTypes1)
                .HasForeignKey(e => e.studentTwoBoxerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<dominantHand>()
                .HasMany(e => e.students)
                .WithRequired(e => e.dominantHand)
                .HasForeignKey(e => e.DominantHandId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<gender>()
                .HasMany(e => e.students)
                .WithRequired(e => e.gender)
                .HasForeignKey(e => e.genderId)
                .WillCascadeOnDelete(false);
        }
    }
}
