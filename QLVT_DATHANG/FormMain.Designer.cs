namespace QLVT_DATHANG
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tSLableMANV = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSLableTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSLableNhom = new System.Windows.Forms.ToolStripStatusLabel();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.componentNV3 = new QLVT_DATHANG.ComponentNV();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.componentVatTu1 = new QLVT_DATHANG.Component.ComponentVatTu();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.chiNhanhTableAdapter1 = new QLVT_DATHANG.QLVT_MASTERTableAdapters.ChiNhanhTableAdapter();
            this.phieuNhapTableAdapter1 = new QLVT_DATHANG.QLVT_MASTERTableAdapters.PhieuNhapTableAdapter();
            this.ctpxTableAdapter1 = new QLVT_DATHANG.QLVT_MASTERTableAdapters.CTPXTableAdapter();
            this.ctpnTableAdapter1 = new QLVT_DATHANG.QLVT_MASTERTableAdapters.CTPNTableAdapter();
            this.xtraUserControl11 = new QLVT_DATHANG.Component.XtraUserControl1();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            this.xtraTabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSLableMANV,
            this.tSLableTen,
            this.tSLableNhom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 554);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1046, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tSLableMANV
            // 
            this.tSLableMANV.ForeColor = System.Drawing.Color.Crimson;
            this.tSLableMANV.Margin = new System.Windows.Forms.Padding(0, 3, 15, 2);
            this.tSLableMANV.Name = "tSLableMANV";
            this.tSLableMANV.Size = new System.Drawing.Size(49, 17);
            this.tSLableMANV.Text = "Mã NV: ";
            // 
            // tSLableTen
            // 
            this.tSLableTen.ForeColor = System.Drawing.Color.Crimson;
            this.tSLableTen.Margin = new System.Windows.Forms.Padding(0, 3, 15, 2);
            this.tSLableTen.Name = "tSLableTen";
            this.tSLableTen.Size = new System.Drawing.Size(32, 17);
            this.tSLableTen.Text = "Tên: ";
            // 
            // tSLableNhom
            // 
            this.tSLableNhom.ForeColor = System.Drawing.Color.Crimson;
            this.tSLableNhom.Margin = new System.Windows.Forms.Padding(0, 3, 15, 2);
            this.tSLableNhom.Name = "tSLableNhom";
            this.tSLableNhom.Size = new System.Drawing.Size(47, 17);
            this.tSLableNhom.Text = "Nhóm: ";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.AppearancePage.Header.Font = new System.Drawing.Font("Tahoma", 12F);
            this.xtraTabControl1.AppearancePage.Header.Options.UseFont = true;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl1.Size = new System.Drawing.Size(1046, 554);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage4});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.componentNV3);
            this.xtraTabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1040, 520);
            this.xtraTabPage2.Text = "Nhân viên";
            // 
            // componentNV3
            // 
            this.componentNV3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.componentNV3.Location = new System.Drawing.Point(0, 0);
            this.componentNV3.Name = "componentNV3";
            this.componentNV3.Size = new System.Drawing.Size(1040, 520);
            this.componentNV3.TabIndex = 0;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.componentVatTu1);
            this.xtraTabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1040, 520);
            this.xtraTabPage3.Text = "Vật tư";
            this.xtraTabPage3.Paint += new System.Windows.Forms.PaintEventHandler(this.xtraTabPage3_Paint);
            // 
            // componentVatTu1
            // 
            this.componentVatTu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.componentVatTu1.Location = new System.Drawing.Point(0, 0);
            this.componentVatTu1.Name = "componentVatTu1";
            this.componentVatTu1.Size = new System.Drawing.Size(1040, 520);
            this.componentVatTu1.TabIndex = 0;
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.xtraUserControl11);
            this.xtraTabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(1040, 520);
            this.xtraTabPage4.Text = "DS Kho";
            this.xtraTabPage4.Paint += new System.Windows.Forms.PaintEventHandler(this.xtraTabPage4_Paint);
            // 
            // chiNhanhTableAdapter1
            // 
            this.chiNhanhTableAdapter1.ClearBeforeFill = true;
            // 
            // phieuNhapTableAdapter1
            // 
            this.phieuNhapTableAdapter1.ClearBeforeFill = true;
            // 
            // ctpxTableAdapter1
            // 
            this.ctpxTableAdapter1.ClearBeforeFill = true;
            // 
            // ctpnTableAdapter1
            // 
            this.ctpnTableAdapter1.ClearBeforeFill = true;
            // 
            // xtraUserControl11
            // 
            this.xtraUserControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraUserControl11.Location = new System.Drawing.Point(0, 0);
            this.xtraUserControl11.Name = "xtraUserControl11";
            this.xtraUserControl11.Size = new System.Drawing.Size(1040, 520);
            this.xtraUserControl11.TabIndex = 0;
            // 
            // FormMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 576);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tSLableMANV;
        private System.Windows.Forms.ToolStripStatusLabel tSLableTen;
        private System.Windows.Forms.ToolStripStatusLabel tSLableNhom;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private ComponentNV componentNV1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private QLVT_MASTERTableAdapters.ChiNhanhTableAdapter chiNhanhTableAdapter1;
        private ComponentNV componentNV2;
        private Component.ComponentVatTu componentVatTu1;
        private ComponentNV componentNV3;
        private QLVT_MASTERTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter1;
        private QLVT_MASTERTableAdapters.CTPXTableAdapter ctpxTableAdapter1;
        private QLVT_MASTERTableAdapters.CTPNTableAdapter ctpnTableAdapter1;
        private Component.XtraUserControl1 xtraUserControl11;
    }
}