// Game Academy Day #1
using System;
using System.Collections;
namespace unity_gun_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //KararYapisi();
            //KararYapisi2();
            //ForDongusu();
            //WhileDongusu();
            //IcIceDonguYapisi();
            //SwitchCaseYapisi();
            //Diziler();
            //ForForeachDongusu();
            //HesapMakinesi();

            ArrayLists();

            Console.ReadKey();
        }

        private static void ArrayLists()
        {
            // Calisma zamaninda ArrayList lerin eleman sayisi artar ya da azalir. Foreach döngüsü ile ArrayList icerisinde dönülür.

            int[] sayilar = new int[7];
            int[] sayilar2 = { 0, 2, 4, 6, 8, 10, 11 };

            ArrayList liste = new ArrayList();
            liste.Add("Hello");
            liste.Add("Merhaba");

            foreach (object o in liste)
            {
                Console.WriteLine((string)o);
            }
        }

        private static void HesapMakinesi()
        {
            string s1, s2, s3;
            Console.WriteLine("Birinci sayiyi giriniz :");
            s1 = Console.ReadLine();
            Console.WriteLine("Ikinci sayiyi giriniz :");
            s2 = Console.ReadLine();
            Console.WriteLine("Islemi Giriniz  + , - , * , / :");
            s3 = Console.ReadLine();

            int x1 = Convert.ToInt32(s1);
            int x2 = Convert.ToInt32(s2);

            switch (s3)
            {
                case "+":
                    Console.WriteLine(x1 + x2);
                    break;
                case "-":
                    Console.WriteLine(x1 - x2);
                    break;
                case "*":
                    Console.WriteLine(x1 * x2);
                    break;
                case "/":
                    Console.WriteLine(x1 / x2);
                    break;
                default:
                    Console.WriteLine("Islemi bulamadim");
                    break;
            }
        }

        private static void ForForeachDongusu()
        {
            int[] scoreboard = new int[100];
            for (int i = 0; i < 100; i++)
            {
                scoreboard[i] = i;
            }

            foreach (int x in scoreboard)
            {
                Console.WriteLine(x);
            }
        }

        private static void Diziler()
        {
            int[] sayiDizim = new int[10];
            string[] metinDizisi = new string[15];

            // [0] [1] [2] [3] [4] [5] [6] [7] [8] [9]  index, indis  toplam eleman sayisi -1 dir.
            // Dizilerin boyutu calisma zamaninda arttirilamaz.

            for (int i = 0; i < 10; i++)
            {
                sayiDizim[i] = 0;
                Console.Write(i);
            }

            Console.WriteLine();
            for (int i = 0; i < sayiDizim.Length; i++)
            {
                Console.Write(sayiDizim[i]);
            }

            for (int i = 0; i < sayiDizim.Length; i++)
            {
                Console.WriteLine(sayiDizim[i]);
            }

            string[,] metinDizisi2 = new string[2, 3]; // 2 boyutlu dizi
        }

        private static void SwitchCaseYapisi()
        {
            string s = Console.ReadLine();
            int x = Convert.ToInt32(s);

            switch (x)
            {
                case 2:
                    Console.WriteLine("Deger 2'dir");
                    break;
                case 1:
                    Console.WriteLine("Deger 1'dir");
                    break;
                case 3:
                    Console.WriteLine("Deger 3'tür");
                    break;
                default:
                    Console.WriteLine("Deger 1,2 ya da 3 degildir");
                    break;
            }
        }

        private static void IcIceDonguYapisi()
        {
            string s;
            Console.WriteLine("Bir harf giriniz>");
            s = Console.ReadLine();
            if (s == "E")
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else if (s == "H")
            {
                for (int i = 10; i > 5; i--)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Girdiginiz harf yanlistir");
            }
        }

        private static void WhileDongusu()
        {
            int x = 10;

            while (x > 10)
            {
                Console.WriteLine(x);
                x--;
            }
        }

        private static void ForDongusu()
        {
            for (int i = 0; i <= 10; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        private static void KararYapisi2()
        {
            string s;
            Console.WriteLine("Lütfen isminizi giriniz>");
            s = Console.ReadLine();
            if (s == "Reha")
            {
                Console.WriteLine("Merhaba Reha");
            }
            else if (s == "Mehmet")
            {
                Console.WriteLine("Merhaba Mehmet");
            }
            else if (s == "Ayse")
            {
                Console.WriteLine("Merhaba Ayse");
            }
            else
            {
                Console.WriteLine("Seni tanimiyorum");
            }
        }

        private static void KararYapisi()
        {
            int x = 10;
            int y = 8;

            if (x > y) // 
            {
                Console.WriteLine("x, y'den büyüktür");
            }
            else if (x == y)
            {
                Console.WriteLine("x ve y birbirine esittir");
            }
            else // Yukarida tüm ihtimaller kontrol edilir, geri kalan ihtimal bu alana yazilir
            {
                Console.WriteLine("x, y'den kücüktür");
            }

            Console.ReadLine();
        }

        private static void Intro()
        {
            /*
            string s = "Merhaba";
            int ts = 100;
            Console.WriteLine("{0} {1}",s,ts);
            Console.ReadKey();
            */

            //implicit

            Console.WriteLine("Bir tamsayi giriniz>");
            string ts1 = Console.ReadLine();
            int tamsayi1 = Convert.ToInt32(ts1);
            Console.WriteLine(tamsayi1 * 5);
            Console.ReadKey();

            /*
             Matematiksel operatörler

             + -> Toplama
             - -> Ciakrma
             / -> Bölme
             * -> Carpma
             % -> Mod Alma

            Mantiksal Operatörler --> ciktilari Boolean tipindedir (True ya da False)

            >   : Büyüktür
            <   : Kücüktür
            >=  : Büyük esit
            <=  : Kücük esit
            !=  : Esit degilse
            ==  : Esitse
            ??  : Degilse

            int t1=5;
            int t2=3;
            t1 < t2 --> false
            t1 > t2 --> true

            t1 == t2 --> False
            t1 != t2 --> True

             */
        }
    }
}