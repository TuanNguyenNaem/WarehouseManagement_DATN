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

namespace WarehouseManagement
{
    public partial class formEnterWarehouseToday : DevExpress.XtraEditors.XtraForm
    {
        IService<EnterWarehouse> enterWarehouse = new EnterWarehouseService();
        public formEnterWarehouseToday()
        {
            InitializeComponent();
        }

        private void formEnterWarehouseToday_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = enterWarehouse.GetAll().Where(c => c.EnterDate == DateTime.Now.Date);
            
        }
    }
}