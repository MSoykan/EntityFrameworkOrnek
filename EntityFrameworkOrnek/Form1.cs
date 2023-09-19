using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.ObjectModel;


namespace EntityFrameworkOrnek {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        DBSinavOgrenciEntities db = new DBSinavOgrenciEntities();

        private void BtnDersListesi_Click(object sender, EventArgs e) {
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-27F5QUI\SQLEXPRESS;Initial Catalog=DBSinavOgrenci;Integrated Security=True");
            SqlCommand komut = new SqlCommand("Select * from dersler", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnListele_Click(object sender, EventArgs e) {
            DBSinavOgrenciEntities db = new DBSinavOgrenciEntities();
            dataGridView1.DataSource = db.TBLOGRENCI.ToList();
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;

        }
        private void BtnNotListesi_Click(object sender, EventArgs e) {

            var query = from item in db.TBLNOTLAR
                        select new { item.NOTID, item.OGR, item.DERS, item.SINAV1, item.SINAV2,
                            item.SINAV3, item.ORTALAMA, item.DURUM };

            dataGridView1.DataSource = query.ToList();

            //dataGridView1.DataSource = db.TBLNOTLAR.ToList();


        }
        private void button1_Click(object sender, EventArgs e) {
            TBLOGRENCI t = new TBLOGRENCI();
            t.AD = txtAd.Text;
            t.SOYAD = txtSoyad.Text;
            db.TBLOGRENCI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Listeye Eklenmiştir");
            
        }

        private void btnSil_Click(object sender, EventArgs e) {
            int id = Convert.ToInt32(TxtOgrenciID.Text);
            var x = db.TBLOGRENCI.Find(id);
            db.TBLOGRENCI.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Öğrenci sistemden silindi");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e) {
            int id = Convert.ToInt32(TxtOgrenciID.Text);
            var x = db.TBLOGRENCI.Find(id);
            x.AD= txtAd.Text;
            x.SOYAD = txtSoyad.Text;
            x.FOTOGRAF = txtFotograf.Text;
            db.SaveChanges();
            MessageBox.Show("Öğrenci Bilgileri Başarıyla Güncellendi");
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void groupBox2_Enter(object sender, EventArgs e) {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

    }
}
