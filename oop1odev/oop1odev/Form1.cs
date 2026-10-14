using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop1odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] secimDizisi = new string[20];
        int sayac = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            string[] kopyaDizi = new string[sayac];
            for (int i = 0; i < sayac; i++)
            {
                kopyaDizi[i] = secimDizisi[i];
            }

            int tasinacakAdet = sayac;

            listBox1.ClearSelected();

            sayac = 0;

            for (int i = 0; i < tasinacakAdet; i++)
            {
                string tasinacakSehir = kopyaDizi[i];

                listBox2.Items.Add(tasinacakSehir);     
                listBox1.Items.Remove(tasinacakSehir);  

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                string ekrandakiSecili = listBox1.SelectedItems[i].ToString();
                bool dizideVarMi = false;

                for (int j = 0; j < sayac; j++)
                {
                    if (secimDizisi[j] == ekrandakiSecili)
                    {
                        dizideVarMi = true;
                        break;
                    }
                }

                if (dizideVarMi == false) 
                {
                    secimDizisi[sayac] = ekrandakiSecili;
                    sayac++;
                }
            }

            for (int i = 0; i < sayac; i++)
            {
                string dizidekiSehir = secimDizisi[i];
                bool halaMaviMi = false;

                for (int j = 0; j < listBox1.SelectedItems.Count; j++)
                {
                    if (listBox1.SelectedItems[j].ToString() == dizidekiSehir)
                    {
                        halaMaviMi = true;
                        break;
                    }
                }

                if (halaMaviMi == false) 
                {
                    for (int k = i; k < sayac - 1; k++)
                    {
                        secimDizisi[k] = secimDizisi[k + 1];
                    }

                    secimDizisi[sayac - 1] = null; 
                    sayac--;
                    i--;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(new object[] {
                "istanbul", "ankara", "izmir", "rize", "bursa", "muş",
                "kahramanmaraş", "antalya", "samsun", "kayseri", "afyon", "tekirdağ"
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayac = 0;
            for (int i = 0; i < secimDizisi.Length; i++)
            {
                secimDizisi[i] = null;
            }

            listBox1.Items.Clear();
            listBox2.Items.Clear();

            listBox1.Items.AddRange(new object[] {
        "istanbul", "ankara", "izmir", "rize", "bursa", "muş",
        "kahramanmaraş", "antalya", "samsun", "kayseri", "afyon", "tekirdağ"
    });
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
