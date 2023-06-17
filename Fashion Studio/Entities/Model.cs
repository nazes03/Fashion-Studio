namespace Fashion_Studio.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Model")]
    public partial class Model
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Model()
        {
            Order = new HashSet<Order>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdModel { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        public int IdRecomendedCloth { get; set; }

        public decimal ClothUsage { get; set; }

        public decimal Price { get; set; }

        [Column(TypeName = "image")]
        public byte[] Photo { get; set; }

        public int IdType { get; set; }

        public virtual Cloth Cloth { get; set; }

        public virtual TypeModel TypeModel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
    }
}
