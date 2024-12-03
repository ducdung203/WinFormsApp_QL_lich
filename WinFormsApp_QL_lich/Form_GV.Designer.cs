namespace WinFormsApp_QL_lich
{
    partial class Form_GV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_GV));
            panel_left = new Panel();
            btn_dangxuat = new Button();
            btn_lichgv = new Button();
            btn_ttcn = new Button();
            pictureBox1 = new PictureBox();
            panel_top = new Panel();
            label1 = new Label();
            panel_body = new Panel();
            panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_top.SuspendLayout();
            SuspendLayout();
            // 
            // panel_left
            // 
            panel_left.BackColor = SystemColors.ActiveCaption;
            panel_left.Controls.Add(btn_dangxuat);
            panel_left.Controls.Add(btn_lichgv);
            panel_left.Controls.Add(btn_ttcn);
            panel_left.Controls.Add(pictureBox1);
            panel_left.Dock = DockStyle.Left;
            panel_left.Location = new Point(0, 0);
            panel_left.Name = "panel_left";
            panel_left.Size = new Size(177, 713);
            panel_left.TabIndex = 0;
            // 
            // btn_dangxuat
            // 
            btn_dangxuat.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_dangxuat.Location = new Point(32, 644);
            btn_dangxuat.Name = "btn_dangxuat";
            btn_dangxuat.Size = new Size(109, 29);
            btn_dangxuat.TabIndex = 3;
            btn_dangxuat.Text = "Đăng xuất";
            btn_dangxuat.UseVisualStyleBackColor = true;
            btn_dangxuat.Click += btn_dangxuat_Click;
            // 
            // btn_lichgv
            // 
            btn_lichgv.Dock = DockStyle.Top;
            btn_lichgv.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_lichgv.Location = new Point(0, 225);
            btn_lichgv.Name = "btn_lichgv";
            btn_lichgv.Size = new Size(177, 60);
            btn_lichgv.TabIndex = 2;
            btn_lichgv.Text = "Lịch giảng dạy";
            btn_lichgv.UseVisualStyleBackColor = true;
            btn_lichgv.Click += btn_lichgv_Click;
            // 
            // btn_ttcn
            // 
            btn_ttcn.Dock = DockStyle.Top;
            btn_ttcn.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ttcn.Location = new Point(0, 167);
            btn_ttcn.Name = "btn_ttcn";
            btn_ttcn.Size = new Size(177, 58);
            btn_ttcn.TabIndex = 1;
            btn_ttcn.Text = "Thông tin cá nhân";
            btn_ttcn.UseVisualStyleBackColor = true;
            btn_ttcn.Click += btn_ttcn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
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
            panel_top.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(54, 22);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 0;
            label1.Text = "Trang chủ";
            // 
            // panel_body
            // 
            panel_body.Dock = DockStyle.Fill;
            panel_body.Location = new Point(177, 63);
            panel_body.Name = "panel_body";
            panel_body.Size = new Size(1048, 650);
            panel_body.TabIndex = 2;
            // 
            // Form_GV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 713);
            Controls.Add(panel_body);
            Controls.Add(panel_top);
            Controls.Add(panel_left);
            Name = "Form_GV";
            panel_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_top.ResumeLayout(false);
            panel_top.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_left;
        private Panel panel_top;
        private Panel panel_body;
        private PictureBox pictureBox1;
        private Button btn_lichgv;
        private Button btn_ttcn;
        private Label label1;
        private Button btn_dangxuat;
    }
}