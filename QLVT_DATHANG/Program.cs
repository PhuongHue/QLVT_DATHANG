using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using QLVT_DATHANG.KetNoi;

namespace QLVT_DATHANG
{
    static class Program
    {
        public static KetNoiDB _ketNoiDB;
        public static FormDangNhap _formDangNhap;

        static void initService()
        {
            _ketNoiDB = new KetNoiDB();
            _formDangNhap = new FormDangNhap();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();

            initService();

            Application.Run( _formDangNhap);
            if(_ketNoiDB.Ready == true)
            {
                Application.Run(new FormMain());
            }
        }
    }
}
