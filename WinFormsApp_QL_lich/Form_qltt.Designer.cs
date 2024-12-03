namespace WinFormsApp_QL_lich
{
    partial class Form_qltt
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
            txt_So = new TextBox();
            txtMa_khoa = new TextBox();
            txt_email = new TextBox();
            txt_Ten = new TextBox();
            txt_id = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgv_qltt = new DataGridView();
            btn_them = new Button();
            btn_sua = new Button();
            btn_xoa = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_qltt).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_So);
            groupBox1.Controls.Add(txtMa_khoa);
            groupBox1.Controls.Add(txt_email);
            groupBox1.Controls.Add(txt_Ten);
            groupBox1.Controls.Add(txt_id);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(627, 198);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin";
            // 
            // txt_So
            // 
            txt_So.Location = new Point(450, 72);
            txt_So.Name = "txt_So";
            txt_So.Size = new Size(125, 27);
            txt_So.TabIndex = 9;
            // 
            // txtMa_khoa
            // 
            txtMa_khoa.Location = new Point(450, 32);
            txtMa_khoa.Name = "txtMa_khoa";
            txtMa_khoa.Size = new Size(125, 27);
            txtMa_khoa.TabIndex = 8;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(122, 116);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(125, 27);
            txt_email.TabIndex = 7;
            // 
            // txt_Ten
            // 
            txt_Ten.Location = new Point(122, 70);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.Size = new Size(125, 27);
            txt_Ten.TabIndex = 6;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(122, 26);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(125, 27);
            txt_id.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(320, 29);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 4;
            label5.Text = "Khoa/Bộ môn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(320, 70);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 114);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 70);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Họ Tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 29);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_qltt);
            groupBox2.Location = new Point(12, 216);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1006, 375);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin";
            // 
            // dgv_qltt
            // 
            dgv_qltt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_qltt.Location = new Point(6, 26);
            dgv_qltt.Name = "dgv_qltt";
            dgv_qltt.RowHeadersWidth = 51;
            dgv_qltt.Size = new Size(994, 343);
            dgv_qltt.TabIndex = 0;
            dgv_qltt.CellContentClick += dgv_qltt_CellContentClick;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(659, 32);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(94, 29);
            btn_them.TabIndex = 3;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(659, 80);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(94, 29);
            btn_sua.TabIndex = 4;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(659, 127);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(94, 29);
            btn_xoa.TabIndex = 5;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // Form_qltt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 603);
            Controls.Add(btn_xoa);
            Controls.Add(btn_sua);
            Controls.Add(btn_them);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form_qltt";
            Text = "Form_qltt";
            Load += Form_qltt_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_qltt).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgv_qltt;
        private Button btn_them;
        private Button btn_sua;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btn_xoa;
        private Button button5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private TextBox txt_So;
        private TextBox txtMa_khoa;
        private TextBox txt_email;
        private TextBox txt_Ten;
        private TextBox txt_id;
    }
}