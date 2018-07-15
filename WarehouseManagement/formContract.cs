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
using Helpers;
using Decentralization;
using Model;
using Service;

namespace WarehouseManagement
{
    public partial class formContract : DevExpress.XtraEditors.XtraForm
    {
        IService<Contract> contract = new ContractService();
        IService<Employee> emp = new EmployeeService();
        IService<Supplier> sup = new SupplierService();
        IAccountService account = new AccountService();
        IContractDetailService cd = new ContractDetailService();
        IService<Product> pro = new ProductService();
        private bool insert = true;
        private int id = 0;
        private string status;
        public formContract()
        {
            InitializeComponent();
        }
        private void LoadCombobox()
        {
            foreach(var item in sup.GetAll())
            {
                cbncc.Properties.Items.Add(item.SupplierID);
            }
            
        }
        public void KhoaDieuKhien()
        {
            cbmanv.Enabled = false;
            cbmancc.Enabled = false;
            datecreate.Enabled = false;
            txtghichu.Enabled = false;
            gridControl3.Enabled = true;
            datengaygiao.Enabled = false;

            btthem.Enabled = true;
            btsua.Enabled = true;
            btxoa.Enabled = true;
            btluu.Enabled = false;
        }
        public void MoDieuKhien()
        {
            cbmanv.Enabled = false;
            cbmancc.Enabled = true;
            datecreate.Enabled = false;
            txtghichu.Enabled = true;
            datengaygiao.Enabled = true;
            gridControl3.Enabled = false;

            btthem.Enabled = false;
            btsua.Enabled = false;
            btxoa.Enabled = false;
            btluu.Enabled = true;
        }
        private void Reset()
        {
            cbmanv.Text  = "";
            cbncc.Text = "";
            datecreate.Text = "";
            txtghichu.Text = "";
            datengaygiao.Text = "";
            id = 0;
        }
        private void LoadContract()
        {
            gridControl3.DataSource = contract.GetAll().Where(c=>c.EmployeeID == Session.EmployeeID);
        }

        private void formContract_Load(object sender, EventArgs e)
        {
            
            LoadCombobox();
            KhoaDieuKhien();
            LoadContract();
        }

