using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KütüphaneTakipPro.classlar.Parametreler
{
    public class Prm
    {

        #region Static Parametreler

        public static sbyte Hata;
        public static string BilgiEkraniContent;

        #endregion

        #region Ekle Parametreleri
        private string barkod;
        private string kitapAdi;
        private string yazarAdiSoyadi;
        private string yayinEvi;
        private string baskiYeri;
        private string baskiiTarihi;
        private string baskiSayisi;
        private string kitapTuru;
        private string sayfaSayisi;
        private string dili;
        private string konusu;
        private string teminTuru;
        private string teminTarihi;
        private string resim;

        private int ekleyenID;
        private int yayinEviID;
        private int yazarAdiID;

        private bool emanetDurum;

        public string Barkod { get => barkod; set => barkod = value; }
        public string KitapAdi { get => kitapAdi; set => kitapAdi = value; }
        public string YazarAdiSoyadi { get => yazarAdiSoyadi; set => yazarAdiSoyadi = value; }
        public string YayinEvi { get => yayinEvi; set => yayinEvi = value; }
        public string BaskiYeri { get => baskiYeri; set => baskiYeri = value; }
        public string BaskiiTarihi { get => baskiiTarihi; set => baskiiTarihi = value; }
        public string BaskiSayisi { get => baskiSayisi; set => baskiSayisi = value; }
        public string KitapTuru { get => kitapTuru; set => kitapTuru = value; }
        public string SayfaSayisi { get => sayfaSayisi; set => sayfaSayisi = value; }
        public string Dili { get => dili; set => dili = value; }
        public string Konusu { get => konusu; set => konusu = value; }
        public string TeminTuru { get => teminTuru; set => teminTuru = value; }
        public string TeminTarihi { get => teminTarihi; set => teminTarihi = value; }
        public string Resim { get => resim; set => resim = value; }
        public int EkleyenID { get => ekleyenID; set => ekleyenID = value; }
        public int YayinEviID { get => yayinEviID; set => yayinEviID = value; }
        public int YazarAdiID { get => yazarAdiID; set => yazarAdiID = value; }
        public bool EmanetDurum { get => emanetDurum; set => emanetDurum = value; }

        #endregion
    }
}
