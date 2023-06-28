namespace Fashion_Studio.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdOrder { get; set; }

        public int IdModel { get; set; }

        public int IdClient { get; set; }

        public int IdCloth { get; set; }

        public int idDressMaker { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateOfStart { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateOfEnd { get; set; }

        public string ClientName
        { get { return Client.Name; } }

        public string ModelTitle
        { get { return Model.Title; } }

        public string ClothTitle
        {  get { return Cloth.Title; } }
        public string DressMakerName
        { get { return DressMakers.Name; } }

        public virtual Client Client { get; set; }

        public virtual Cloth Cloth { get; set; }

        public virtual DressMakers DressMakers { get; set; }

        public virtual Model Model { get; set; }
    }
}