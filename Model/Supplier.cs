namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Supplier")]
    public partial class Supplier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supplier()
        {
            Contracts = new HashSet<Contract>();
            Products = new HashSet<Product>();
        }

        public int SupplierID { get; set; }

        [Required]
        [StringLength(100)]
        public string SupplierName { get; set; }

        [Required]
        [StringLength(100)]
        public string Address { get; set; }

        [Required]
        [StringLength(11)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(40)]
        public string AccountNumber { get; set; }

        [Required]
        [StringLength(20)]
        public string TaxCode { get; set; }

        [Required]
        [StringLength(100)]
        public string Area { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(100)]
        public string Notes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contract> Contracts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
