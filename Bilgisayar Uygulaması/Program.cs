using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilgisayar_Uygulaması
{
    
    class bilgisayar
    {
        int oyuncu1_puan = 0;
        int oyuncu2_puan = 0;
        public void ac()
        {
            
            Console.WriteLine("Bilgisayar Açılıyor...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Bilgisayar Açıldı");
            Console.Clear();
        }
        public void kapa()
        {
            Console.Clear();
            Console.WriteLine("Bilgisayar Kapanıyor...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Bilgisayar Kapandı");
        }
        public void hesapMakinesi()
        {
            Console.WriteLine("Hesap Makinesine Giriş Yapılıyor...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Hesap Makinesine Giriş Yapıldı");
        }
        public void alanbulma()
        {
            Console.Clear();

            Console.WriteLine("Alan Bulmaya Giriş Yapılıyor...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Alan Bulmaya Giriş Yapıldı");
            Console.WriteLine("Kare'nin Alanını Bulmak İçin 1'e Basınız");
            Console.WriteLine("Üçgen'in Alanını Bulmak İçin 2'ye Basınız");
            Console.WriteLine("Dikdörtge'nin Alanını Bulmak İçin 3'e Basınız");
            Console.WriteLine("Daire'nin Alanını Bulmak İçin 4'e Basınız");
            
            int asecim=Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if(asecim==1)
            {
                
                Console.Write("Karenin 1 Kenarını Giriniz: ");
                int alan1 = Convert.ToInt32(Console.ReadLine());
                int kare = alan1 * alan1;
                Console.WriteLine("Kare'nin Alanı " + kare);
            }
            if(asecim==2)
            {
                
                Console.Write("Üçgenin Tabanını Giriniz: ");
                int alan1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Üçgenin Yüksekliğini Giriniz: ");
                int alan2 = Convert.ToInt32(Console.ReadLine());
                int üçgen=(alan1 * alan2)/2;
            }
            if(asecim==3)
            {
                Console.Write("Dikdörtge'nin Uzun Kenarını Giriniz: ");
                int alan1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Dikdörtge'nin Kısa Kenarını Giriniz: ");
                int alan2 = Convert.ToInt32(Console.ReadLine());
                int dikdörtgen = alan1 * alan2;
            }
            if(asecim==4)
            {
                Console.Write("Dairenin Yarıçapını Giriniz: ");
                int yarıcap = Convert.ToInt32(Console.ReadLine());
                int daire = (yarıcap * yarıcap) * 3;
                Console.WriteLine(daire);
            }
            
        }
       
        public void tas_kagıt_makas()
        {
            Console.WriteLine("Taş Kağıt Makasa Giriş Yapılyor...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Taş Kağıt Makasa Giriş Yapıldı");
            Console.Clear();
            Console.WriteLine("|---------------------------------------------|");
            Console.WriteLine("|                                             |");
            Console.WriteLine("|                                             |");
            Console.WriteLine("|    Taş-Kağıt-Makas Oyununa Hoş Geldiniz     |");
            Console.WriteLine("|                                             |");
            Console.WriteLine("|                                             |");
            Console.WriteLine("|---------------------------------------------|");
            Console.ReadKey();
            Console.Clear();
            for (int i = 1; i <= 5; i++)
            {
                Console.Clear();
                Console.WriteLine("|---------------------------------------------|");
                Console.WriteLine("|                  1-Taş                      |");
                Console.WriteLine("|                                             |");
                Console.WriteLine("|                  2-Kağıt                    |");
                Console.WriteLine("|                                             |");
                Console.WriteLine("|                  3-Makas                    |");
                Console.WriteLine("|                                             |");
                Console.WriteLine("|---------------------------------------------|");
                Console.WriteLine("                                               ");
                Console.Write("1. Oyuncu " + i + ".Seçiminizi Yapınız : ");
                int oyuncu1 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("|---------------------------------------------|");
                Console.WriteLine("|                  1-Taş                      |");
                Console.WriteLine("|                                             |");
                Console.WriteLine("|                  2-Kağıt                    |");
                Console.WriteLine("|                                             |");
                Console.WriteLine("|                  3-Makas                    |");
                Console.WriteLine("|                                             |");
                Console.WriteLine("|---------------------------------------------|");
                Console.WriteLine("                                               ");
                Console.Write("2. Oyuncu " + i + ".Seçiminizi Yapınız : ");
                int oyuncu2 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (oyuncu1 == 1 && oyuncu2 == 1)
                {
                    Console.WriteLine(i + ". oyun Beraber ");
                }
                else if (oyuncu1 == 1 && oyuncu2 == 2)
                {
                    oyuncu2_puan += 5;
                    Console.WriteLine(i + ". oyunu 2.Oyuncu Kazandı ");
                }
                else if (oyuncu1 == 1 && oyuncu2 == 3)
                {
                    oyuncu1_puan += 5;
                    Console.WriteLine(i + ". oyunu 1.Oyuncu Kazandı ");
                }
                else if (oyuncu1 == 2 && oyuncu2 == 1)
                {
                    oyuncu1_puan += 5;
                    Console.WriteLine(i + ". oyunu 1.Oyuncu Kazandı ");
                }
                else if (oyuncu1 == 2 && oyuncu2 == 2)
                {
                    Console.WriteLine(i + ". oyun Beraber ");
                }
                else if (oyuncu1 == 2 && oyuncu2 == 3)
                {
                    oyuncu2_puan += 5;
                    Console.WriteLine(i + ". oyunu 2.Oyuncu Kazandı ");
                }
                else if (oyuncu1 == 3 && oyuncu2 == 1)
                {
                    oyuncu2_puan += 5;
                    Console.WriteLine(i + ". oyunu 2.Oyuncu Kazandı ");
                }
                else if (oyuncu1 == 3 && oyuncu2 == 2)
                {
                    oyuncu1_puan += 5;
                    Console.WriteLine(i + ". oyunu 1.Oyuncu Kazandı ");
                }
                else if (oyuncu1 == 3 && oyuncu2 == 3)
                {
                    Console.WriteLine(i + ". oyun Beraber ");
                }
                Console.Clear();
                Console.WriteLine("|----------------------------------------|");
                Console.WriteLine("| 1.Oyuncunun Puanı : " + oyuncu1_puan + " |");
                Console.WriteLine("|                                        |");
                Console.WriteLine("| 2.Oyuncunun Puanı : " + oyuncu2_puan + " |");
                Console.WriteLine("|----------------------------------------|");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
                if (oyuncu1_puan > oyuncu2_puan)
                {
                    Console.WriteLine("                                ");
                    Console.WriteLine("       1. Oyuncu Kazandı        ");
                    Console.WriteLine("                                ");
                }
                else if (oyuncu2_puan > oyuncu1_puan)
                {
                    Console.WriteLine("                                ");
                    Console.WriteLine("       2. Oyuncu Kazandı        ");
                    Console.WriteLine("                                ");
                }
                else
                {
                    Console.WriteLine("                                ");
                    Console.WriteLine("           Berabere             ");
                    Console.WriteLine("                                ");
                }

                Console.ReadKey();
            }

            Console.ReadKey();
            Console.Clear();
        }



    }
    internal class Program
    {

        static void Main(string[] args)
        {
            bilgisayar pc = new bilgisayar();
            Console.Write("Bilgisayarı Açmak İçin 1'e Basınız: ");
            
            int secim1 = Convert.ToInt32(Console.ReadLine());
            if(secim1==1)
            {
                pc.ac();
            }
            

            Console.WriteLine("|---------------------------------|");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|---------------------------------|");
            Console.WriteLine("                 ||");
            Console.WriteLine("         |-----------------|");
            Console.WriteLine("         |                 |");
            Console.WriteLine("         |-----------------|");
            Console.WriteLine("                                   ");
            Console.WriteLine("Bilgisayarı Kapatmak İçin 2'ye Basınız");
            Console.WriteLine("Hesap Makinesine Giriş Yapmak İçin 3'e Basınız");
            Console.WriteLine("Alan Bulmak İçin 4'e Basınız");
            Console.WriteLine("Taş-Kağıt-Makas Oynamak İçin 5'e Basınız");
            int secim2 = Convert.ToInt32(Console.ReadLine());
            if (secim2==2)
            {
                pc.kapa();
            }
            if(secim2==5)
            {
                pc.tas_kagıt_makas();
            }
            if(secim2==4)
            {
                pc.alanbulma();
            }else if(secim2 > 5)
            {
                Console.WriteLine("Lütfen Doğru tuşlayın");
            }
            
            Console.ReadLine();
        }
    }
}
