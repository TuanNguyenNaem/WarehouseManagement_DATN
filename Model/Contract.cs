﻿namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contract")]
    public partial class Contract
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contract()
        {
            ContractDetails = new HashSet<ContractDetail>();
        }

        public int ContractID { get; set; }

        public int EmployeeID { get; set; }

        public int SupplierID { get; set; }

        [Column(TypeName = "date")]
        public DateTime CreateDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime DeliveryDate { get; set; }

        [Required]
        [StringLength(15)]
        public string Status { get; set; }

        [StringLength(100)]
        public string Notes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractDetail> ContractDetails { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Supplier Supplier { get; set; }

        public virtual EnterWarehouse EnterWarehouse { get; set; }
    }
}
