using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace oop1odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        object[] secimSirasi = new object[50]; // Maksimum 50 şehir seçilebilir varsayıyoruz
        int secimAdedi = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            /*listBox1.Items.Clear(); 

            Random rnd = new Random();
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);

            for (int i = 0; i < 20; i++)
            {
                int rastgeleSayi = rnd.Next(sayi1, sayi2 + 1);
                listBox1.Items.Add(rastgeleSayi);
            }*/
            /*listBox1.Items.Clear();

            int[] sayilar = new int[20];
            Random rnd = new Random();
            int sayi = 0;
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);

            for (int i = 0; i < 20; i++)
            {
                sayi = rnd.Next(sayi1, sayi2 + 1);
                listBox1.Items.Add(sayi);
                sayilar[i] = sayi;
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*listBox2.Items.Clear();
            listBox3.Items.Clear();

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int sayi = Convert.ToInt32(listBox1.Items[i]);

                if (sayi % 2 == 0)
                {
                    listBox3.Items.Add(sayi);
                }
                else
                {
                    listBox2.Items.Add(sayi); 
                }
            }

            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                for (int j = i + 1; j < listBox2.Items.Count; j++)
                {
                    int s1 = Convert.ToInt32(listBox2.Items[i]);
                    int s2 = Convert.ToInt32(listBox2.Items[j]);

                    if (s1 > s2)
                    {
                        listBox2.Items[i] = s2;
                        listBox2.Items[j] = s1;
                    }
                }
            }

            for (int i = 0; i < listBox3.Items.Count; i++)
            {
                for (int j = i + 1; j < listBox3.Items.Count; j++)
                {
                    int s1 = Convert.ToInt32(listBox3.Items[i]);
                    int s2 = Convert.ToInt32(listBox3.Items[j]);

                    if (s1 < s2)
                    {
                        listBox3.Items[i] = s2;
                        listBox3.Items[j] = s1;
                    }
                }
            }
        }
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            int tekAdet = 0;
            int ciftAdet = 0;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int deger = Convert.ToInt32(listBox1.Items[i]);

                if (deger % 2 == 0)
                {
                    ciftAdet++;
                }
                else
                {
                    tekAdet++;
                }
            }

            int[] tekSayilar = new int[tekAdet];
            int[] ciftSayilar = new int[ciftAdet];

            int tekIndex = 0;
            int ciftIndex = 0;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int deger = Convert.ToInt32(listBox1.Items[i]);

                if (deger % 2 == 0)
                {
                    ciftSayilar[ciftIndex] = deger;
                    ciftIndex++;
                }
                else
                {
                    tekSayilar[tekIndex] = deger;
                    tekIndex++;
                }
            }

            Array.Sort(tekSayilar);
            for (int i = 0; i < tekSayilar.Length; i++)
            {
                listBox2.Items.Add(tekSayilar[i]);
            }

            Array.Sort(ciftSayilar);
            Array.Reverse(ciftSayilar);
            for (int i = 0; i < ciftSayilar.Length; i++)
            {
                listBox3.Items.Add(ciftSayilar[i]);
            }

        }*/
            listBox2.Items.Clear();
            listBox2.Items.AddRange(new object[] {
        "istanbul", "ankara", "malatya", "KOCAELİ", "bursa", "edirne",
        "kahramanmaraş", "arabistan", "akçadağ", "balıkesir", "tokat", "KARAMAN"
    });

            /*int maxUzunluk = 0;
            int enUzunSehirIndeksi = -1; 

            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                string siradakiSehir = listBox2.Items[i].ToString();

                int kelimeUzunlugu = 0;

                foreach (char harf in siradakiSehir)
                {
                    kelimeUzunlugu++;
                }

                if (kelimeUzunlugu > maxUzunluk)
                {
                    maxUzunluk = kelimeUzunlugu;
                    enUzunSehirIndeksi = i;
                }
            }

            if (enUzunSehirIndeksi != -1) 
            {
                listBox2.SelectedIndex = enUzunSehirIndeksi;
            }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Döngüyü 0'dan değil, EN SONDAN başlatıp geriye (0'a) doğru saydırıyoruz:
            for (int i = listBox2.SelectedItems.Count - 1; i >= 0; i--)
            {
                // En sondaki seçili elemanı al
                var eleman = listBox2.SelectedItems[i];

                listBox3.Items.Add(eleman);      // 3. listeye ekle
                listBox2.Items.Remove(eleman);   // Eski listeden sil
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.SelectedItems.Count; i++)
            {
                object eleman = listBox2.SelectedItems[i];

                // Bu eleman dizimizde zaten var mı diye baştan sona kontrol et
                bool varMi = false;
                for (int j = 0; j < secimAdedi; j++)
                {
                    if (secimSirasi[j] == eleman)
                    {
                        varMi = true;
                        break; // Varsa döngüyü boşuna yorma, çık
                    }
                }

                // Eğer dizimizde yoksa, dizinin en son boş sırasına ekle
                if (varMi == false)
                {
                    secimSirasi[secimAdedi] = eleman;
                    secimAdedi++; // Dizideki eleman sayısını 1 artır
                }
            }

            // --- BÖLÜM 2: SEÇİMİ KALDIRILANLARI DİZİDEN ÇIKARMA VE KAYDIRMA ---
            for (int i = 0; i < secimAdedi; i++)
            {
                object dizidekiEleman = secimSirasi[i];

                // Bizim dizimizdeki bu eleman, ListBox'ta hala seçili duruyor mu?
                bool halaSeciliMi = false;
                for (int j = 0; j < listBox2.SelectedItems.Count; j++)
                {
                    if (listBox2.SelectedItems[j] == dizidekiEleman)
                    {
                        halaSeciliMi = true;
                        break;
                    }
                }

                // Eğer artık seçili değilse (yani mavi rengi kaldırdıysan)
                if (halaSeciliMi == false)
                {
                    // Silinen elemanın boşluğunu kapatmak için arkadakileri bir adım öne çekiyoruz
                    for (int k = i; k < secimAdedi - 1; k++)
                    {
                        secimSirasi[k] = secimSirasi[k + 1];
                    }

                    secimAdedi--; // Dizideki eleman sayısını 1 azalttık
                    i--; // Kaydırma yaptığımız için aynı sırayı tekrar kontrol etmeliyiz
                }
            }
        }
    }
     
}
