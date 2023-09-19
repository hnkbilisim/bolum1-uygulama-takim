using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_Takım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTakim1_Click(object sender, EventArgs e)
        {
            lblTakim.BackColor = Color.Red;
            lblTakim.ForeColor = Color.Yellow;
            lblTakim.Text = "ŞAMPİYON GALATASARAY";
        }

        private void btnTakim2_Click(object sender, EventArgs e)
        {
            lblTakim.BackColor = Color.Black;
            lblTakim.ForeColor= Color.White;
            lblTakim.Text = "BEŞİKTAŞ";
        }

        private void btnTakim3_Click(object sender, EventArgs e)
        {
            lblTakim.BackColor = Color.Purple;
            lblTakim.ForeColor = Color.White;
            lblTakim.Text = "TRABZON";
        }

        private void btnTakim4_Click(object sender, EventArgs e)
        {
            lblTakim.BackColor = Color.Green;
            lblTakim.ForeColor = Color.White;
            lblTakim.Text = "BURSASPOR";
        }
    }
}
