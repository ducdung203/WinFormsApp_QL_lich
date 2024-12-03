namespace WinFormsApp_QL_lich
{
    partial class Form_ttcn
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
            labelID = new Label();
            groupBox1 = new GroupBox();
            labelEmail = new Label();
            labelPhone = new Label();
            labelName = new Label();
            labelKhoa = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(37, 48);
            labelID.Name = "labelID";
            labelID.Size = new Size(101, 20);
            labelID.TabIndex = 2;
            labelID.Text = "Giảng viên ID:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelKhoa);
            groupBox1.Controls.Add(labelEmail);
            groupBox1.Controls.Add(labelPhone);
            groupBox1.Controls.Add(labelName);
            groupBox1.Controls.Add(labelID);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 426);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "thông tin cá nhân";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(37, 195);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(49, 20);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "Email:";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(37, 149);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(100, 20);
            labelPhone.TabIndex = 4;
            labelPhone.Text = "Số điện thoại:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(37, 97);
            labelName.Name = "labelName";
            labelName.Size = new Size(35, 20);
            labelName.TabIndex = 3;
            labelName.Text = "Tên:";
            // 
            // labelKhoa
            // 
            labelKhoa.AutoSize = true;
            labelKhoa.Location = new Point(37, 249);
            labelKhoa.Name = "labelKhoa";
            labelKhoa.Size = new Size(43, 20);
            labelKhoa.TabIndex = 6;
            labelKhoa.Text = "Khoa";
            // 
            // Form_ttcn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form_ttcn";
            Text = "Form_ttcn";
            Load += Form_ttcn_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label labelID;
        private GroupBox groupBox1;
        private Label labelEmail;
        private Label labelPhone;
        private Label labelName;
        private Label labelKhoa;
    }
}