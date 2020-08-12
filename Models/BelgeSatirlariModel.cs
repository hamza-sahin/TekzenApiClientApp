using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace TekzenApiClient.Models
{
    public class BelgeSatirlariModel
    {
        public int Sira;
        public int UrunId;
        public string UrunKod;
        public string UrunAdi;
        public List<String> UrunBarkodlari;
        public string UrunUreticiKod;
        public decimal SiparisAdet;
        public decimal SiparisKalanAdet;
        public bool Gecerli;
        public byte KvdYuzde;
        public decimal BirimFiyatBrut;
        public decimal BirimFiyatNet;
        public decimal BrutTutar;
        public decimal IndirimTutar;
        public decimal KdvTutar;
        public string SatirNotu;
        public string Birim;
        public decimal IndirimYuzde1;
        public decimal IndirimYuzde2;
        public decimal IndirimYuzde3;
        public decimal IndirimYuzde4;
        public decimal IndirimYuzde5;
    }
}