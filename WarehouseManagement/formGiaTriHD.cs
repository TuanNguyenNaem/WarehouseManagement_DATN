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
using Helpers;
using Decentralization;

namespace WarehouseManagement
{
    public partial class formGiaTriHD : DevExpress.XtraEditors.XtraForm
    {
        IService<Contract> contract = new ContractService();
        IService<Product> product = new ProductService();
        IContractDetailService detail = new ContractDetailService();
        public formGiaTriHD()
        {
            InitializeComponent();
        }
        private TongTienHD TinhTienHD(int idHoaDon)
        {
            var listDetail = detail.GetByIdList(idHoaDon);
            decimal sum = 0;
            foreach(var item in listDetail)
            {
                var product = new Product()
                {
                    ImportPrice = this.product.GetById(item.ProductID).ImportPrice
                };
                sum += (product.ImportPrice * item.Quantity);
            }
            var temp = new TongTienHD()
            {
                ContractID = idHoaDon,
                Moneys = sum
            };
            return temp;
        }
        private void formGiaTriHD_Load(object sender, EventArgs e)
        {
            XtraMessageBox.Show(TinhTienHD(30).ContractID + " : " + TinhTienHD(30).Moneys);
        }
    }
}