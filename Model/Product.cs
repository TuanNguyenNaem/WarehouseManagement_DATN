namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            ContractDetails = new HashSet<ContractDetail>();
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int ProductID { get; set; }

        public int CategoryID { get; set; }

        public int SupplierID { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }

        [Required]
        [StringLength(40)]
        public string Color { get; set; }

        [Required]
        [StringLength(4)]
        public string Size { get; set; }

        [Column(TypeName = "money")]
        public decimal ImportPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal Retail { get; set; }

        [Column(TypeName = "money")]
        public decimal Wholesale { get; set; }

        [StringLength(100)]
        public string Notes { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractDetail> ContractDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public virtual Supplier Supplier { get; set; }

        public virtual Warehouse Warehouse { get; set; }
    }
}
