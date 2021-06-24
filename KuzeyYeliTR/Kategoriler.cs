using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeliTR
{
   public  class Kategori
    {
        public int Id { get; set; }
        public string KategoriAd { get; set; }

        public Kategori()
        {
        }
        public Kategori(int id, string kategoriad)
        {
            Id = id;
            KategoriAd = kategoriad;
        }
        public override string ToString()
        {
            return Id + " " + KategoriAd;
        }


    }
}
