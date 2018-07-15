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
    public partial class formAddContractDetail : DevExpress.XtraEditors.XtraForm
    {
        IService<Contract> contract = new ContractService();
        IService<Product> pro = new ProductService();
        IContractDetailService contractDetail = new ContractDetailService();
        Contract con = new Contract();
        List<ContractDetail> list = new List<ContractDetail>();
        private bool done = false;
        public formAddContractDetail(Contract con)
        {
            this.con = con;
            InitializeComponent();
        }
        private void LoadCombobox()
        {
            foreach (var item in pro.GetAll().Where(c => c.SupplierID == con.SupplierID))
            {
                cbmasp.Properties.Items.Add(item.ProductID);
            }

        }
        private void Khoa()
        {
            txtmanv.Text = con.EmployeeID.ToString();
            txtmancc.Text = con.SupplierID.ToString();
            txtngaylap.Text = con.CreateDate.ToString();
            txthangiao.Text = con.DeliveryDate.ToString();
            txtmanv.Enabled = false;
            txtmancc.Enabled = false;
            txtngaylap.Enabled = false;
            txttensp.Enabled = false;
            txthangiao.Enabled = false;
        }
        private void Reset()
        {
            cbmasp.Text = "1";
            cbsoluong.ResetText();
            txtghichu.Text = "";
        }
        private void formAddContractDetail_Load(object sender, EventArgs e)
        {
            Khoa();
            LoadCombobox();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            if (cbmasp.Text == "" || cbsoluong.Value == 0)
                XtraMessageBox.Show("Chưa nhập đủ thông tin!", "Thông báo");
            else
            {
                ContractDetail contractDetail = new ContractDetail()
                {
                    ContractID = contract.GetAll().Count == 0 ? 1 : (contract.GetAll()[contract.GetAll().Count - 1].ContractID) + 1,
                    ProductID = int.Parse(cbmasp.Text),
                    Quantity = int.Parse(cbsoluong.Value.ToString()),
                    Notes = txtghichu.Text
                };

                if (contractDetail.Notes == "")
                    contractDetail.Notes = "Đã kiểm tra";
                var x = list.Count;
                if (list.Count != 0)
                {
                    foreach (var item in list)
                    {
                        if (item.ProductID == contractDetail.ProductID)
                        {
                            contractDetail.Quantity = item.Quantity + contractDetail.Quantity;
                            list.Remove(item);
                            list.Add(contractDetail);
                            x++;
                            break;
                        }
                    }
                    if (x == list.Count)
                        list.Add(contractDetail);
                }
                else
                {
                    list.Add(contractDetail);
                }
                gridControl1.DataSource = null;
                gridControl1.DataSource = list;
            }
        }

        private void bttaohd_Click(object sender, EventArgs e)
        {
            try
            {
                if (list == null)
                    XtraMessageBox.Show("Chưa thêm sản phẩm, không thể tạo hợp đồng!", "Thông báo");
                else
                {
                    contract.Add(con);
                    foreach (var item in list)
                    {
                        item.ContractID = contract.GetAll()[contract.GetAll().Count - 1].ContractID;
                    }
                    foreach (var item in list)
                    {
                        contractDetail.Add(item);
                    }
                    XtraMessageBox.Show("Tạo hợp đồng thành công!", "Thông báo");
                    done = true;
                    this.Close();
                }
            }
            catch
            {
                contract.Delete(con.ContractID);
                XtraMessageBox.Show("Please try again!", "Thông báo");
            }
        }

        private void formAddContractDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (done == false && XtraMessageBox.Show("Bạn có muốn hủy tạo hợp đồng?", "thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void cbmasp_SelectedIndexChanged(object sender, EventArgs e)
        {
            txttensp.Text = pro.GetById(int.Parse(cbmasp.Text)).ProductName;
        }
    }
}