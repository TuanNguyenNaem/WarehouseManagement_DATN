using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Model;
using Service;


namespace WarehouseManagement
{
    public partial class formWarehouse : DevExpress.XtraEditors.XtraForm
    {
        IService<Warehouse> warehouse = new WarehouseService();
        IService<Product> product = new ProductService();
        public formWarehouse()
        {
            InitializeComponent();
        }
        private List<WarehouseDetail> LoadWarehouse()
        {
            var ware = warehouse.GetAll();
            List<WarehouseDetail> list = new List<WarehouseDetail>();
            foreach (var item in ware)
            {
                WarehouseDetail wd = new WarehouseDetail()
                {
                    ProductID = item.ProductID,
                    ProductName = product.GetById(item.ProductID).ProductName,
                    Color = product.GetById(item.ProductID).Color,
                    Size = product.GetById(item.ProductID).Size,
                    ImportPrice = product.GetById(item.ProductID).ImportPrice,
                    Retail = product.GetById(item.ProductID).Retail,
                    Wholesale = product.GetById(item.ProductID).Wholesale,
                    Quantity = item.Quantity,
                    QuantityExactly = item.QuantityExactly
                };
                list.Add(wd);
            }
            return list;

        }

        private void formWarehouse_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = LoadWarehouse();
        }
    }
}