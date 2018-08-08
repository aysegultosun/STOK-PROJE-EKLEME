using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STOK_PROJE_EKLEME
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ürünFiyatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            this.Hide();
            frm5.Show();
        }

        private void siparişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            this.Hide();
            frm4.Show();
        }

        private void faturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            this.Hide();
            frm3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ufiyatı, adedi, kdv = 0, tutar, ttutar;
            ufiyatı = Convert.ToDouble(textBox6.Text);
            adedi = Convert.ToDouble(textBox8.Text);
            tutar = ufiyatı * adedi;
            if (radioButton1.Checked)
            { kdv = tutar * 0.18; }
            if (radioButton2.Checked)
            { kdv = tutar * 0.08; }
            if (radioButton3.Checked)
            { kdv = tutar * 0.01; }
            ttutar = tutar + kdv;
            textBox9.Text = kdv.ToString();
            textBox7.Text = ttutar.ToString();
        }
    }
}
