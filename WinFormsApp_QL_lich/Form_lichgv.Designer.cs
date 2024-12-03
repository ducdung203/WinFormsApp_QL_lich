namespace WinFormsApp_QL_lich
{
    partial class Form_lichgv
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
            dgv_lichGv = new DataGridView();
            groupBox1 = new GroupBox();
            btn_tim = new Button();
            txt_tim = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_lichGv).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_lichGv
            // 
            dgv_lichGv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_lichGv.Location = new Point(12, 137);
            dgv_lichGv.Name = "dgv_lichGv";
            dgv_lichGv.RowHeadersWidth = 51;
            dgv_lichGv.Size = new Size(1006, 454);
            dgv_lichGv.TabIndex = 0;
            dgv_lichGv.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_tim);
            groupBox1.Controls.Add(txt_tim);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(666, 94);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // btn_tim
            // 
            btn_tim.Location = new Point(497, 32);
            btn_tim.Name = "btn_tim";
            btn_tim.Size = new Size(94, 29);
            btn_tim.TabIndex = 1;
            btn_tim.Text = "Tìm";
            btn_tim.UseVisualStyleBackColor = true;
            btn_tim.Click += btn_tim_Click;
            // 
            // txt_tim
            // 
            txt_tim.Location = new Point(42, 32);
            txt_tim.Name = "txt_tim";
            txt_tim.Size = new Size(344, 27);
            txt_tim.TabIndex = 0;
            // 
            // Form_lichgv
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 603);
            Controls.Add(groupBox1);
            Controls.Add(dgv_lichGv);
            Name = "Form_lichgv";
            Text = "Form_lichgv";
            Load += Form_lichgv_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_lichGv).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_lichGv;
        private GroupBox groupBox1;
        private Button btn_tim;
        private TextBox txt_tim;
    }
}