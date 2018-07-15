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
using Service;
using Model;
using Helpers;

namespace WarehouseManagement
{
    public partial class formLogin : DevExpress.XtraEditors.XtraForm
    {

        IAccountService account = new AccountService();
        IService<Employee> emp = new EmployeeService();
        public formLogin()
        {
            InitializeComponent();
        }

        private void btback_Click(object sender, EventArgs e)
        {
            formMain form = new formMain();
            this.Hide();
            form.Show();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            txtpass.UseSystemPasswordChar = true;
        }

        private void checkShowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowpass.Checked)
                txtpass.UseSystemPasswordChar = false;
            else
                txtpass.UseSystemPasswordChar = true;
        }

        private void btlogin_Click_1(object sender, EventArgs e)
        {
            if (txtusername.Text == "" || txtpass.Text == "")
                XtraMessageBox.Show("Nhập thiếu dữ liệu!", "Thông báo");
            else
            {
                try
                {
                    var result = account.CheckLogin(txtusername.Text, txtpass.Text);
                    if (result == null)
                        XtraMessageBox.Show("Sai thông tin", "Thông báo");
                    else
                    {
                        var temp = emp.GetById(result.AccountID);
                        if (temp == null)
                            XtraMessageBox.Show("Chưa đăng ký người dùng cho tài khoản này!", "Thông báo");
                        else
                        {
                            Session.EmployeeID = result.AccountID;
                            Session.Username = result.UserName;
                            Session.Role = result.Role;
                            Session.EmployeeName = temp.EmployeeName;
                            formMain form = new formMain(Session.Role);
                            this.Hide();
                            form.Show();
                        }
                    }
                }
                catch
                {
                    XtraMessageBox.Show("Please try again!", "Thông báo");
                }
            }
        }

        private void formLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            formMain form = new formMain();
            form.Show();
        }
    }
}