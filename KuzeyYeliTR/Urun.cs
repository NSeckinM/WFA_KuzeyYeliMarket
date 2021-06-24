using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeliTR
{
    public class Urun
    {


        public int Id { get; set; }

        public int KategoriId { get; set; }
        public string UrunAd { get; set; }

        public decimal BirimFiyat { get; set; }

        public byte[] Resim { get; set; }

        public int StokAdet { get; set; }

        public Urun()
        {
        }

        public Urun(int id,int kategoriid, string urunad, decimal birimfiyat, byte[] resim, int stokadeti)
        {
            Id = id;
            KategoriId = kategoriid;
            UrunAd = urunad;
            BirimFiyat = birimfiyat;
            Resim = resim;
            StokAdet = stokadeti;
        }




    }
}
