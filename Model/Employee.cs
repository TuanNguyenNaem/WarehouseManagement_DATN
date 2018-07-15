namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            Contracts = new HashSet<Contract>();
            EnterWarehouses = new HashSet<EnterWarehouse>();
            OutWarehouses = new HashSet<OutWarehouse>();
            Orders = new HashSet<Order>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeID { get; set; }

        [Required]
        [StringLength(50)]
        public string EmployeeName { get; set; }

        [Column(TypeName = "date")]
        public DateTime BirthDate { get; set; }

        [Required]
        [StringLength(100)]
        public string Address { get; set; }

        [Column(TypeName = "date")]
        public DateTime HireDate { get; set; }

        [StringLength(11)]
        public string PhoneNumber { get; set; }

        [StringLength(5)]
        public string Gender { get; set; }

        [Required]
        [StringLength(15)]
        public string Status { get; set; }

        [StringLength(100)]
        public string Notes { get; set; }

        public virtual Account Account { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contract> Contracts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EnterWarehouse> EnterWarehouses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OutWarehouse> OutWarehouses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
