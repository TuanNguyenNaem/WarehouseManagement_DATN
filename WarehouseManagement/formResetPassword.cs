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

namespace WarehouseManagement
{
    public partial class formResetPassword : DevExpress.XtraEditors.XtraForm
    {
        IService<Account> account = new AccountService();
        public formResetPassword()
        {
            InitializeComponent();
        }

        private void checkpasscu_CheckedChanged(object sender, EventArgs e)
        {
            if (checkpasscu.Checked)
                txtpasscu.UseSystemPasswordChar = false;
            else
                txtpasscu.UseSystemPasswordChar = true;
        }

        private void checkpassmoi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkpassmoi.Checked)
                txtpassmoi.UseSystemPasswordChar = false;
            else
                txtpassmoi.UseSystemPasswordChar = true;
        }

        private void checknhaplai_CheckedChanged(object sender, EventArgs e)
        {
            if (checknhaplai.Checked)
                txtnhaplai.UseSystemPasswordChar = false;
            else
                txtnhaplai.UseSystemPasswordChar = true;
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            if (txtpasscu.Text == "" || txtpassmoi.Text == "" || txtnhaplai.Text == "")
                XtraMessageBox.Show("Nhập thiếu thông tin!", "Thông báo");
            else
            {
                try
                {
                    var temp = account.GetById(Session.EmployeeID);
                    if (txtpasscu.Text != temp.Password)
                        XtraMessageBox.Show("Mật khẩu cũ không đúng", "Thông báo");
                    else if (txtpassmoi.Text != txtnhaplai.Text)
                        XtraMessageBox.Show("Nhập lại mật khẩu mới không đúng!", "Thông báo");
                    else if (txtpassmoi.Text == txtpasscu.Text)
                        XtraMessageBox.Show("Không thể dùng mật khẩu mới này!", "Thông báo");
                    else
                    {
                        var acc = new Account()
                        {
                            AccountID = Session.EmployeeID,
                            UserName = Session.Username,
                            Password = txtpassmoi.Text,
                            Role = Session.Role
                        };
                        account.Update(acc);
                        XtraMessageBox.Show("Thành công!", "thông báo");
                        this.Hide();
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