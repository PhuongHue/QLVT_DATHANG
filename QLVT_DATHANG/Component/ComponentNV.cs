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

namespace QLVT_DATHANG
{
    public partial class ComponentNV : DevExpress.XtraEditors.XtraUserControl
    {
        public void setupByRole()
        {
            if (Program._ketNoiDB.GroupId != null)
                switch (Program._ketNoiDB.GroupId)
                {
                    case "CONGTY":
                        bindingNavigatorDeleteItem.Enabled = false;
                        bindingNavigatorAddNewItem.Enabled = false;
                        nhanVienBindingNavigatorSaveItem.Enabled = false;
                        bindingNavigatorDeleteItem.BackColor = Color.LightGray;
                        bindingNavigatorAddNewItem.BackColor = Color.LightGray;
                        nhanVienBindingNavigatorSaveItem.BackColor = Color.LightGray;

                        break;
                    default:

                        break;
                }
        }

        public void changeConnecttion()
        {
            if (Program._ketNoiDB.sqlConnection != null)
            {
                this.chiNhanhTableAdapter.Connection = Program._ketNoiDB.sqlConnection;
                this.nhanVienTableAdapter.Connection = Program._ketNoiDB.sqlConnection;
            }
        }

        public ComponentNV()
        {
            InitializeComponent();
            changeConnecttion();
            setupByRole();
            queryDataSet();
        }

        private void queryDataSet()
        {
            this.chiNhanhTableAdapter.Fill(qLVT_CN.ChiNhanh);
            this.nhanVienTableAdapter.Fill(qLVT_CN.NhanVien);
        }

        private void saveData()
        {
            try
            {
                this.Validate();
                this.nhanVienBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.qLVT_CN);
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra!!");
            }
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            saveData();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            queryDataSet();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            saveData();
        }
    }
}
