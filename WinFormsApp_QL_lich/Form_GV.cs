using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_QL_lich
{
    public partial class Form_GV : Form
    {
        public string ID_GV { get; set; }
        public Form_GV(string id)
        {
            InitializeComponent();
            ID_GV = id;  // Gán giá trị ID_GV
        }

        

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }
        private Form currentChildForm;
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_ttcn_Click(object sender, EventArgs e)
        {
            Form_ttcn form_ttcn = new Form_ttcn(ID_GV);  // Truyền ID_GV vào Form_ttcn
            OpenChildForm(form_ttcn);
            label1.Text = btn_ttcn.Text;
        }

        private void btn_lichgv_Click(object sender, EventArgs e)
        {
            Form_lichgv form_lichgv = new Form_lichgv(ID_GV);  // Truyền ID_GV vào Form_lichgv
            OpenChildForm(form_lichgv);
            label1.Text = btn_lichgv.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            label1.Text = "Trang chủ";
        }
    }
}
