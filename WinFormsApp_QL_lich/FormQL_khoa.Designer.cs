namespace WinFormsApp_QL_lich
{
    partial class FormQL_khoa
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
            txt_khoa = new TextBox();
            txt_makhoa = new TextBox();
            txt_id = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgv_qlkhoa = new DataGridView();
            btn_Them = new Button();
            btn_Sua = new Button();
            btn_xoa = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_qlkhoa).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_khoa);
            groupBox1.Controls.Add(txt_makhoa);
            groupBox1.Controls.Add(txt_id);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(507, 219);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // txt_khoa
            // 
            txt_khoa.Location = new Point(182, 134);
            txt_khoa.Name = "txt_khoa";
            txt_khoa.Size = new Size(162, 27);
            txt_khoa.TabIndex = 5;
            // 
            // txt_makhoa
            // 
            txt_makhoa.Location = new Point(182, 82);
            txt_makhoa.Name = "txt_makhoa";
            txt_makhoa.Size = new Size(162, 27);
            txt_makhoa.TabIndex = 4;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(182, 34);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(162, 27);
            txt_id.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 134);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên khoa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 82);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã khoa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 34);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // dgv_qlkhoa
            // 
            dgv_qlkhoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_qlkhoa.Location = new Point(12, 250);
            dgv_qlkhoa.Name = "dgv_qlkhoa";
            dgv_qlkhoa.RowHeadersWidth = 51;
            dgv_qlkhoa.Size = new Size(1006, 341);
            dgv_qlkhoa.TabIndex = 1;
            dgv_qlkhoa.CellContentClick += dgv_qlkhoa_CellContentClick;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(659, 37);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(94, 29);
            btn_Them.TabIndex = 2;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(659, 85);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(94, 29);
            btn_Sua.TabIndex = 3;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(659, 137);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(94, 29);
            btn_xoa.TabIndex = 4;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // FormQL_khoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 603);
            Controls.Add(btn_xoa);
            Controls.Add(btn_Sua);
            Controls.Add(btn_Them);
            Controls.Add(dgv_qlkhoa);
            Controls.Add(groupBox1);
            Name = "FormQL_khoa";
            Text = "FormQL_khoa";
            Load += FormQL_khoa_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_qlkhoa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt_khoa;
        private TextBox txt_makhoa;
        private TextBox txt_id;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgv_qlkhoa;
        private Button btn_Them;
        private Button btn_Sua;
        private Button btn_xoa;
    }
}