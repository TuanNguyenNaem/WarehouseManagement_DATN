using System;
using System.Data;
using System.Linq;
using DevExpress.XtraEditors;
using Service;
using Model;
using Helpers;
using Decentralization;
using System.Collections.Generic;

namespace WarehouseManagement
{
    public partial class formContractToday : DevExpress.XtraEditors.XtraForm
    {
        IService<Contract> contract = new ContractService();
        IService<EnterWarehouse> enterWarehouse = new EnterWarehouseService();
        IContractDetailService detail = new ContractDetailService();
        IService<Warehouse> warehouse = new WarehouseService();
        IAccountService account = new AccountService();
        IService<Employee> employee = new EmployeeService();
        IService<Supplier> supplier = new SupplierService();
        IService<Product> product = new ProductService();
        public formContractToday()
        {
            InitializeComponent();
        }

        private void LoadHoaDon()
        {
            gridControl1.DataSource = contract.GetAll().Where(c => c.DeliveryDate >= DateTime.Now && c.Status == "Đã ký");
        }
        private void formContractToday_Load(object sender, EventArgs e)
        {
            txtmahd.Enabled = false;
            LoadHoaDon();
            if (contract.GetAll().Where(c => c.DeliveryDate >= DateTime.Now && c.Status == "Đã ký").Count() == 0)
                XtraMessageBox.Show("Hôm nay không có hợp đồng nào có thể nhận!", "Thông báo");
        }
        private void LoadEmoAndSupplier(int idContract)
        {
            //lấy thông tin nhân viên từ hợp đồng.
            List<UserInfomation> user = new List<UserInfomation>();
            var employee = new UserInfomation()
            {
                EmployeeName = this.employee.GetById(contract.GetById(idContract).EmployeeID).EmployeeName,
                UserName = account.GetById(contract.GetById(idContract).EmployeeID).UserName,
                Role = account.GetById(contract.GetById(idContract).EmployeeID).Role
            };
            user.Add(employee);
            //Lấy dữ liệu nhà cung cấp từ hợp đồng
            List<Supplier> listSupplier = new List<Supplier>();
            var supplier = new Supplier()
            {
                SupplierName = this.supplier.GetById(contract.GetById(idContract).SupplierID).SupplierName,
                Address = this.supplier.GetById(contract.GetById(idContract).SupplierID).Address,
                PhoneNumber = this.supplier.GetById(contract.GetById(idContract).SupplierID).PhoneNumber
            };
            listSupplier.Add(supplier);

            //đổ dữ liệu cho grid
            gridControl2.DataSource = user;
            gridControl3.DataSource = listSupplier;
        }
        //Load danh sách các sản phẩm trong hợp đồng
        private List<ContractDeteilInformation> LoadListProduct(int idContract)
        {
            var temp = detail.GetByIdList(idContract);
            List<ContractDeteilInformation> product = new List<ContractDeteilInformation>();
            foreach(var item in temp)
            {
                var pro = new ContractDeteilInformation()
                {
                    ProductName = this.product.GetById(item.ProductID).ProductName,
                    Quantity = detail.GetByTwoId(item.ContractID, item.ProductID).Quantity,
                    Notes = detail.GetByTwoId(item.ContractID, item.ProductID).Notes
                    
                };
                product.Add(pro);
            }
            return product;
        }

        private void btnhanhang_Click(object sender, EventArgs e)
        {
            if (txtmahd.Text == "")
                XtraMessageBox.Show("Chưa chọn hợp đồng!", "Thông báo");
            else
            {
                try
                {
                    EnterWarehouse enterWarehouse = new EnterWarehouse()
                    {
                        EnterWarehouseID = int.Parse(txtmahd.Text),
                        EnterDate = DateTime.Now.Date,
                        EmployeeID = Session.EmployeeID,
                        Status = "Đã nhập",
                        Notes = ""
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
                    XtraMessageBox.Show("Thêm mới phiếu nhận hàng thành công!, Đã cập nhật kho hàng!", "Thông báo");
                    txtmahd.Text = "";
                    LoadHoaDon();
                }
                catch
            {
                XtraMessageBox.Show("Please try again!", "Thông báo");
            }
        }
    }

    private void gridControl1_Click(object sender, EventArgs e)
    {
            if (contract.GetAll().Where(c => c.DeliveryDate >= DateTime.Now && c.Status == "Đã ký").Count() > 0)
                txtmahd.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();
            LoadEmoAndSupplier(int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString()));
            gridControl4.DataSource = LoadListProduct(int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString()));
             
    }
}
}