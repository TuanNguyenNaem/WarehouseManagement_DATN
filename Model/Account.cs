namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        public int AccountID { get; set; }

        [Required]
        [StringLength(20)]
        public string UserName { get; set; }

        [Required]
        [StringLength(15)]
        public string Password { get; set; }

        [Required]
        [StringLength(30)]
        public string Role { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
