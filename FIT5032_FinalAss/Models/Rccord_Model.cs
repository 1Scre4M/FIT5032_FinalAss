using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FIT5032_FinalAss.Models
{
    public partial class Rccord_Model : DbContext
    {
        public Rccord_Model()
            : base("name=Rccord_Model")
        {
        }

        public virtual DbSet<Record_Data> Record_Data { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Record_Data>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<Record_Data>()
                .Property(e => e.gender)
                .IsUnicode(false);

            modelBuilder.Entity<Record_Data>()
                .Property(e => e.ICD10)
                .IsUnicode(false);

            modelBuilder.Entity<Record_Data>()
                .Property(e => e.Drug)
                .IsUnicode(false);
        }
    }
}
