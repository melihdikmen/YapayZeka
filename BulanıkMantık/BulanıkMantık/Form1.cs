using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BulanıkMantık
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

        private void button1_Click(object sender, EventArgs e)
        {
            List<double> sonuclar = new List<double>();
            try
            {

                BulanikMantik bm = new BulanikMantik(Convert.ToDouble(numericUpDown1.Value), Convert.ToDouble(numericUpDown2.Value), Convert.ToDouble(numericUpDown3.Value));
                bm.kurallar();
                sonuclar=bm.Hesapla();
                textBox1.Text = sonuclar[0].ToString();
                textBox2.Text = sonuclar[1].ToString();
                textBox3.Text = sonuclar[2].ToString();
            }


            catch(Exception ex)
            {
                MessageBox.Show("Hata!!"+ex.Message);
            }
            
            
        }
    }
}
