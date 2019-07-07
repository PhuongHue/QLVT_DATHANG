using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLVT_DATHANG.Component
{
    public partial class ComponentVatTu : DevExpress.XtraEditors.XtraUserControl
    {
        public ComponentVatTu()
        {
            InitializeComponent();
            this.vattuTableAdapter.Fill(qLVT_CN.Vattu);
        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vattuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVT_CN);

        }
    }
}
