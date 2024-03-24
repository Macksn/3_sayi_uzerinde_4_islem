using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace garip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı1, sayı2, sayı3, sonuç;
            sayı1 = Convert.ToInt16(textBox1.Text);
            sayı2 = Convert.ToInt16(textBox2.Text);
            sayı3 = Convert.ToInt16(textBox4.Text);
            sonuç = sayı1 + sayı2 + sayı3;
            textBox3.Text = sonuç.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayı1, sayı2, sonuç;
            sayı1 = Convert.ToInt16(textBox1.Text);
            sayı2 = Convert.ToInt16(textBox2.Text);
            sonuç = sayı1 - sayı2;
            textBox3.Text = sonuç.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayı1, sayı2, sonuç;
            sayı1 = Convert.ToInt16(textBox1.Text);
            sayı2 = Convert.ToInt16(textBox2.Text);
            sonuç = sayı1 * sayı2;
            textBox3.Text = sonuç.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayı1, sayı2, sonuç;
            sayı1 = Convert.ToInt16(textBox1.Text);
            sayı2 = Convert.ToInt16(textBox2.Text);
            sonuç = sayı1 / sayı2;
            textBox3.Text = sonuç.ToString();
        }
    }
}
