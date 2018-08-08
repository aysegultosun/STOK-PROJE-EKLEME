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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SİPARİŞ AL KODLARI
            //ucret ve ekstra adında değişkenler tanımlıyoruz
            decimal ucret = 0;
            string ekstra = "";

            //Eğer checkbox'lar seçili ise ekstra değişkenine aktarılıyor.
            if (checkBox1.Checked == true)
            { ekstra += "Gıda"; }
            if (checkBox5.Checked == true)
            { ekstra += " - " + "Boyalar"; }
            if (checkBox3.Checked == true)
            { ekstra += " - " + "Giyim"; }
            if (checkBox6.Checked == true)
            { ekstra += " - " + "İnşaat Malzemeleri"; }
            if (checkBox2.Checked == true)
            { ekstra += " - " + "Yapıştırıcı Ve Bantlar"; }
            if (checkBox4.Checked == true)
            { ekstra += " - " + "Teknoloji"; }

            //Seçili olan değeri ucret değişkenine adet bilgisi ile çarparak ekliyoruz.
            if (comboBox1.Text == "Küçük")
            { ucret = numericUpDown1.Value * 10;
            }
            else if (comboBox1.Text == "Orta")
            { ucret = numericUpDown1.Value * 15;
            }
            else if (comboBox1.Text == "Büyük")
            { ucret = numericUpDown1.Value * 20;
            }


            if (comboBox2.Text == "Küçük")
            { ucret += numericUpDown2.Value * 5;
            }
            else if (comboBox2.Text == "Büyük")
            { ucret += numericUpDown2.Value * 3;
            }
            else if (comboBox2.Text == "Orta")
            { ucret += numericUpDown2.Value * 3;
            }


            //Listbox'a değerleri yazdırıyoruz.
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
            listBox4.Items.Add(numericUpDown1.Value + " adet " + comboBox1.Text);
            listBox5.Items.Add(numericUpDown2.Value + " adet " + comboBox2.Text);
            listBox6.Items.Add(ekstra);
            listBox7.Items.Add(ucret + "TL");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //TEMİZLE KODU
            //Textbox değerlerini temizliyoruz
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            //combobox değerlerini temizliyoruz
            comboBox2.Text = "";
            comboBox1.Text = "";
            //numericupdown değerlerini temizliyoruz
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;

            //checkbox değerlerini temizliyoruz
            checkBox1.Checked = false;
            checkBox5.Checked = false;
            checkBox3.Checked = false;
            checkBox6.Checked = false;
            checkBox2.Checked = false;
            checkBox4.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //SİPARİŞLERİ TEMİZLE
            //Listbox'ları temizliyoruz.
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
        }
    }
}
