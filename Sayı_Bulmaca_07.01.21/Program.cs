using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayı_Bulmaca_07._01._21
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rastgeleSayiUretici = new Random();
            int uretilenSayi = rastgeleSayiUretici.Next(1, 100);
            bool sayiBulunduMu = false;



            while (!sayiBulunduMu)
            {

                Console.WriteLine("Tahmininizi giriniz:");
                int tahminEdilenSayi = Convert.ToInt32(Console.ReadLine());


                if (uretilenSayi > tahminEdilenSayi)
                {
                    Console.WriteLine("Yukarı!");
                }
                else if (uretilenSayi < tahminEdilenSayi)
                {
                    Console.WriteLine("Aşağı!");
                }
                else
                {
                    Console.WriteLine("Tebrikler, doğru tahmin \n tekrar oynamak için 'E' çıkmak için 'H' tuşuna tıklayınız !");
                    while (tahminEdilenSayi == uretilenSayi)
                    {
                        string tekrar = Convert.ToString(Console.ReadLine());
                        if (tekrar == "E" || tekrar == "e")
                        {
                            sayiBulunduMu = false;
                            Console.WriteLine("Haydi, devam edeliim!");
                            break;
                        }
                        else if (tekrar == "H" || tekrar == "h")
                        {
                            sayiBulunduMu = true;
                            Console.WriteLine("Oyun bitti, entere basıp console'u kapatabilirisiniz!");
                            break;
                        }

                        else
                            Console.WriteLine("Geçersiz tuşa bastınız");
                    }
                }

            }

            Console.ReadLine();
        }
    }
}