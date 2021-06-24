using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuzeyYeliTR
{
    public partial class KategoriDuzenle : Form
    {
        SqlConnection con = new SqlConnection("server=.; database=KuzeyYeli; uid=sa; pwd=123");
        public Kategori Kategori { get; set; }

        public KategoriDuzenle()
        {
            con.Open();
            InitializeComponent();
        }
        public KategoriDuzenle(Kategori kategori)
        {
            con.Open();
            InitializeComponent();
            Kategori = kategori;

            txtKategoriId_Kategori.Text = Kategori.Id.ToString();
            txtKategoriAd_Kategori.Text = Kategori.KategoriAd;



        }

        private void btnTamam_kategori_Click(object sender, EventArgs e)
        {
            if (txtKategoriId_Kategori.Text.Length <= 0)
            {
                if (txtKategoriAd_Kategori.Text.Length <= 0)
                {
                    MessageBox.Show("Önce bir kategori Adı giriniz.");
                    return;
                }
                else
                {

                string ad = txtKategoriAd_Kategori.Text.Trim();
                SqlCommand cmd = new SqlCommand("INSERT INTO Kategoriler(KategoriAd) VALUES(@p1)", con);
                cmd.Parameters.AddWithValue("@p1", ad);
                cmd.ExecuteNonQuery();
                txtKategoriAd_Kategori.Clear();
                txtKategoriId_Kategori.Clear();
                Close();

                }
            }
            else
            {

                string yeniAd = txtKategoriAd_Kategori.Text.Trim();
                if (yeniAd == "") return;
                var cmd = new SqlCommand("UPDATE Kategoriler SET KategoriAd = @p1 WHERE Id = @p2", con);
                cmd.Parameters.AddWithValue("@p1", yeniAd);
                cmd.Parameters.AddWithValue("@p2", Kategori.Id);
                cmd.ExecuteNonQuery();
                Close();
            }
        }

        private void btnIptal_Kategori_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
