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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("server=.; database=KuzeyYeli; uid=sa; pwd=123");



        SqlCommand cmd = new SqlCommand();
        public Form1()
        {
            con.Open();
            InitializeComponent();
            DgvUrunler.AutoGenerateColumns = false; // otomatik sütün oluşturmayı durdurur
            KategorileriGetir();
            UrunleriGetir();
        }



        private void KategorileriGetir()
        {
            string sorgu = "SELECT Id,KategoriAd FROM Kategoriler ORDER BY Id ";
            cmd.CommandText = sorgu;
            cmd.Connection = con;
            var dr = cmd.ExecuteReader();
            List<Kategori> lst = new List<Kategori>();
            while (dr.Read())
            {
                int id = (int)dr["Id"];
                string ad = (string)dr["KategoriAd"];
                lst.Add(new Kategori(id, ad));
            }

            dr.Close();
            LstKategori.DataSource = lst;
        }
        private void UrunleriGetir()
        {
            if (LstKategori.SelectedIndex > -1)
            {
                Kategori kategori1 = (Kategori)LstKategori.SelectedItem;
                cmd = new SqlCommand
                (
                   "SELECT Id, KategoriId, UrunAd, BirimFiyat, Resim, StokAdet  FROM Urunler" +
                   " WHERE KategoriId = @p1", con
                );
                cmd.Parameters.AddWithValue("@p1", kategori1.Id);
                var dr = cmd.ExecuteReader();
                var Urunler = new List<Urun>();
                while (dr.Read())
                {
                    int Id = (int)dr["Id"];
                    int KategoriId = (int)dr["KategoriId"];
                    string UrunAd = (string)dr["UrunAd"];
                    decimal BirimFiyat = (decimal)dr["BirimFiyat"];
                    //byte[] Resim = (byte[])dr["Resim"];
                    byte[] Resim = dr["Resim"] is DBNull ? null : (byte[])dr["Resim"];
                    int StokAdet = (int)dr["StokAdet"];
                    Urunler.Add(new Urun(Id, KategoriId, UrunAd, BirimFiyat, Resim, StokAdet));

                }
                dr.Close();
                DgvUrunler.DataSource = Urunler;

            }
        }

        private void LstKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            UrunleriGetir();
        }

        private void BtnUrunEkle_Click(object sender, EventArgs e)
        {
            UrunDuzenle urunDuzenle = new UrunDuzenle();
            urunDuzenle.ShowDialog();
            UrunleriGetir();
        }

        private void BtnKategoriEkle_Click(object sender, EventArgs e)
        {
            KategoriDuzenle kategoriDuzenle = new KategoriDuzenle();
            kategoriDuzenle.ShowDialog();
            KategorileriGetir();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {

            Kategori seciliKategori = (Kategori)LstKategori.SelectedItem;
            KategoriDuzenle kategoriDuzenle = new KategoriDuzenle(seciliKategori);
            kategoriDuzenle.ShowDialog();
            KategorileriGetir();
        }

        private void BtnDuzenleUrun_Click(object sender, EventArgs e)
        {
            if (DgvUrunler.SelectedRows.Count != 0)
            {
                Urun seciliUrun = (Urun)DgvUrunler.SelectedRows[0].DataBoundItem;
                UrunDuzenle urunDuzenle = new UrunDuzenle(seciliUrun);
                urunDuzenle.ShowDialog();
                UrunleriGetir();
            }
        }

        private void BtnKategoriSil_Click(object sender, EventArgs e)
        {
            if (LstKategori.SelectedIndex > -1)
            {

            Kategori secilikategori = (Kategori)LstKategori.SelectedItem;

                var cmd = new SqlCommand("DELETE FROM Kategoriler WHERE Id = @id", con);
                cmd.Parameters.AddWithValue("@id", secilikategori.Id);
                cmd.ExecuteNonQuery();
            }
            KategorileriGetir();
        }

        private void BtnUrunSil_Click(object sender, EventArgs e)
        {
            if (DgvUrunler.SelectedRows.Count != 0)
            {
                Urun seciliUrun = (Urun)DgvUrunler.SelectedRows[0].DataBoundItem;
                var cmd = new SqlCommand("DELETE FROM Urunler WHERE Id = @id", con);
                cmd.Parameters.AddWithValue("@id", seciliUrun.Id);
                cmd.ExecuteNonQuery();
                UrunleriGetir();
            }
            else
            {
                Console.WriteLine("Silmek için önce bir ürün seçmelisiniz");
            }
        }

        private void LstKategori_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                BtnKategoriSil.PerformClick();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
