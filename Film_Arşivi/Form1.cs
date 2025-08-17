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

namespace Film_Arşivi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ABDULLAH;Initial Catalog=DbFilm;Integrated Security=True;Encrypt=False;");

        void Filmler()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_FILMLER", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Filmler();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Eğer basılan tuş ESC ise, tam ekrandan çıkar.
            if (e.KeyCode == Keys.Escape)
            {
                // Formu normal boyutuna geri döndürür.
                this.WindowState = FormWindowState.Normal;

                // Formun başlık çubuğunu ve kenarlıklarını geri getirir.
                this.FormBorderStyle = FormBorderStyle.Sizable;

                // WebView2'nin dock ayarını temizler veya eski haline döndürür.
                webView21.Dock = DockStyle.None;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO TBL_FILMLER(AD,KATEGORI,LINK) VALUES (@P1,@P2,@P3)", conn);
            cmd.Parameters.AddWithValue("@P1", txtFilmAd.Text);
            cmd.Parameters.AddWithValue("@P2", txtFilmKategori.Text);
            cmd.Parameters.AddWithValue("@P3", txtFilmLink.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Film Kaydı Başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Filmler();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            webView21.Source = new Uri(link);

        }

        private void btnHakkımızda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abdullah Haktan Bigisayar Mühendisi | Full stack .Net Developer | Backend Developer ", "Hakkımda Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRenkDegistir_Click(object sender, EventArgs e)
        {
            List<Color> renkList = new List<Color>
           {
               Color.Red,
               Color.Blue,
               Color.Green,
               Color.Yellow,
               Color.Purple,
               Color.Orange
           };

            Random rndm = new Random();
            int rastgele = rndm.Next(0, renkList.Count);
            Color secilenRenk = renkList[rastgele];

            this.BackColor = secilenRenk;
        }


        private void btnTamEkran_Click(object sender, EventArgs e)
        {

            // Diğer tüm grupları ve panelleri görünmez yap.
            groupBox1.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false; // Veya butonun kendisi, diğerlerini de gizler.

            // Formun başlık çubuğunu ve kenarlıklarını gizle.
            this.FormBorderStyle = FormBorderStyle.None;

            // Formu tam ekran yap.
            this.WindowState = FormWindowState.Maximized;

            // WebView2 kontrolünü tüm pencereye yay.
            groupBox2.Dock = DockStyle.Fill;
            webView21.Dock = DockStyle.Fill;

        }
    }
}
