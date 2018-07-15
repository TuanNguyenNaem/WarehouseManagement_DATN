namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Warehouse")]
    public partial class Warehouse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }

        public int Quantity { get; set; }

        public int QuantityExactly { get; set; }

        public virtual Product Product { get; set; }
    }
}
