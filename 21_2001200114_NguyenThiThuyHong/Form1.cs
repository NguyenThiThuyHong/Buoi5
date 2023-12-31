﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_2001200114_NguyenThiThuyHong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
      
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
                this.errorProvider1.SetError(ctr, "Giá trị nhập phải là số!");
            else
                this.errorProvider1.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length < 0 && !char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
                this.errorProvider1.SetError(ctr, "Giá trị nhập phải là số!");
            else
                this.errorProvider1.Clear();
        }

        private void cong_Click(object sender, EventArgs e)
        {
            int a, b, Kq;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            Kq = a + b;
            textBox3.Text = Kq.ToString();
        }

        private void tru_Click(object sender, EventArgs e)
        {
            int a, b, Kq;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            Kq = a - b;
            textBox3.Text = Kq.ToString();
        }

        private void nhan_Click(object sender, EventArgs e)
        {
            int a, b, Kq;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            Kq = a * b;
            textBox3.Text = Kq.ToString();
        }

        private void chia_Click(object sender, EventArgs e)
        {
            float a, b, Kq;
            a = float.Parse(textBox1.Text);
            b = float.Parse(textBox2.Text);
            if (b == 0)
            {
                MessageBox.Show("Nhập b khác 0");
            }
            else
            {
                Kq = a / b;
                textBox3.Text = Kq.ToString();
            }
        }


    }
}
