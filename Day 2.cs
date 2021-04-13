// Game Academy Day #2

using System;

namespace Unity_gun_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Araba & Yaris Arabasi

            Console.WriteLine("******** Araba & Yaris Arabasi **********");
            Araba araba1 = new Araba();
            araba1.UretimYili = 2020;
            araba1.Renk = "Beyaz";
            araba1.EkranaYazdir();

            Console.WriteLine("Renk :{0}, Üretim Yili :{1}", araba1.Renk, araba1.UretimYili);
            Console.WriteLine("................");

            string selam;
            selam = araba1.Selamlama();
            Console.WriteLine(selam);
            Console.WriteLine("................");

            Araba araba2 = new Araba();
            araba2.Renk = "Yesil";
            Console.WriteLine("Araba2'nin rengi : {0}", araba2.Renk);

            Araba araba3 = new Araba();
            araba3.Renk = "Mavi";
            Console.WriteLine("Araba3'ün rengi : {0}", araba3.Renk);
            Console.WriteLine("................");

            Araba.MesajGoster1();
            Console.WriteLine("................");

            YarisArabasi yarisArabasi1 = new YarisArabasi();
            Araba arabaX1 = new Araba();

            yarisArabasi1.Renk = "Siyah";
            yarisArabasi1.MaksimumHiz = 400;
            yarisArabasi1.LastikTipi = "Sport";
            yarisArabasi1.UretimYili = 2020;
            yarisArabasi1.Plaka = "34 TN 1453";
            yarisArabasi1.MesajGoster2();
            Console.WriteLine("................");
            string selam2 = yarisArabasi1.Selamlama();
            Console.WriteLine(selam2);
            Console.WriteLine("................");
            yarisArabasi1.EkranaYazdir();
            Console.WriteLine("................");

            arabaX1.UretimYili = 2021;
            arabaX1.Renk = "Mavi";
            arabaX1.Plaka = "06 KM 1923";
            string selam3 = arabaX1.Selamlama();
            arabaX1.Selamlama();
            Console.WriteLine(selam3);
            Console.WriteLine("................");
            arabaX1.EkranaYazdir();
            Console.WriteLine();
            Console.WriteLine("******** Hesap Makinesi **********");

            #endregion

            #region Hesap Makinesi
            HesapMakinesi hesapMakinesi = new HesapMakinesi();
            int toplama;
            toplama = hesapMakinesi.SayiToplama();
            Console.WriteLine("Toplama islemi sonucu : {0}", toplama);

            int islemSonucu = hesapMakinesi.KareAlma(5);
            Console.WriteLine("Kare islemi sonucu : {0}", islemSonucu);

            int islemSonucu2 = hesapMakinesi.Carpma(5, 6);
            Console.WriteLine("Carpma islemi sonucu : {0}", islemSonucu2);
            Console.WriteLine();
            Console.WriteLine("******** Oyuncu **********");

            #endregion

            #region Oyuncu

            Oyuncu oyuncu1 = new Oyuncu(25, 35);
            Console.WriteLine("Oyuncu1 X Konumu: {0}", oyuncu1.oyuncuKonumX);
            Console.WriteLine("Oyuncu1 Y Konumu: {0}", oyuncu1.oyuncuKonumY);

            Oyuncu oyuncu2 = new Oyuncu("Kirmizi");
            Console.WriteLine("Oyuncu2 Rengi : {0}", oyuncu2.renk);
            Console.WriteLine();
            Console.WriteLine("******** Islem Yap **********");

            #endregion

            #region Islem Yap

            IslemYap islem1 = new IslemYap(); // Sinif her new'lendiginde otomatik constructor metod calisir
            Console.WriteLine("................");

            int dortIslem = islem1.IslemiYap(3, 4, "%");
            //Console.WriteLine(dortIslem);
            Console.WriteLine("................");

            IslemYap islemYap = new IslemYap();
            Console.WriteLine("................");

            int sonucumuz = islemYap.IslemiYap(5, 2, "+");
            Console.WriteLine("Toplama Islemi Sonucu : {0}", sonucumuz);
            Console.WriteLine("................");

            IslemYap islemYap2 = new IslemYap();
            islemYap2.Islem2();
            Console.WriteLine();
            Console.WriteLine("******** Futbolcu **********");

            #endregion

            #region Futbolcu
            Futbolcu futbolcu1 = new Futbolcu();
            futbolcu1.HucumYap();
            Console.WriteLine("................");
            Futbolcu futbolcu2 = new Futbolcu();
            futbolcu2.HucumYap();
            Console.WriteLine("................");
            Futbolcu futbolcu3 = new Futbolcu();
            futbolcu3.HucumYap();
            Console.WriteLine("................");
            Futbolcu futbolcu4 = new Futbolcu();
            futbolcu4.HucumYap();
            Console.WriteLine("................");
            Futbolcu futbolcu5 = new Futbolcu();
            futbolcu5.HucumYap();
            Console.WriteLine();
            Console.WriteLine("******** Karakter **********");

            #endregion

            #region Karakter
            Karakter karakter1 = new Karakter();
            Savasci savasci1 = new Savasci();
            Okcu okcu1 = new Okcu();
            Sihirbaz sihirbaz1 = new Sihirbaz();

            Console.WriteLine();

            Console.WriteLine("Karakter1 Saglik : {0}", karakter1.saglik);
            Console.WriteLine("...................................................");

            Console.WriteLine("savasci1 Atak Gücü : {0}", savasci1.AtakGucu);
            Console.WriteLine("...................................................");

            sihirbaz1.SihirbazEkran();
            Console.WriteLine("...................................................");

            sihirbaz1.SihirGucuArttir(50);
            Console.WriteLine("...................................................");

            Okcu.OkcununGunlugu();
            Console.WriteLine("...................................................");

            //savasci1 yukarida new'lendigi icin burada gerek yok
            savasci1.SavasciEkran();
            Console.WriteLine("...................................................");

            Savasci savasci2 = new Savasci();
            savasci2.SavasciEkran();
            Console.WriteLine("...................................................");

            Savasci savasci3 = new Savasci();
            savasci3.SavasciEkran();
            Console.WriteLine("...................................................");


            #endregion

            Console.ReadKey();
        }
    }

    /* Erisim Belirleyicileri
            *
            * 1- Public : Heryerden veya herkes tarafindan erisilebilir. 
            * 2- Private : Sadece tanimlandiklari sinif ya da {} icerisinde gecerlidir ve baska yerlerden erisilemez.
            * 3- Protected : Sadece tanimlandiklari sinif icerisinden ve bu sinifi miras olarak alan siniflardan erisilebilir.
            *
            */

    /*Dönüs Degerleri
     *
     * Geri dönüs degeri, bizim o geris dönüs degerini kodumuzda sonuc olarak döndürmektir
     *
     * 1- Void : geri bir deger döndürmeyen fonksiyonlar(metodlar) icin kullanilir.
     * 2- int,string,double,.... : adindan da anlasildigi gibi basindaki dönüs tipine göre deger döndüren fonksiyonlardir.
     *
     */

    /* Üye Fonksiyon ve Yapici Fonksiyon(Constructor)
     *
     * Kurucu fonksiyon:
     * Nesne olusturulurken calistirilir,
     * Ilk deger atamasi yapmak icin kullanilir
     *
     *
     * Üye fonksiyon:
     * Biz ne zaman cagirirsak o zaman cagrilir.
     *
     */

    /* Static Method (Statik Fonksiyon)
     *
     * Cok sık kullanilan fonksiyonleri statik ilan etmektir.
     * Statik fonksiyonun en güzel özelligi,statik fonksiyon kullanilirken ait oldugu siniftan bir nesne türetilmesine gerek kalmaz.
     * Yani new'lenmeye gerek duymaz.
     * Statik fonksiyonlar bellekten yer tasarrufu etmemizi saglar
     *
    */

    /* Statik Degisken
     *
     * Bir siniftan üretilen tüm nesneler tarafindan ortak olarak kullaniliyor
     * Hafizada bu degiskenin sadece bir adet kopyasi var.
     *
    */

    public class Araba
    {
        public int UretimYili;
        public string Renk;
        public string Plaka;

        public void EkranaYazdir()
        {
            Console.WriteLine("Arabam yenidir");
        }

        public string Selamlama()
        {
            return "Merhaba";
        }

        public static void MesajGoster1()
        {
            Console.WriteLine("Arabayi park ettim");
        }
    }

    public class YarisArabasi : Araba
    {
        public int MaksimumHiz;
        public string LastikTipi;

        public void MesajGoster2()
        {
            Console.WriteLine("Yaris arabasi kazanacak");
        }
    }

    public class HesapMakinesi
    {
        public int SayiToplama()
        {
            int x = 2 + 3;
            return x;
        }

        public int KareAlma(int x1)
        {
            return (x1 * x1);
        }

        public int Carpma(int x1, int x2)
        {
            return (x1 * x2);
        }

        public int Toplama()
        {
            Console.WriteLine("Merhaba");
            return 1;
        }
    }

    public class Oyuncu
    {
        public int oyuncuKonumX;
        public int oyuncuKonumY;
        public string renk;


        // Kurucu Fonksiyon(Constructor)
        /*
         * Sinifin ismi ve imzasi ile ayni olmalidir.
         * Geri dönüs degeri olmaz
         *
         */

        public Oyuncu() // default, girdi parametresi almayan
        {
            oyuncuKonumX = 0;
            oyuncuKonumY = 0;
        }

        public Oyuncu(int x1) // 1 adet tamsayi cinsinden girdi parametresi alan
        {
            oyuncuKonumX = x1;
            oyuncuKonumY = 0;
        }

        public Oyuncu(int x1, int y1)
        {
            oyuncuKonumX = x1; // x1 adli degisken oyuncunun bir önceki oyunundan geliyor
            oyuncuKonumY = y1; // y1 adli degisken oyuncunun bir önceki oyunundan geliyor
        }

        public Oyuncu(string s)
        {
            renk = s;
        }
    }

    public class IslemYap
    {
        public IslemYap() //Parametresiz Construcktor Metod
        {
            Console.WriteLine("Parametresiz Constructor calisti");
        }

        public IslemYap(int x1, int x2, string s) //Parametreli Constructor Metod:
        {
            int sonuc;
            switch (s)
            {
                case "+":
                    sonuc = (x1 + x2);
                    break;
                case "-":
                    sonuc = (x1 - x2);
                    break;
                case "*":
                    sonuc = (x1 * x2);
                    break;
                case "/":
                    sonuc = (x1 / x2);
                    break;
                default:
                    Console.WriteLine("Parametreli Constructor calisti : 4 Islemi bulamadim");
                    sonuc = 0;
                    break;
            }

        }

        public int IslemiYap(int x1, int x2, string s) //Parametreli Metod
        {
            int sonuc = 999; // local variable --> yerel degisken --> { } : function scope - kapsam


            switch (s)
            {
                case "+":
                    sonuc = (x1 + x2);
                    break;
                case "-":
                    sonuc = (x1 - x2);
                    break;
                case "*":
                    sonuc = (x1 * x2);
                    break;
                case "/":
                    sonuc = (x1 / x2);
                    break;
                default:
                    Console.WriteLine("Parametreli Metod(Fonksiyon) : Sonucu bulamadim");
                    break;
            }
            return sonuc;
        }

        public void Islem2() //Parametresiz Metod
        {
            Console.WriteLine("Parametresiz metod calisti");
        }
    }

    public class Futbolcu
    {
        // Futbolcular en az 4 gol atmali ki, takim tur atlasin

        public static int skor;

        public Futbolcu() // Bu construct fonksiyonu sonucunda da futbolcunun gol attigini kabul ediyorum
        {
            skor++;
        }

        public void HucumYap() // Bu fonksiyon sonucunda skorboard'u kontrol ediyorum
        {
            if (skor < 2)
            {
                Console.WriteLine("Cok güzel! Ama daha 3 gol atmaliyiz!");
            }
            else if (skor < 3)
            {
                Console.WriteLine("Harika! Ama daha 2 gol atmaliyiz!");
            }
            else if (skor < 4)
            {
                Console.WriteLine("Son bir gayret! 1 gol daha atmaliyiz!");
            }
            else if (skor == 4)
            {
                Console.WriteLine("Yasasin tur atladik!!!");
            }
            else
            {
                Console.WriteLine("Adamlari daha fazla ezmemeliyiz artik");
            }
        }
    }

    public class Karakter
    {
        public int saglik;
        public int yetenek;
        public int guc;

        public Karakter()
        {
            saglik = 100;
            yetenek = 100;
            guc = 100;
        }

        public void EkranaYazdir()
        {
            Console.WriteLine("Oyun Baslasin");
        }
    }

    public class Savasci : Karakter
    {
        public int AtakGucu;
        public static int DusmanSayisi;

        public Savasci()
        {
            AtakGucu = 100;
            DusmanSayisi++;
        }

        public void SavasciEkran()
        {
            Console.WriteLine("Ben Savasciyim");
            Console.WriteLine("Düsman Sayisi : {0}", DusmanSayisi);
        }
    }

    public class Okcu : Karakter
    {
        public int OkMesafesi;

        public Okcu()
        {
            OkMesafesi = 50;
        }

        public void OkcuEkran()
        {
            Console.WriteLine("Ben Okcuyum");
        }

        public static void OkcununGunlugu()
        {
            Console.WriteLine("Okcu bugün üc tane geyik vurdu");
        }
    }

    public class Sihirbaz : Karakter
    {
        public int SihirGucu;

        public Sihirbaz()
        {
            SihirGucu = 25;
        }

        public void SihirbazEkran()
        {
            Console.WriteLine("Ben Sihirbazim");
        }

        public void SihirGucuArttir(int iksir)
        {
            SihirGucu += iksir;
            Console.Write("Yeni sihir gücüm : ");
            Console.WriteLine(SihirGucu);
        }
    }

}
