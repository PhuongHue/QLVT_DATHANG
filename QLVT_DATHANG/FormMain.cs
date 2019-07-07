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
    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        void Init()
        {
            tSLableMANV.Text += Program._ketNoiDB.UserName;
            tSLableTen.Text += Program._ketNoiDB.FullName;
            tSLableNhom.Text += Program._ketNoiDB.GroupId;
        }

        public FormMain()
        {
            InitializeComponent();

            Init();
        }
    }
}