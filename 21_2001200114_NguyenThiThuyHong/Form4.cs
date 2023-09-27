using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            int kq;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = Convert.ToInt32(textBox3.Text);
            if (a >= b && a >= c)
                textBox4.Text = a.ToString();
            if (b >= c && b >= a)
                textBox4.Text = b.ToString();
            if(c>=b&&c>=a)
                textBox4.Text = c.ToString();
        }
    }
}
