using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class WarehouseDetail
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        [Column(TypeName = "money")]
        public decimal ImportPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal Retail { get; set; }

        [Column(TypeName = "money")]
        public decimal Wholesale { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public int Quantity { get; set; }
        public int QuantityExactly{get; set;}
    }
}
