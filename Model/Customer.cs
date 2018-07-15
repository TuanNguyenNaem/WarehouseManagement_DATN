namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerID { get; set; }

        [Required]
        [StringLength(50)]
        public string CustomerName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BirthDate { get; set; }

        [StringLength(5)]
        public string Gender { get; set; }

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

        [Column(TypeName = "money")]
        public decimal Accumulation { get; set; }

        public int VIPID { get; set; }

        [Required]
        [StringLength(100)]
        public string Area { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(100)]
        public string Notes { get; set; }

        public virtual VIP VIP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
