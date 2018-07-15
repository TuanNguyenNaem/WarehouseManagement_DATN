using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Helpers;
using Decentralization;
using DevExpress.XtraEditors;

namespace WarehouseManagement
{
    public partial class formMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public formMain()
        {
            Session.EmployeeID = 0;
            Session.Username = string.Empty;
            Session.Role = string.Empty;
            Session.EmployeeName = string.Empty;
            InitializeComponent();
        }

        public formMain(string role)
        {
            InitializeComponent();
        }
        private Form CheckForm(Type t)
        {
            foreach (var f in this.MdiChildren)
            {
                if (f.GetType() == t)
                {
                    return f;
                }
            }
            return null;
        }

        private void btLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            formLogin form = new formLogin();
            this.Hide();
            form.Show();
        }
        private void LoadQuyen()
        {
            btLogin.Enabled = Role.login;
            btLogout.Enabled = Role.logout;
            btDoimk.Enabled = Role.doimk;
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            if(Session.Username != "")
                padhello.Text = "Xin chào: " + Session.EmployeeName + " (" + Session.Role + ")";
            Role.MacDinh();
            LoadQuyen();
        }

        private void btLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn đăng xuất?", "thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                formMain form = new formMain();
                this.Hide();
                form.Show();
            }
        }

        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn thoát?", "thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btDoimk_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = CheckForm(typeof(formResetPassword));
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                formResetPassword formrsp = new formResetPassword();
                formrsp.MdiParent = this;
                formrsp.Show();
            }
        }

        private void btlistKH_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = CheckForm(typeof(formListSupplier));
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                formListSupplier formrsp = new formListSupplier();
                formrsp.MdiParent = this;
                formrsp.Show();
            }
        }

        private void btcontract_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = CheckForm(typeof(formContract));
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                formContract formrsp = new formContract();
                formrsp.MdiParent = this;
                formrsp.Show();
            }
        }

        private void btphieunhaphang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = CheckForm(typeof(formEnterWarehouse));
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                formEnterWarehouse formrsp = new formEnterWarehouse();
                formrsp.MdiParent = this;
                formrsp.Show();
            }
        }

        private void bthdhomnay_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = CheckForm(typeof(formContractToday));
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                formContractToday formrsp = new formContractToday();
                formrsp.MdiParent = this;
                formrsp.Show();
            }
        }

        private void btnhaphomnay_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = CheckForm(typeof(formEnterWarehouseToday));
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                formEnterWarehouseToday formrsp = new formEnterWarehouseToday();
                formrsp.MdiParent = this;
                formrsp.Show();
            }
        }

        private void btkhohang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = CheckForm(typeof(formWarehouse));
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                formWarehouse formrsp = new formWarehouse();
                formrsp.MdiParent = this;
                formrsp.Show();
            }
        }

        private void btgiatriHD_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void bttknhapkho_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = CheckForm(typeof(formThongKeNhapKho));
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                formThongKeNhapKho formrsp = new formThongKeNhapKho();
                formrsp.MdiParent = this;
                formrsp.Show();
            }
        }
    }
}