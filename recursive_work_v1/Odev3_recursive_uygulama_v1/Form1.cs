using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev3_recursive_uygulama_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rnd = new Random();
            int boyut = Convert.ToInt32(textBox1.Text);
            int[] dizi = { 10, 20, 30 };
            int i = -1;
            double toplam = recursiveToplamHesapla(dizi, i);
            listBox1.Items.Add("Recursive Toplam: " + toplam + "\n");
            double ortalama = toplam / dizi.Length;
            listBox1.Items.Add("Recursive Ortalama: " + ortalama + "\n");
            double varyans = recursiveSapmaHesapla(ortalama, dizi, i);
            varyans = varyans / (dizi.Length - 1);
            listBox1.Items.Add("Recursive Varyans: " + varyans + "\n");
            double sapma = Math.Sqrt(varyans);
            listBox1.Items.Add("Recursive Standart Sapma: " + sapma + "\n");
        }

        private double recursiveSapmaHesapla(double ortalama, int[] dizi, int i)
        {
            if (i + 1 < dizi.Length)
            {
                i++;
                double fark = dizi[i] - ortalama;
                double sonuc = fark * fark;
                return sonuc + recursiveSapmaHesapla(ortalama, dizi, i);
            }
            else
            {
                return 0;
            }
        }

        private double recursiveToplamHesapla(int[] dizi, int i)
        {
            if (i + 1 < dizi.Length)
            {
                i++;
                return dizi[i] + recursiveToplamHesapla(dizi, i);
            }
            else
            {
                return 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
