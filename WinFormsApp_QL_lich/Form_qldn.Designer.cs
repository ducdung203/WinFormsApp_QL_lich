namespace WinFormsApp_QL_lich
{
    partial class Form_qldn
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
            btn_Them = new Button();
            btn_sua = new Button();
            btn_xoa = new Button();
            button4 = new Button();
            groupBox1 = new GroupBox();
            label5 = new Label();
            txt_idGV = new TextBox();
            cb_role = new ComboBox();
            txtMK = new TextBox();
            txtTK = new TextBox();
            txtID = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgv_qldn = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_qldn).BeginInit();
            SuspendLayout();
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(66, 215);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(94, 29);
            btn_Them.TabIndex = 0;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(305, 215);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(94, 29);
            btn_sua.TabIndex = 1;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(591, 215);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(94, 29);
            btn_xoa.TabIndex = 2;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // button4
            // 
            button4.Location = new Point(847, 215);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = "Thoát";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_idGV);
            groupBox1.Controls.Add(cb_role);
            groupBox1.Controls.Add(txtMK);
            groupBox1.Controls.Add(txtTK);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1006, 174);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin tài khoản";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(524, 87);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 10;
            label5.Text = "Id_GV";
            // 
            // txt_idGV
            // 
            txt_idGV.Location = new Point(709, 83);
            txt_idGV.Name = "txt_idGV";
            txt_idGV.Size = new Size(202, 27);
            txt_idGV.TabIndex = 9;
            // 
            // cb_role
            // 
            cb_role.FormattingEnabled = true;
            cb_role.Items.AddRange(new object[] { "admin", "teacher" });
            cb_role.Location = new Point(709, 34);
            cb_role.Name = "cb_role";
            cb_role.Size = new Size(202, 28);
            cb_role.TabIndex = 8;
            // 
            // txtMK
            // 
            txtMK.Location = new Point(119, 132);
            txtMK.Name = "txtMK";
            txtMK.Size = new Size(205, 27);
            txtMK.TabIndex = 7;
            // 
            // txtTK
            // 
            txtTK.Location = new Point(119, 80);
            txtTK.Name = "txtTK";
            txtTK.Size = new Size(205, 27);
            txtTK.TabIndex = 5;
            // 
            // txtID
            // 
            txtID.Location = new Point(119, 38);
            txtID.Name = "txtID";
            txtID.Size = new Size(205, 27);
            txtID.TabIndex = 4;
            txtID.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 132);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 83);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 2;
            label3.Text = "Tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(522, 41);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "quyền";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 37);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 0;
            label1.Text = "Id";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_qldn);
            groupBox2.Location = new Point(12, 263);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1006, 328);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin tài khoản";
            // 
            // dgv_qldn
            // 
            dgv_qldn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_qldn.Location = new Point(6, 26);
            dgv_qldn.Name = "dgv_qldn";
            dgv_qldn.RowHeadersWidth = 51;
            dgv_qldn.Size = new Size(986, 296);
            dgv_qldn.TabIndex = 0;
            dgv_qldn.CellContentClick += dgv_qldn_CellContentClick;
            // 
            // Form_qldn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 603);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button4);
            Controls.Add(btn_xoa);
            Controls.Add(btn_sua);
            Controls.Add(btn_Them);
            Name = "Form_qldn";
            Text = "Form_qldn";
            Load += Form_qldn_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_qldn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Them;
        private Button btn_sua;
        private Button btn_xoa;
        private Button button4;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtMK;
        private TextBox txtTK;
        private TextBox txtID;
        private GroupBox groupBox2;
        private DataGridView dgv_qldn;
        private ComboBox cb_role;
        private TextBox txt_idGV;
        private Label label5;
    }
}