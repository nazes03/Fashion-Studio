using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Fashion_Studio
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Cloth> Cloth { get; set; }
        public virtual DbSet<DressMakers> DressMakers { get; set; }
        public virtual DbSet<Model> Model { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<TypeModel> TypeModel { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasMany(e => e.Order)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cloth>()
                .HasMany(e => e.Model)
                .WithRequired(e => e.Cloth)
                .HasForeignKey(e => e.IdRecomendedCloth)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cloth>()
                .HasMany(e => e.Order)
                .WithRequired(e => e.Cloth)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DressMakers>()
                .HasMany(e => e.Order)
                .WithRequired(e => e.DressMakers)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Model>()
                .HasMany(e => e.Order)
                .WithRequired(e => e.Model)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TypeModel>()
                .HasMany(e => e.Model)
                .WithRequired(e => e.TypeModel)
                .WillCascadeOnDelete(false);
        }
    }
}
