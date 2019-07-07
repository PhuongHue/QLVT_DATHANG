namespace QLVT_DATHANG
{
    partial class FormDangNhap
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
            this.components = new System.ComponentModel.Container();
            this.qLVT_MASTER = new QLVT_DATHANG.QLVT_MASTER();
            this.v_DSPMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DSPMTableAdapter = new QLVT_DATHANG.QLVT_MASTERTableAdapters.V_DSPMTableAdapter();
            this.v_DSPMComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginUserTextBox = new System.Windows.Forms.TextBox();
            this.LoginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_MASTER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // qLVT_MASTER
            // 
            this.qLVT_MASTER.DataSetName = "QLVT_MASTER";
            this.qLVT_MASTER.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DSPMBindingSource
            // 
            this.v_DSPMBindingSource.DataMember = "V_DSPM";
            this.v_DSPMBindingSource.DataSource = this.qLVT_MASTER;
            // 
            // v_DSPMTableAdapter
            // 
            this.v_DSPMTableAdapter.ClearBeforeFill = true;
            // 
            // v_DSPMComboBox
            // 
            this.v_DSPMComboBox.DataSource = this.v_DSPMBindingSource;
            this.v_DSPMComboBox.DisplayMember = "description";
            this.v_DSPMComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.v_DSPMComboBox.FormattingEnabled = true;
            this.v_DSPMComboBox.Location = new System.Drawing.Point(134, 41);
            this.v_DSPMComboBox.Name = "v_DSPMComboBox";
            this.v_DSPMComboBox.Size = new System.Drawing.Size(199, 21);
            this.v_DSPMComboBox.TabIndex = 1;
            this.v_DSPMComboBox.ValueMember = "subscriber_server";
            this.v_DSPMComboBox.SelectedIndexChanged += new System.EventHandler(this.v_DSPMComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chi Nhánh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Login Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // LoginUserTextBox
            // 
            this.LoginUserTextBox.Location = new System.Drawing.Point(134, 87);
            this.LoginUserTextBox.Name = "LoginUserTextBox";
            this.LoginUserTextBox.Size = new System.Drawing.Size(199, 21);
            this.LoginUserTextBox.TabIndex = 5;
            // 
            // LoginPasswordTextBox
            // 
            this.LoginPasswordTextBox.Location = new System.Drawing.Point(134, 131);
            this.LoginPasswordTextBox.Name = "LoginPasswordTextBox";
            this.LoginPasswordTextBox.PasswordChar = '*';
            this.LoginPasswordTextBox.Size = new System.Drawing.Size(199, 21);
            this.LoginPasswordTextBox.TabIndex = 6;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(186, 182);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 7;
            this.LoginButton.Text = "LOGIN";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 261);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.LoginPasswordTextBox);
            this.Controls.Add(this.LoginUserTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.v_DSPMComboBox);
            this.Name = "FormDangNhap";
            this.Text = "FormDangNhap";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_MASTER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLVT_MASTER qLVT_MASTER;
        private System.Windows.Forms.BindingSource v_DSPMBindingSource;
        private QLVT_MASTERTableAdapters.V_DSPMTableAdapter v_DSPMTableAdapter;
        private System.Windows.Forms.ComboBox v_DSPMComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LoginUserTextBox;
        private System.Windows.Forms.TextBox LoginPasswordTextBox;
        private System.Windows.Forms.Button LoginButton;
    }
}