using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunYonetımı
{
    public partial class Form1 : Form
    {
        Sepet sepet = new Sepet();

        public Form1()
        {
            InitializeComponent();
            lblToplamFiyat.Text = "0.00 TL";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtUrunID.Text);
                string ad = txtUrunAdi.Text;
                double fiyat = double.Parse(txtFiyat.Text);
                int adet = (int)nudAdet.Value;

                Urun u = new Urun(id, ad, fiyat, adet);
                sepet.UrunEkle(u);
                listBoxUrunler.Items.Add(u);

                lblToplamFiyat.Text = $"{sepet.ToplamTutar():0.00} TL";
            }
            catch
            {
                MessageBox.Show("Lütfen tüm alanları doğru formatta doldurun.",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtUrunID.Clear();
            txtUrunAdi.Clear();
            txtFiyat.Clear();
            nudAdet.Value = 1;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int secilenIndex = listBoxUrunler.SelectedIndex;

            if (secilenIndex >= 0)
            {
                listBoxUrunler.Items.RemoveAt(secilenIndex);
                sepet.urunler.RemoveAt(secilenIndex);
                lblToplamFiyat.Text = $"{sepet.ToplamTutar():0.00} TL";
            }
            else
            {
                MessageBox.Show("Silmek için listeden bir ürün seçin.",
                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sepet.SepetiTemizle();
            listBoxUrunler.Items.Clear();
            lblToplamFiyat.Text = "0.00 TL";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

