using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuzeyYeliTR
{
    public partial class UrunDuzenle : Form
    {
        SqlConnection con = new SqlConnection("server=.; database=KuzeyYeli; uid=sa; pwd=123");
        public Urun Urun { get; set; }

        public UrunDuzenle()
        {
            con.Open();
            InitializeComponent();
        }
        public UrunDuzenle(Urun urun)
        {
            con.Open();
            InitializeComponent();
            Urun = urun;

            txtIdUrun.Text = Urun.Id.ToString();
            txtAdUrun.Text = Urun.UrunAd;
            txtFiyatUrun.Text = Urun.BirimFiyat.ToString();
            txtStokAdetUrun.Text = Urun.StokAdet.ToString();
            pboResim.Image = urun.ResmiGetir();


        }

        private void BtnTamam_Click(object sender, EventArgs e)
        {
            if (txtAdUrun.Text.Length <= 0)
            {
                MessageBox.Show("Önce bir Ürün Adı giriniz.");
                return;
            }
            string ad = txtAdUrun.Text.Trim();
            decimal fiyat = Convert.ToDecimal(txtFiyatUrun.Text.Trim());
            int stok =Convert.ToInt32(txtStokAdetUrun.Text.Trim());
            int kategoriId = Convert.ToInt32(cmbKategoriUrun.Text);

            if (txtIdUrun.Text.Length <= 0)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Urunler(UrunAd, BirimFiyat, StokAdet, KategoriId,Resim) VALUES(@p1,@p2,@p3,@p4,@p5)", con);
                cmd.Parameters.AddWithValue("@p1", ad);
                cmd.Parameters.AddWithValue("@p2", fiyat);
                cmd.Parameters.AddWithValue("@p3", stok);
                cmd.Parameters.AddWithValue("@p4", kategoriId);
                cmd.Parameters.AddWithValue("@p5", ImageToByteArray(pboResim.Image));
                cmd.ExecuteNonQuery();
                txtAdUrun.Clear();
                txtFiyatUrun.Clear();
                txtStokAdetUrun.Clear();
                Close();

            }
            else
            {

                string yeniAd = txtAdUrun.Text.Trim();
                decimal yeniFiyat = Convert.ToDecimal(txtFiyatUrun.Text.Trim());
                int yeniStok = Convert.ToInt32(txtStokAdetUrun.Text.Trim());
                int kategoriid = Convert.ToInt32(cmbKategoriUrun.Text);

                var cmd = new SqlCommand("UPDATE Urunler SET UrunAd = @p1,BirimFiyat = @p2, StokAdet = @p3, KategoriId = @p4 ,Resim = @p6 WHERE Id = @p5", con);
                cmd.Parameters.AddWithValue("@p1", yeniAd);
                cmd.Parameters.AddWithValue("@p2", yeniFiyat);
                cmd.Parameters.AddWithValue("@p3", yeniStok);
                cmd.Parameters.AddWithValue("@p4", kategoriid);
                cmd.Parameters.AddWithValue("@p5", Urun.Id);
                cmd.Parameters.AddWithValue("@p6", ImageToByteArray(pboResim.Image));
                cmd.ExecuteNonQuery();
                txtAdUrun.Clear();
                txtFiyatUrun.Clear();
                txtStokAdetUrun.Clear();
                Close();
            }
        }

        //https://stackoverflow.com/questions/3801275/how-to-convert-image-to-byte-array
        public byte[] ImageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        private void UrunDuzenle_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kuzeyYeliDataSet1.Kategoriler' table. You can move, or remove it, as needed.
            this.kategorilerTableAdapter.Fill(this.kuzeyYeliDataSet1.Kategoriler);

        }
        private void BtnIptal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnResimSec_Click(object sender, EventArgs e)
        {
            DialogResult dr = ofdResim.ShowDialog();
            if (dr == DialogResult.OK)
            {
                pboResim.Image = Image.FromFile(ofdResim.FileName);
            }

            // Image Files(*.BMP;*.JPG;*.GIF;*.PNG;)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*
            // https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.filedialog.filter?view=net-5.0

        }
    }
}
