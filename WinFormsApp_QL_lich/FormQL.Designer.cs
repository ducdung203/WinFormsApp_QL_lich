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
            btDangxuat = new Button();
            SuspendLayout();
            // 
            // btDangxuat
            // 
            btDangxuat.Location = new Point(440, 347);
            btDangxuat.Name = "btDangxuat";
            btDangxuat.Size = new Size(94, 29);
            btDangxuat.TabIndex = 0;
            btDangxuat.Text = "Đăng xuất";
            btDangxuat.UseVisualStyleBackColor = true;
            btDangxuat.Click += btDangxuat_Click;
            // 
            // FormQL
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btDangxuat);
            Name = "FormQL";
            Text = "Quản lí lịch giảng viên";
            ResumeLayout(false);
        }

        #endregion

        private Button btDangxuat;
    }
}