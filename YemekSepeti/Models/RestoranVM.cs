using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YemekSepeti.Models
{
    public class RestoranVM
    {
        public YemekSepeti.Models.Uye uye { get; set; }
        public YemekSepeti.Models.Restoran restoran { get; set; }
        public List<YemekSepeti.Models.Urun> urunlerListesi { get; set; }

        public List<YemekSepeti.Models.Yorum> yorumlar { get; set; }

    }
}