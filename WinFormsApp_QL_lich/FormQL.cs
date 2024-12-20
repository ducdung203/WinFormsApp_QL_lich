﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_QL_lich
{
    public partial class FormQL : Form
    {
        public FormQL()
        {
            InitializeComponent();
        }

        private void btDangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void FormQL_Load(object sender, EventArgs e)
        {

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

        private void btn_qldn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_qldn());
            label1.Text = btn_qldn.Text;

        }

        private void btn_qltt_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_qltt());
            label1.Text = btn_qltt.Text;
        }

        private void btn_qlL_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_qlL());
            label1.Text = btn_qlL.Text;
        }
        private void btnQL_môn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QL_mon());
            label1.Text = btnQL_môn.Text;

        }
        private void btnQl_khoa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQL_khoa());
            label1.Text = btnQl_khoa.Text;
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
