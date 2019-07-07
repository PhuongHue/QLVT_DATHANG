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

namespace QLVT_DATHANG
{
    public partial class FormDangNhap : DevExpress.XtraEditors.XtraForm
    {
        KetNoi.KetNoiDB _dataRepository = Program._ketNoiDB;
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_MASTER.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.qLVT_MASTER.V_DSPM);

        }

        private void v_DSPMComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            _dataRepository.Server = v_DSPMComboBox.SelectedValue.ToString();
            _dataRepository.DataBase = "QLVT_DATHANG";
            _dataRepository.UserId = LoginUserTextBox.Text;
            _dataRepository.Password = LoginPasswordTextBox.Text;
            _dataRepository.NewSqlConnection();
            MessageBox.Show(_dataRepository.ConnectServer());
            if (_dataRepository.Ready) this.Close();
        }
    }
}