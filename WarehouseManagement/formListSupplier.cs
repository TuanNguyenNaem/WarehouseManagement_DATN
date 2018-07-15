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
using DevExpress.XtraGrid.Views.Base;
using Service;
using Model;
using Helpers;
using Decentralization;

namespace WarehouseManagement
{
    public partial class formListSupplier : DevExpress.XtraEditors.XtraForm
    {
        IService<Supplier> sup = new SupplierService();
        ProductService pro = new ProductService();
        private int id;
        private bool insert = true;
        public formListSupplier()
        {
            InitializeComponent();
        }
        private void LoadListSuplier()
        {
            gridncc.DataSource = sup.GetAll();
        }
        private void KhoaDieuKhien()
        {
            txttenncc.Enabled = false;
            txtdiachi.Enabled = false;
            txtsdt.Enabled = false;
            txtstaikhoan.Enabled = false;
            txtmathue.Enabled = false;
            cbkhuvuc.Enabled = false;
            txtemail.Enabled = false;
            txtghichu.Enabled = false;

            btthem.Enabled = true;
            btsua.Enabled = true;
            btxoa.Enabled = true;
            btluu.Enabled = false;
        }
        private void MoDieuKhien()
        {
            txttenncc.Enabled = true;
            txtdiachi.Enabled = true;
            txtsdt.Enabled = true;
            txtstaikhoan.Enabled = true;
            txtmathue.Enabled = true;
            cbkhuvuc.Enabled = true;
            txtemail.Enabled = true;
            txtghichu.Enabled = true;

            btthem.Enabled = false;
            btsua.Enabled = false;
            btxoa.Enabled = false;
            btluu.Enabled = true;
        }

        private void formListSupplier_Load(object sender, EventArgs e)
        {
            LoadListSuplier();
            KhoaDieuKhien();
        }

        private void gridncc_Click(object sender, EventArgs e)
        {
            id = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString());
            txttenncc.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1]).ToString();
            txtdiachi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2]).ToString();
            txtsdt.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[3]).ToString();
            txtstaikhoan.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[4]).ToString();
            txtmathue.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[5]).ToString();
            cbkhuvuc.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[6]).ToString();
            txtemail.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[7]).ToString();
            txtghichu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[8]).ToString();
            gridsp.DataSource = pro.GetBySupId(int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString()));
        }

        private void btthem_Click(object sender, EventArgs e)
        {

            insert = true;
            MoDieuKhien();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            insert = false;
            MoDieuKhien();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (txttenncc.Text == "")
                XtraMessageBox.Show("Chưa chọn trường cần xóa!", "Thông báo");
            else
            {
                if (XtraMessageBox.Show("Bạn có muốn xóa?", "thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    sup.Delete(id);
                    XtraMessageBox.Show("Xóa thành công!", "Thông báo");
                    gridncc.DataSource = this.sup.GetAll();
                    KhoaDieuKhien();
                }
            }
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if(insert)
            {
                try
                {
                    MoDieuKhien();
                    Supplier sup = new Supplier()
                    {
                        SupplierID = id,
                        SupplierName = txttenncc.Text,
                        Address = txtdiachi.Text,
                        PhoneNumber = txtsdt.Text,
                        AccountNumber = txtstaikhoan.Text,
                        TaxCode = txtmathue.Text,
                        Area = cbkhuvuc.Text,
                        Email = txtemail.Text,
                        Notes = txtghichu.Text
                    };
                    this.sup.Add(sup);
                    XtraMessageBox.Show("Thêm thành công!", "Thông báo");
                    gridncc.DataSource = this.sup.GetAll();
                    KhoaDieuKhien();
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
                    if (txttenncc.Text == "")
                        XtraMessageBox.Show("Chưa chọn trường cần xóa!", "Thông báo");
                    else
                    {
                        MoDieuKhien();
                        Supplier sup = new Supplier()
                        {
                            SupplierID = id,
                            SupplierName = txttenncc.Text,
                            Address = txtdiachi.Text,
                            PhoneNumber = txtsdt.Text,
                            AccountNumber = txtstaikhoan.Text,
                            TaxCode = txtmathue.Text,
                            Area = cbkhuvuc.Text,
                            Email = txtemail.Text,
                            Notes = txtghichu.Text
                        };
                        this.sup.Update(sup);
                        XtraMessageBox.Show("Sửa thành công!", "Thông báo");
                        gridncc.DataSource = this.sup.GetAll();
                        KhoaDieuKhien();
                    }
                }
                catch
                {
                    XtraMessageBox.Show("Please try again!", "Thông báo");
                }
            }
        }
    }
}