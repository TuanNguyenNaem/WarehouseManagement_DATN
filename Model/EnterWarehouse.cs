namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EnterWarehouse")]
    public partial class EnterWarehouse
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EnterWarehouseID { get; set; }

        [Column(TypeName = "date")]
        public DateTime EnterDate { get; set; }

        public int EmployeeID { get; set; }

        [Required]
        [StringLength(15)]
        public string Status { get; set; }

        [StringLength(100)]
        public string Notes { get; set; }

        public virtual Contract Contract { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
