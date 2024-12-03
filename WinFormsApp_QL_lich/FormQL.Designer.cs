namespace WinFormsApp_QL_lich
{
    partial class FormQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQL));
            btDangxuat = new Button();
            panel_left = new Panel();
            btnQl_khoa = new Button();
            btnQL_môn = new Button();
            btn_qlL = new Button();
            btn_qltt = new Button();
            btn_qldn = new Button();
            pictureBox1 = new PictureBox();
            panel_top = new Panel();
            label1 = new Label();
            panel_body = new Panel();
            panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_top.SuspendLayout();
            SuspendLayout();
            // 
            // btDangxuat
            // 
            btDangxuat.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btDangxuat.Location = new Point(29, 653);
            btDangxuat.Name = "btDangxuat";
            btDangxuat.Size = new Size(115, 35);
            btDangxuat.TabIndex = 0;
            btDangxuat.Text = "Đăng xuất";
            btDangxuat.UseVisualStyleBackColor = true;
            btDangxuat.Click += btDangxuat_Click;
            // 
            // panel_left
            // 
            panel_left.BackColor = SystemColors.ActiveCaption;
            panel_left.Controls.Add(btnQl_khoa);
            panel_left.Controls.Add(btnQL_môn);
            panel_left.Controls.Add(btn_qlL);
            panel_left.Controls.Add(btn_qltt);
            panel_left.Controls.Add(btn_qldn);
            panel_left.Controls.Add(pictureBox1);
            panel_left.Controls.Add(btDangxuat);
            panel_left.Dock = DockStyle.Left;
            panel_left.ForeColor = SystemColors.ControlText;
            panel_left.Location = new Point(0, 0);
            panel_left.Name = "panel_left";
            panel_left.Size = new Size(177, 713);
            panel_left.TabIndex = 1;
            // 
            // btnQl_khoa
            // 
            btnQl_khoa.Dock = DockStyle.Top;
            btnQl_khoa.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQl_khoa.Location = new Point(0, 370);
            btnQl_khoa.Name = "btnQl_khoa";
            btnQl_khoa.Size = new Size(177, 55);
            btnQl_khoa.TabIndex = 6;
            btnQl_khoa.Text = "Quản lí khoa";
            btnQl_khoa.UseVisualStyleBackColor = true;
            btnQl_khoa.Click += btnQl_khoa_Click;
            // 
            // btnQL_môn
            // 
            btnQL_môn.Dock = DockStyle.Top;
            btnQL_môn.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQL_môn.Location = new Point(0, 316);
            btnQL_môn.Name = "btnQL_môn";
            btnQL_môn.Size = new Size(177, 54);
            btnQL_môn.TabIndex = 5;
            btnQL_môn.Text = "Quản lí môn";
            btnQL_môn.UseVisualStyleBackColor = true;
            btnQL_môn.Click += btnQL_môn_Click;
            // 
            // btn_qlL
            // 
            btn_qlL.Dock = DockStyle.Top;
            btn_qlL.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_qlL.Location = new Point(0, 266);
            btn_qlL.Name = "btn_qlL";
            btn_qlL.Size = new Size(177, 50);
            btn_qlL.TabIndex = 4;
            btn_qlL.Text = "Quản lý Lịch";
            btn_qlL.UseVisualStyleBackColor = true;
            btn_qlL.Click += btn_qlL_Click;
            // 
            // btn_qltt
            // 
            btn_qltt.Dock = DockStyle.Top;
            btn_qltt.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_qltt.Location = new Point(0, 215);
            btn_qltt.Name = "btn_qltt";
            btn_qltt.Size = new Size(177, 51);
            btn_qltt.TabIndex = 3;
            btn_qltt.Text = "Quản lý thông tin";
            btn_qltt.UseVisualStyleBackColor = true;
            btn_qltt.Click += btn_qltt_Click;
            // 
            // btn_qldn
            // 
            btn_qldn.Dock = DockStyle.Top;
            btn_qldn.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_qldn.Location = new Point(0, 164);
            btn_qldn.Name = "btn_qldn";
            btn_qldn.Size = new Size(177, 51);
            btn_qldn.TabIndex = 2;
            btn_qldn.Text = "Quản lý đăng nhập";
            btn_qldn.UseVisualStyleBackColor = true;
            btn_qldn.Click += btn_qldn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel_top
            // 
            panel_top.BackColor = SystemColors.ActiveCaption;
            panel_top.Controls.Add(label1);
            panel_top.Dock = DockStyle.Top;
            panel_top.Location = new Point(177, 0);
            panel_top.Name = "panel_top";
            panel_top.Size = new Size(1048, 63);
            panel_top.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(101, 19);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 0;
            label1.Text = "Trang chủ";
            // 
            // panel_body
            // 
            panel_body.BackColor = SystemColors.Control;
            panel_body.Dock = DockStyle.Fill;
            panel_body.Location = new Point(177, 63);
            panel_body.Name = "panel_body";
            panel_body.Size = new Size(1048, 650);
            panel_body.TabIndex = 3;
            // 
            // FormQL
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 713);
            Controls.Add(panel_body);
            Controls.Add(panel_top);
            Controls.Add(panel_left);
            Name = "FormQL";
            Text = "Quản lí lịch giảng viên";
            Load += FormQL_Load;
            panel_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_top.ResumeLayout(false);
            panel_top.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btDangxuat;
        private Panel panel_left;
        private Panel panel_top;
        private Panel panel_body;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btn_qldn;
        private Button btn_qlL;
        private Button btn_qltt;
        private Button btnQL_môn;
        private Button btnQl_khoa;
    }
}