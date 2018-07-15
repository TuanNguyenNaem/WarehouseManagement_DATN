namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContractDetail")]
    public partial class ContractDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ContractID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }

        public int Quantity { get; set; }

        [Required]
        [StringLength(100)]
        public string Notes { get; set; }

        public virtual Contract Contract { get; set; }

        public virtual Product Product { get; set; }
    }
}
