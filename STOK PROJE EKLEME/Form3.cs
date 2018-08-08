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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox7.Text);
            listBox1.Items.Add(textBox6.Text);
            listBox1.Items.Add(textBox5.Text);
            listBox1.Items.Add(textBox4.Text);
            listBox1.Items.Add(textBox3.Text);
            listBox1.Items.Add(textBox2.Text);
            listBox1.Items.Add(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
