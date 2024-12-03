namespace WinFormsApp_QL_lich
{
    partial class QL_mon
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
            dvg_qlmon = new DataGridView();
            txt_id = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_Them = new Button();
            btn_sua = new Button();
            btn_xoa = new Button();
            groupBox1 = new GroupBox();
            txt_tin = new TextBox();
            txt_mon = new TextBox();
            txt_id_khoa = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dvg_qlmon).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dvg_qlmon
            // 
            dvg_qlmon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg_qlmon.Location = new Point(12, 261);
            dvg_qlmon.Name = "dvg_qlmon";
            dvg_qlmon.RowHeadersWidth = 51;
            dvg_qlmon.Size = new Size(1006, 330);
            dvg_qlmon.TabIndex = 0;
            dvg_qlmon.CellContentClick += dvg_qlmon_CellContentClick;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(162, 26);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(158, 27);
            txt_id.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 23);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 120);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 3;
            label2.Text = "Tên môn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 167);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 4;
            label3.Text = "Số tín";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 29);
            label4.Name = "label4";
            label4.Size = new Size(24, 20);
            label4.TabIndex = 5;
            label4.Text = "ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 71);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 6;
            label5.Text = "ID khoa";
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(829, 32);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(94, 29);
            btn_Them.TabIndex = 7;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(829, 93);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(94, 29);
            btn_sua.TabIndex = 8;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(829, 155);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(94, 29);
            btn_xoa.TabIndex = 9;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_tin);
            groupBox1.Controls.Add(txt_mon);
            groupBox1.Controls.Add(txt_id_khoa);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_id);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(765, 218);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // txt_tin
            // 
            txt_tin.Location = new Point(162, 160);
            txt_tin.Name = "txt_tin";
            txt_tin.Size = new Size(187, 27);
            txt_tin.TabIndex = 9;
            // 
            // txt_mon
            // 
            txt_mon.Location = new Point(162, 113);
            txt_mon.Name = "txt_mon";
            txt_mon.Size = new Size(187, 27);
            txt_mon.TabIndex = 8;
            // 
            // txt_id_khoa
            // 
            txt_id_khoa.Location = new Point(162, 71);
            txt_id_khoa.Name = "txt_id_khoa";
            txt_id_khoa.Size = new Size(187, 27);
            txt_id_khoa.TabIndex = 7;
            // 
            // QL_mon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 603);
            Controls.Add(groupBox1);
            Controls.Add(btn_xoa);
            Controls.Add(btn_sua);
            Controls.Add(btn_Them);
            Controls.Add(label1);
            Controls.Add(dvg_qlmon);
            Name = "QL_mon";
            Text = "QL_mon";
            Load += QL_mon_Load;
            ((System.ComponentModel.ISupportInitialize)dvg_qlmon).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dvg_qlmon;
        private TextBox txt_id;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_Them;
        private Button btn_sua;
        private Button btn_xoa;
        private GroupBox groupBox1;
        private TextBox txt_tin;
        private TextBox txt_mon;
        private TextBox txt_id_khoa;
    }
}