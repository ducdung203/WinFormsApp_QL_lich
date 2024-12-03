namespace WinFormsApp_QL_lich
{
    partial class Form_qlL
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
            groupBox1 = new GroupBox();
            txt_tim = new TextBox();
            btn_tim = new Button();
            groupBox2 = new GroupBox();
            btn_xoa = new Button();
            btn_sua = new Button();
            btn_them = new Button();
            dtp_giokt = new DateTimePicker();
            dtp_giobd = new DateTimePicker();
            dtp_ngaykt = new DateTimePicker();
            dtp_ngaybd = new DateTimePicker();
            cb_thu = new ComboBox();
            txt_sv = new TextBox();
            txt_phong = new TextBox();
            txt_idGv = new TextBox();
            txt_idmon = new TextBox();
            txtid = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgv_qlL = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_qlL).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_tim);
            groupBox1.Controls.Add(btn_tim);
            groupBox1.Location = new Point(22, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(663, 63);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // txt_tim
            // 
            txt_tim.Location = new Point(61, 26);
            txt_tim.Name = "txt_tim";
            txt_tim.Size = new Size(433, 27);
            txt_tim.TabIndex = 1;
            // 
            // btn_tim
            // 
            btn_tim.Location = new Point(543, 26);
            btn_tim.Name = "btn_tim";
            btn_tim.Size = new Size(94, 29);
            btn_tim.TabIndex = 0;
            btn_tim.Text = "Tìm";
            btn_tim.UseVisualStyleBackColor = true;
            btn_tim.Click += btn_tim_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_xoa);
            groupBox2.Controls.Add(btn_sua);
            groupBox2.Controls.Add(btn_them);
            groupBox2.Controls.Add(dtp_giokt);
            groupBox2.Controls.Add(dtp_giobd);
            groupBox2.Controls.Add(dtp_ngaykt);
            groupBox2.Controls.Add(dtp_ngaybd);
            groupBox2.Controls.Add(cb_thu);
            groupBox2.Controls.Add(txt_sv);
            groupBox2.Controls.Add(txt_phong);
            groupBox2.Controls.Add(txt_idGv);
            groupBox2.Controls.Add(txt_idmon);
            groupBox2.Controls.Add(txtid);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(22, 72);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(996, 270);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(780, 170);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(94, 29);
            btn_xoa.TabIndex = 27;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(780, 105);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(94, 29);
            btn_sua.TabIndex = 26;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(780, 55);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(94, 29);
            btn_them.TabIndex = 25;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // dtp_giokt
            // 
            dtp_giokt.CustomFormat = "HH:mm";
            dtp_giokt.Format = DateTimePickerFormat.Custom;
            dtp_giokt.Location = new Point(452, 102);
            dtp_giokt.Name = "dtp_giokt";
            dtp_giokt.Size = new Size(151, 27);
            dtp_giokt.TabIndex = 24;
            // 
            // dtp_giobd
            // 
            dtp_giobd.CustomFormat = "HH:mm";
            dtp_giobd.Format = DateTimePickerFormat.Custom;
            dtp_giobd.Location = new Point(452, 61);
            dtp_giobd.Name = "dtp_giobd";
            dtp_giobd.Size = new Size(151, 27);
            dtp_giobd.TabIndex = 23;
            // 
            // dtp_ngaykt
            // 
            dtp_ngaykt.CustomFormat = "dd/MM/yyyy";
            dtp_ngaykt.Format = DateTimePickerFormat.Custom;
            dtp_ngaykt.Location = new Point(135, 184);
            dtp_ngaykt.Name = "dtp_ngaykt";
            dtp_ngaykt.Size = new Size(155, 27);
            dtp_ngaykt.TabIndex = 22;
            // 
            // dtp_ngaybd
            // 
            dtp_ngaybd.CustomFormat = "dd/MM/yyyy";
            dtp_ngaybd.Format = DateTimePickerFormat.Custom;
            dtp_ngaybd.Location = new Point(135, 140);
            dtp_ngaybd.Name = "dtp_ngaybd";
            dtp_ngaybd.Size = new Size(155, 27);
            dtp_ngaybd.TabIndex = 21;
            // 
            // cb_thu
            // 
            cb_thu.FormattingEnabled = true;
            cb_thu.Items.AddRange(new object[] { "2", "3", "4", "5", "6", "7", "chủ nhật" });
            cb_thu.Location = new Point(452, 23);
            cb_thu.Name = "cb_thu";
            cb_thu.Size = new Size(151, 28);
            cb_thu.TabIndex = 20;
            // 
            // txt_sv
            // 
            txt_sv.Location = new Point(452, 184);
            txt_sv.Name = "txt_sv";
            txt_sv.Size = new Size(151, 27);
            txt_sv.TabIndex = 19;
            // 
            // txt_phong
            // 
            txt_phong.Location = new Point(452, 144);
            txt_phong.Name = "txt_phong";
            txt_phong.Size = new Size(151, 27);
            txt_phong.TabIndex = 18;
            // 
            // txt_idGv
            // 
            txt_idGv.Location = new Point(135, 99);
            txt_idGv.Name = "txt_idGv";
            txt_idGv.Size = new Size(155, 27);
            txt_idGv.TabIndex = 12;
            // 
            // txt_idmon
            // 
            txt_idmon.Location = new Point(135, 61);
            txt_idmon.Name = "txt_idmon";
            txt_idmon.Size = new Size(155, 27);
            txt_idmon.TabIndex = 11;
            // 
            // txtid
            // 
            txtid.Location = new Point(135, 23);
            txtid.Name = "txtid";
            txtid.Size = new Size(155, 27);
            txtid.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(336, 26);
            label10.Name = "label10";
            label10.Size = new Size(31, 20);
            label10.TabIndex = 9;
            label10.Text = "thứ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 64);
            label9.Name = "label9";
            label9.Size = new Size(64, 20);
            label9.TabIndex = 8;
            label9.Text = "Mã môn";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 106);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 7;
            label8.Text = "Mã GV";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 145);
            label7.Name = "label7";
            label7.Size = new Size(96, 20);
            label7.TabIndex = 6;
            label7.Text = "ngày bắt đầu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 189);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 5;
            label6.Text = "ngày kết thúc";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(333, 64);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 4;
            label5.Text = "giờ bắt đầu ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(333, 107);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 3;
            label4.Text = "giờ kết thúc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(333, 147);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 2;
            label3.Text = "phòng học";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(333, 191);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 1;
            label2.Text = "Số SV đăng kí";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 26);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // dgv_qlL
            // 
            dgv_qlL.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_qlL.Location = new Point(22, 359);
            dgv_qlL.Name = "dgv_qlL";
            dgv_qlL.RowHeadersWidth = 51;
            dgv_qlL.Size = new Size(996, 232);
            dgv_qlL.TabIndex = 2;
            dgv_qlL.CellContentClick += dgv_qlL_CellContentClick;
            // 
            // Form_qlL
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 603);
            Controls.Add(dgv_qlL);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form_qlL";
            Text = "Form_qlL";
            Load += Form_qlL_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_qlL).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt_tim;
        private Button btn_tim;
        private GroupBox groupBox2;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgv_qlL;
        private TextBox txt_sv;
        private TextBox txt_phong;
        private TextBox txt_idGv;
        private TextBox txt_idmon;
        private TextBox txtid;
        private DateTimePicker dtp_giokt;
        private DateTimePicker dtp_giobd;
        private DateTimePicker dtp_ngaykt;
        private DateTimePicker dtp_ngaybd;
        private ComboBox cb_thu;
        private Button btn_xoa;
        private Button btn_sua;
        private Button btn_them;
    }
}