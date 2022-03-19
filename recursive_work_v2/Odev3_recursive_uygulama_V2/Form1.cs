using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev3_recursive_uygulama_V2
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
            int[] dizi = { 5, 6, 8 };
            int i = -1;
            int j = -1;
            double ortalama = 0.0;
            double varyans = recursiveSapmaHesapla(ortalama, dizi, i,j);
            varyans = varyans / (dizi.Length - 1);
            double sapma = Math.Sqrt(varyans);
            listBox1.Items.Add("Recursive Ortalama: " + ortalama + "\n");
            listBox1.Items.Add("Recursive Varyans: " + varyans + "\n");
            listBox1.Items.Add("Recursive Standart Sapma: " + sapma + "\n");
        }

        private double recursiveSapmaHesapla(double ortalama, int[] dizi, int i,int j)
        {
            if (i < 2)
            {
                i++;
                ortalama += dizi[i] + recursiveSapmaHesapla(ortalama, dizi, i,j);
                return recursiveSapmaHesapla(ortalama, dizi, i, j);
            }
            else if (i == 2)
            {
                i++;
                ortalama = ortalama / dizi.Length;
                return recursiveSapmaHesapla(ortalama, dizi, i, j);
            }
            else if(j < 2)
            {
                j++;
                double fark = dizi[j] - ortalama;
                double sonuc = fark * fark;
                return sonuc + recursiveSapmaHesapla(ortalama, dizi, i,j);
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
