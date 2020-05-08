using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YemekSepeti.Models
{
    public class Index
    {
        public YemekSepeti.Models.Uye uye { get; set; }

        public List<YemekSepeti.Models.Siparis> siparislerim { get; set; }
        public List<YemekSepeti.Models.Restoran> yenirestoranlar { get; set; }

        public List<YemekSepeti.Models.Adres> adreslerim { get; set; }

    }
}