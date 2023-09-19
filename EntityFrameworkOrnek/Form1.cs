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


namespace EntityFrameworkOrnek {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void BtnDersListesi_Click(object sender, EventArgs e) {
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-27F5QUI\SQLEXPRESS;Initial Catalog=DBSinavOgrenci;Integrated Security=True");
            SqlCommand komut = new SqlCommand("Select * from dersler",baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnListele_Click(object sender, EventArgs e) {
            DBSinavOgrenciEntities db = new DBSinavOgrenciEntities();
            dataGridView1.DataSource = db.TBLOGRENCI.ToList();
        }
        private void button1_Click(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {

        }

        private void button3_Click(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void groupBox2_Enter(object sender, EventArgs e) {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
