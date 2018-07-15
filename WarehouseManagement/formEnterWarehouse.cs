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
    public partial class formEnterWarehouse : DevExpress.XtraEditors.XtraForm
    {
        IService<EnterWarehouse> enterWarehouse = new EnterWarehouseService();
        IService<Employee> employee = new EmployeeService();
        IAccountService account = new AccountService();
        IService<Supplier> supplier = new SupplierService();
        IService<Contract> contract = new ContractService();
        IContractDetailService detail = new ContractDetailService();
        IService<Product> product = new ProductService();
        IService<Warehouse> warehouse = new WarehouseService();
        private bool insert;
        public formEnterWarehouse()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            gridControl1.DataSource = enterWarehouse.GetAll().Where(c => c.EmployeeID == Session.EmployeeID);
        }
        private void KhoaDieuKhien()
        {
            cbmahd.Enabled = false;
            datenhapkho.Enabled = false;
            txtghichu.Enabled = false;

            btthem.Enabled = true;
            btsua.Enabled = true;
            btxoa.Enabled = true;
            btluu.Enabled = false;

            gridControl1.Enabled = true;
        }
        private void MoDieuKhien()
        {
            cbmahd.Enabled = true;
            datenhapkho.Enabled = false;
            txtghichu.Enabled = true;

            btthem.Enabled = false;
            btsua.Enabled = false;
            btxoa.Enabled = false;
            btluu.Enabled = true;

            gridControl1.Enabled = false;
        }
        private void Reset()
        {
            cbmahd.Text = "";
            datenhapkho.Text = "";
            txtghichu.Text = "";
        }
        private void LoadMaHD()
        {
            var list = contract.GetAll().Where(c => c.DeliveryDate >= DateTime.Now.Date && c.Status == "Đã ký");
            if (list.Count() != 0)
            {
                foreach (var item in list)
                {
                    cbmahd.Properties.Items.Add(item.ContractID);
                }
            }
        }
        private void LoadInfoEmpAndSup(int mahd, int manv)
        {
            var employeeInfomation = new List<UserInfomation>();
            var supplierInfomation = new List<Supplier>();
            UserInfomation user = new UserInfomation()
            {
                EmployeeName = employee.GetById(manv).EmployeeName,
                UserName = account.GetById(manv).UserName,
                Role = account.GetById(manv).Role
            };
            var supplier = this.supplier.GetById(contract.GetById(mahd).SupplierID);
            employeeInfomation.Add(user);
            supplierInfomation.Add(supplier);
            gridControl2.DataSource = employeeInfomation;
            gridControl3.DataSource = supplierInfomation;
        }
        private List<ContractDeteilInformation> LoadListProduct(int mahd)
        {
            var list = new List<ContractDeteilInformation>();
            var listDetail = detail.GetByIdList(mahd);
            foreach (var item in listDetail)
            {
                var dt = new ContractDeteilInformation()
                {
                    ProductName = product.GetById(item.ProductID).ProductName,
                    Quantity = item.Quantity,
                    Notes = item.Notes
                };
                list.Add(dt);
            }
            return list;
        }

        private void formEnterWarehouse_Load(object sender, EventArgs e)
        {
            LoadData();
            KhoaDieuKhien();
            LoadMaHD();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            int idhd = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString());
            int idnv = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2]).ToString());
            LoadInfoEmpAndSup(idhd, idnv);
            gridControl4.DataSource = LoadListProduct(idhd);
            cbmahd.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();
            datenhapkho.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1]).ToString();
            txtghichu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[4]).ToString();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            var list = contract.GetAll().Where(c => c.DeliveryDate >= DateTime.Now.Date && c.Status == "Đã ký");
            if (list.Count() == 0)
                XtraMessageBox.Show("Hôm nay không còn đơn hàng nào!", "Thông báo");
            else
            {
                insert = true;
                datenhapkho.Text = DateTime.Now.Date.ToString();
                MoDieuKhien();
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (cbmahd.Text == "")
                XtraMessageBox.Show("Chưa chọn bản ghi!", "Thông báo");
            else
            {
                insert = true;
                MoDieuKhien();
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (cbmahd.Text == "")
                XtraMessageBox.Show("Chưa chọn bản ghi!", "Thông báo");
            else
            {
                if (XtraMessageBox.Show("Bạn có muốn xóa?", "thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        enterWarehouse.Delete(int.Parse(cbmahd.Text));
                        XtraMessageBox.Show("Xóa thành công!", "thông báo");
                        LoadData();
                        Reset();
                    }
                    catch
                    {
                        XtraMessageBox.Show("Please try again!", "thông báo");
                    }

                }
            }
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (insert)//thêm mới
            {
                if (cbmahd.Text == "")
                    XtraMessageBox.Show("Chưa nhập đủ thông tin!", "Thông báo");
                else
                {
                    try
                    {
                        EnterWarehouse enterWarehouse = new EnterWarehouse()
                        {
                            EnterWarehouseID = int.Parse(cbmahd.Text),
                            EnterDate = DateTime.Now.Date,
                            EmployeeID = Session.EmployeeID,
                            Status = "Đã nhập",
                            Notes = txtghichu.Text
                        };
                        var temp = contract.GetById(enterWarehouse.EnterWarehouseID);
                        temp.Status = "Hoàn thành";
                        this.enterWarehouse.Add(enterWarehouse);//thêm phiếu nhận hàng
                        contract.Update(temp);//Sửa trạng thái hợp đồng sau khi nhận hàng.
                        var list = detail.GetByIdList(enterWarehouse.EnterWarehouseID);
                        var warehouse = this.warehouse.GetAll();
                        var update = false;
                        foreach (var itemlist in list)
                        {
                            update = false;
                            foreach (var item in warehouse)
                            {
                                if (itemlist.ProductID == item.ProductID)
                                {
                                    Warehouse w = new Warehouse()
                                    {
                                        ProductID = item.ProductID,
                                        Quantity = item.Quantity + itemlist.Quantity,
                                        QuantityExactly = item.QuantityExactly + itemlist.Quantity
                                    };
                                    this.warehouse.Delete(item.ProductID);
                                    this.warehouse.Add(w);//nếu laoji sản phẩm này còn trong kho thì update lại số lượng
                                    update = true;
                                    break;
                                }
                            }
                            if (update == false)
                            {
                                Warehouse w = new Warehouse()
                                {
                                    ProductID = itemlist.ProductID,
                                    Quantity = itemlist.Quantity,
                                    QuantityExactly = itemlist.Quantity
                                };
                                this.warehouse.Add(w); //trong kho chưa có thì thêm mới
                            }
                        }
                        XtraMessageBox.Show("Thêm mới thành công!, Đã cập nhật kho hàng!", "Thông báo");
                        Reset();
                        LoadData();
                        cbmahd.Properties.Items.Remove(enterWarehouse.EnterWarehouseID);
                        KhoaDieuKhien();
                    }
                    catch
                    {
                        XtraMessageBox.Show("Please try again!", "Thông báo");
                    }
                }
            }
            else //sửa
            {
                if (cbmahd.Text == "")
                    XtraMessageBox.Show("Chưa nhập đủ thông tin!", "Thông báo");
                else
                {
                    cbmahd.Enabled = false;
                    try

                    {
                        var temp = enterWarehouse.GetById(int.Parse(cbmahd.Text));
                        EnterWarehouse enter = new EnterWarehouse()
                        {
                            EnterWarehouseID = int.Parse(cbmahd.Text),
                            EnterDate = DateTime.Now.Date,
                            EmployeeID = Session.EmployeeID,
                            Status = temp.Status,
                            Notes = txtghichu.Text,
                        };
                        enterWarehouse.Update(enter);
                        XtraMessageBox.Show("Sửa thành công!", "Thông báo");
                    }
                    catch
                    {
                        XtraMessageBox.Show("Please try again!", "Thông báo");
                    }

                }

            }
        }
    }
}