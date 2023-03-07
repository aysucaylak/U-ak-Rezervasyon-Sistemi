using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uçak_Rezervasyon_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota:" + comboBox1.Text + "-" + comboBox2.Text + "   Tarih: " + dateTimePicker1.Text + "   Saat: " + maskedTextBox1.Text + "   Yolcu Bilgileri-  Ad Soyad: " + textBox1.Text + "   TC: " + maskedTextBox2.Text + "  Telefon: " + maskedTextBox3.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text= comboBox2.Text;
            comboBox2.Text= comboBox1.Text;
            comboBox1.Text= label9.Text;
        }
    }
}
