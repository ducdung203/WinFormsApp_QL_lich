namespace WinFormsApp_QL_lich
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btDangnhap = new Button();
            btThoat = new Button();
            txtTaikhoan = new TextBox();
            txtMatkhau = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btDangnhap
            // 
            btDangnhap.Location = new Point(99, 192);
            btDangnhap.Name = "btDangnhap";
            btDangnhap.Size = new Size(94, 29);
            btDangnhap.TabIndex = 0;
            btDangnhap.Text = "Đăng nhập";
            btDangnhap.UseVisualStyleBackColor = true;
            btDangnhap.Click += btDangnhap_Click;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(307, 192);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(94, 29);
            btThoat.TabIndex = 1;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // txtTaikhoan
            // 
            txtTaikhoan.Location = new Point(198, 47);
            txtTaikhoan.Name = "txtTaikhoan";
            txtTaikhoan.Size = new Size(183, 27);
            txtTaikhoan.TabIndex = 2;
            // 
            // txtMatkhau
            // 
            txtMatkhau.Location = new Point(198, 106);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.Size = new Size(183, 27);
            txtMatkhau.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 50);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 4;
            label1.Text = "Tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 109);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Mật khẩu";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 285);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMatkhau);
            Controls.Add(txtTaikhoan);
            Controls.Add(btThoat);
            Controls.Add(btDangnhap);
            Name = "Form1";
            Text = "Đăng Nhập";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btDangnhap;
        private Button btThoat;
        private TextBox txtTaikhoan;
        private TextBox txtMatkhau;
        private Label label1;
        private Label label2;
    }
}