        private void gridControl3_Click(object sender, EventArgs e)
        {
            try
            {
                id = int.Parse(gridView3.GetRowCellValue(gridView3.FocusedRowHandle, gridView3.Columns[0]).ToString());
                cbmanv.Text = gridView3.GetRowCellValue(gridView3.FocusedRowHandle, gridView3.Columns[1]).ToString();
                cbncc.Text = gridView3.GetRowCellValue(gridView3.FocusedRowHandle, gridView3.Columns[2]).ToString();
                datecreate.Text = gridView3.GetRowCellValue(gridView3.FocusedRowHandle, gridView3.Columns[3]).ToString();
                datengaygiao.Text = gridView3.GetRowCellValue(gridView3.FocusedRowHandle, gridView3.Columns[4]).ToString();
                status = gridView3.GetRowCellValue(gridView3.FocusedRowHandle, gridView3.Columns[5]).ToString();
                txtghichu.Text = gridView3.GetRowCellValue(gridView3.FocusedRowHandle, gridView3.Columns[6]).ToString();
                int idEmp = int.Parse(gridView3.GetRowCellValue(gridView3.FocusedRowHandle, gridView3.Columns[1]).ToString());
                int idSup = int.Parse(gridView3.GetRowCellValue(gridView3.FocusedRowHandle, gridView3.Columns[2]).ToString());
                List<Supplier> su = new List<Supplier>();
                List<ContractDeteilInformation> detail = new List<ContractDeteilInformation>();
                var chitiet = cd.GetByIdList(id);
                foreach (var item in chitiet)
                {
                    var proInfomation = new ContractDeteilInformation()
                    {
                        ProductName = pro.GetById(item.ProductID).ProductName,
                        Quantity = item.Quantity,
                        Notes = item.Notes
                    };
                    detail.Add(proInfomation);
                }
                var temp = new UserInfomation()
                {
                    EmployeeName = emp.GetById(idEmp).EmployeeName,
                    UserName = account.GetById(idEmp).UserName,
                    Role = account.GetById(idEmp).Role
                    
                };
                var ac = new List<UserInfomation>();
                ac.Add(temp);
                gridControl1.DataSource = ac;
                gridControl2.DataSource = su;
                gridControl4.DataSource = detail;
            }
            catch
            {
                XtraMessageBox.Show("Please try again!", "Thông báo");
            }
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            datecreate.Text = DateTime.Now.Date.ToString();
            cbmanv.Text = Session.EmployeeID.ToString();
            txtghichu.Text = "";
            insert = true;
            MoDieuKhien();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (id == 0)
                XtraMessageBox.Show("Chưa chọn trường cần sửa!", "Thông báo");
            else
            {
                insert = false;
                MoDieuKhien();
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (id == 0)
                XtraMessageBox.Show("Chưa chọn trường cần xóa!", "Thông báo");
            else
            {
                if (XtraMessageBox.Show("Bạn có muốn xóa?", "thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var list = cd.GetByIdList(id);
                    foreach(var item in list)
                    {
                        cd.DeleteByTwoId(id, item.ProductID);
                    }
                    contract.Delete(id);
                    XtraMessageBox.Show("Xóa thành công!", "Thông báo");
                    Reset();
                    gridControl3.DataSource = contract.GetAll().Where(c => c.EmployeeID == Session.EmployeeID);
                    KhoaDieuKhien();
                }
            }
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (insert == false)
            {
                try
                {
                    if (id == 0)
                        XtraMessageBox.Show("Chưa chọn trường cần sửa!", "Thông báo");
                    else
                    {
                        if (status == "Hoàn thành")
                            XtraMessageBox.Show("Hóa đơn đã hoàn thành, không thể sửa!", "Thông báo");
                        else
                        if(DateTime.Parse(datengaygiao.Text)< DateTime.Parse(datecreate.Text) || DateTime.Parse(datengaygiao.Text) < DateTime.Now.Date)
                            XtraMessageBox.Show("Ngày giao không hợp lệ!", "Thông báo");
                        else
                        {
                            datecreate.Enabled = false;
                            Contract con = new Contract()
                            {
                                ContractID = id,
                                EmployeeID = int.Parse(cbmanv.Text),
                                SupplierID = int.Parse(cbncc.Text),
                                CreateDate = DateTime.Parse(datecreate.Text),
                                DeliveryDate = DateTime.Parse(datengaygiao.Text),
                                Status = status,
                                Notes = txtghichu.Text,
                            };
                            contract.Update(con);
                            XtraMessageBox.Show("Sửa thành công!", "Thông báo");
                            Reset();
                            gridControl3.DataSource = contract.GetAll().Where(c=>c.EmployeeID == Session.EmployeeID);
                        }
                        KhoaDieuKhien();
                    }
                }
                catch
                {
                    XtraMessageBox.Show("Please try again!", "Thông báo");
                }
            }
            else
            {
                try
                {

                    if (DateTime.Parse(datengaygiao.Text) < DateTime.Parse(datecreate.Text) || DateTime.Parse(datengaygiao.Text) < DateTime.Now.Date)
                        XtraMessageBox.Show("Ngày giao không hợp lệ!", "Thông báo");
                    else
                    {
                        Contract con = new Contract()
                        {
                            EmployeeID = Session.EmployeeID,
                            SupplierID = int.Parse(cbncc.Text),
                            CreateDate = DateTime.Now,
                            DeliveryDate = DateTime.Parse(datengaygiao.Text),
                            Status = "Đã ký",
                            Notes = txtghichu.Text,
                        };
                        formAddContractDetail form = new formAddContractDetail(con);
                        form.ShowDialog();
                        Reset();
                        gridControl3.DataSource = contract.GetAll().Where(c => c.EmployeeID == Session.EmployeeID);
                        KhoaDieuKhien();
                    }
                }
                catch
                {
                    XtraMessageBox.Show("Please try again!", "Thông báo");
                }
            }
        }

        private void btchitiet_Click(object sender, EventArgs e)
        {
            //hiện form chi tiet
        }
    }
}