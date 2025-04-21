using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework
{
    public partial class frmEntity: Form
    {
        KodlamaDünyasıDBEntities db = new KodlamaDünyasıDBEntities();
        public frmEntity()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmEntity_Load(object sender, EventArgs e)
        {
            Listele();

        }

        private void Listele()
        {
            dataGridView1.DataSource = db.Kullanıcılar.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var entity = new Kullanıcılar
            {
                AdSoyad = txtAdiSoyadi.Text,
                Eposta = txtEposta.Text,
                Şifre = txtSifre.Text,
                Rol = txtRol.Text,
                OluşturulmaTarihi = dateTimePicker1.Value,
                 
            };
            db.Kullanıcılar.Add(entity);
            db.SaveChanges();
            Temizle();
            Listele();
        }
        void Temizle()
        {
            txtId.Text = string.Empty;
            txtAdiSoyadi.Text = string.Empty;
            txtEposta.Text = string.Empty;
            txtRol.Text = string.Empty;
            txtSifre.Text = string.Empty;
            dateTimePicker1.Value= DateTime.Now;
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var model = db.Kullanıcılar.FirstOrDefault(x=>x.KullanıcıID==id);
            model.AdSoyad = txtAdiSoyadi.Text;
            model.Eposta = txtEposta.Text;
            model.Şifre = txtEposta.Text;
            model.Rol = txtRol.Text;
            model.OluşturulmaTarihi = dateTimePicker1.Value;
            db.SaveChanges();
            Temizle();
            Listele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAdiSoyadi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtEposta.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtRol.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtSifre.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells[(0)].Value.ToString());
            var model = db.Kullanıcılar.FirstOrDefault(x => x.KullanıcıID == id);
            db.Kullanıcılar.Remove(model);
            db.SaveChanges();
            Temizle();
            Listele();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Kullanıcılar.Where(x => x.Eposta.Contains(txtEpostaAra.Text)).ToList();
        }
    }
}
