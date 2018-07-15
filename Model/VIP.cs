namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VIP")]
    public partial class VIP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VIP()
        {
            Customers = new HashSet<Customer>();
        }

        public int VIPID { get; set; }

        [Required]
        [StringLength(5)]
        public string VIPName { get; set; }

        [Column(TypeName = "money")]
        public decimal Accumulation { get; set; }

        public byte ReduceInvoice { get; set; }

        [Required]
        [StringLength(6)]
        public string Unit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
