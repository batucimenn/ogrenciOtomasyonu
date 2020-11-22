using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciOtomasyonu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] ogrenciler = new string[5, 3];
            string[,] dersler = new string[3, 2];
            int[,] notlar = new int[10, 3];
            Console.Title = "  -ɗeѕiɢɴ ჩყ  ßʌтu-";
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n  ~ Öğrenci Otomasyonu ~\n");
                Console.WriteLine(" | 1- Öğrenci Kaydet");
                Console.WriteLine(" | 2- Öğrenci Listele");
                Console.WriteLine(" | ----------------");
                Console.WriteLine(" | 3- Ders Ekle");
                Console.WriteLine(" | 4- Dersleri Listele");
                Console.WriteLine(" | ----------------");
                Console.WriteLine(" | 5- Not Ekle");
                Console.WriteLine(" | 6- Notları Listele");
                Console.WriteLine(" | ----------------");
                Console.WriteLine(" | 7- Öğrenci Not Ortalaması");
                Console.WriteLine(" | 8- Tüm Öğrencilerin Not Ortalamaları");
                Console.WriteLine(" | ----------------");
                Console.WriteLine(" | 0- Çıkış\n");
                Console.Write("  Lütfen Seçiminizi Yapınız: ");
                string secim = Console.ReadLine();
                if (secim == "1")
                {
                    Console.Clear();
                    Console.WriteLine("\n  ~ Öğrenci Kaydet ~\n");
                    Console.WriteLine("  Kaydedilecek öğrenci sayısı: 5 ");
                    string ogrenci_no = "";
                    bool no_dogrula = true;
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.WriteLine("\n  {0}. Öğrenci Bilgileri", i + 1);
                            no_dogrula = true;
                            while (no_dogrula)
                            {
                                no_dogrula = false;
                                Console.Write("  Öğrenci No: ");
                                ogrenci_no = Console.ReadLine();
                                for (int k = 0; k < i; k++)
                                {
                                    if (ogrenciler[k, j] == ogrenci_no)
                                    {
                                        Console.WriteLine("\n  Bu öğrenci numarasına ait kayıt mevcuttur. Aynı numara ile birden fazla kayıt yapılamaz.\n Lütfen başka bir öğrenci numarası giriniz.. \n");
                                        no_dogrula = true;
                                    }
                                }
                            }
                            ogrenciler[i, j] = ogrenci_no;
                            j++;
                            Console.Write("  Öğrenci Adı: ");
                            ogrenciler[i, j] = Console.ReadLine();
                            j++;
                            Console.Write("  Öğrenci Soyadı: ");
                            ogrenciler[i, j] = Console.ReadLine();
                            j++;
                        }
                    }
                    Console.WriteLine("\n  Veriler eklendi. Üst dizine çıkmak için (ENTER) tuşuna basınız..");
                }
                else if (secim == "2")
                {
                    Console.Clear();
                    Console.WriteLine("\n  ~ Öğrenci Listesi ~\n");
                    Console.WriteLine("  Numara    Ad       Soyad");
                    Console.WriteLine("  ******    ***      ******");
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write("    " + "{0}" + "     ", ogrenciler[i, j]);
                            j++;
                            Console.Write("{0}" + "     ", ogrenciler[i, j]);
                            j++;
                            Console.Write("{0}", ogrenciler[i, j]);
                            j++;
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\n  Veriler listelendi. Üst dizine çıkmak için (ENTER) tuşuna basınız..");
                }
                else if (secim == "3")
                {
                    Console.Clear();
                    Console.WriteLine("\n  ~ Ders Ekle ~\n");
                    Console.WriteLine("  Kaydedilecek ders sayısı: 3");
                    string ders_kodu = "";
                    bool kod_dogrula = true;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            Console.WriteLine("\n  {0}. Dersin Bilgileri", i + 1);
                            kod_dogrula = true;
                            while (kod_dogrula)
                            {
                                kod_dogrula = false;
                                Console.Write("  Ders Kodu: ");
                                ders_kodu = Console.ReadLine();
                                for (int k = 0; k < i; k++)
                                {
                                    if (dersler[k, j] == ders_kodu)
                                    {
                                        Console.WriteLine("  - Bu ders koduna ait kayıt mevcuttur. Aynı ders kodu ile birden fazla kayıt yapılamaz.\n Lütfen başka bir ders kodu giriniz.. \n");
                                        kod_dogrula = true;
                                    }
                                }
                            }
                            dersler[i, j] = ders_kodu;
                            j++;
                            Console.Write("  Ders Adı: ");
                            dersler[i, j] = Console.ReadLine();
                            j++;
                        }
                    }
                    Console.WriteLine("\n  Veriler eklendi. Üst dizine çıkmak için (ENTER) tuşuna basınız..");
                }
                else if (secim == "4")
                {
                    Console.Clear();
                    Console.WriteLine("\n ~ Ders Listesi ~\n");
                    Console.WriteLine(" Ders Kodu     Ders Adı");
                    Console.WriteLine(" *********     ********");
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 2;)
                        {
                            Console.Write("    " + "{0}" + "         ", dersler[i, j]);
                            j++;
                            Console.Write("{0}", dersler[i, j]);
                            j++;
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\n  Veriler eklendi. Üst dizine çıkmak için (ENTER) tuşuna basınız..");
                }
                else if (secim == "5")
                {
                    Console.Clear();
                    Console.WriteLine("\n  ~ Not Ekle ~\n");
                    Console.WriteLine("  Kaydedilecek not sayısı: 10 ");
                    string ogrenci_no = "";
                    bool no_dogrula = true;
                    string ders_kodu = "";
                    bool kod_dogrula = true;
                    int sayac = 0;
                    int sayac2 = 0;
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.WriteLine("\n  {0}. Notun Bilgileri", i + 1);
                            no_dogrula = true;
                            while (no_dogrula)
                            {
                                sayac = 0;
                                no_dogrula = false;
                                Console.Write("  Öğrenci No: ");
                                ogrenci_no = Console.ReadLine();
                                for (int k = 0; k < 5; k++)
                                {
                                    if (ogrenciler[k, 0] == ogrenci_no)
                                    {
                                        no_dogrula = false;
                                        break;
                                    }
                                    sayac++;
                                }
                                if (sayac == 5)
                                {
                                    no_dogrula = true;
                                    Console.WriteLine("\n  Bu öğrenci numarasına ait kayıt bulunamadı.\n  Lütfen kayıtlı  bir öğrenci numarası giriniz.. \n");
                                }
                            }
                            notlar[i, j] = Convert.ToInt32(ogrenci_no);
                            j++;
                            kod_dogrula = true;
                            while (kod_dogrula)
                            {
                                sayac2 = 0;
                                kod_dogrula = true;
                                while (kod_dogrula)
                                {
                                    Console.Write("  Ders Kodu: ");
                                    ders_kodu = Console.ReadLine();
                                    for (int k = 0; k < 3; k++)
                                    {
                                        if (dersler[k, 0] == ders_kodu)
                                        {
                                            kod_dogrula = false;
                                            break;
                                        }
                                    }
                                    if (kod_dogrula)
                                    {
                                        Console.WriteLine("\n  Bu ders koduna ait kayıt bulunamadı.\n  Lütfen kayıtlı bir ders kodu giriniz.. \n");
                                    }
                                }
                            }
                            notlar[i, j] = Convert.ToInt32(ders_kodu);
                            j++;
                            Console.Write("  Aldığı Not: ");
                            notlar[i, j] = Convert.ToInt32(Console.ReadLine());
                            j++;
                        }
                    }
                    Console.WriteLine("\n  Veriler eklendi. Üst dizine çıkmak için (ENTER) tuşuna basınız..");
                }
                else if (secim == "6")
                {
                    Console.Clear();
                    Console.WriteLine("\n  ~ Notlar Listesi ~\n");
                    Console.WriteLine("  Ad       Soyad       Ders       Not");
                    Console.WriteLine("  ***      ******      ****       ***");
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < ogrenciler.GetLength(0); j++)
                        {
                            if (Convert.ToString(notlar[i, 0]) == ogrenciler[j, 0])
                            {
                                Console.Write(ogrenciler[j, 1] + "    " + ogrenciler[j, 2]);
                            }
                        }

                        for (int ders = 0; ders < 3; ders++)
                        {
                            if (Convert.ToString(notlar[i, 1]) == dersler[ders, 0])
                            {
                                Console.Write("     " + dersler[ders, 1]);
                            }
                        }
                        Console.Write("     {0}", notlar[i, 2]);
                        Console.WriteLine();
                    }
                    Console.WriteLine("\n  Veriler listelendi. Üst dizine çıkmak için (ENTER) tuşuna basınız..");
                }
                else if (secim == "7")
                {
                a:
                    bool kontrol2 = false;
                    int sayac1 = 0, sayac2 = 0, sayac3 = 0, say1 = 0, say2 = 0, say3 = 0, toplam1 = 0, toplam2 = 0, toplam3 = 0; int sayac = 0;
                    Console.Clear();
                    Console.WriteLine("\n  ~ Öğrenci Not Ortalaması ~\n");
                    Console.WriteLine("  Not ortalaması alınacak öğrenci numarasını giriniz: ");
                    int numara = Convert.ToInt32(Console.ReadLine());
                    sayac = numara;
                    for (int i = 0; i < 5; i++)
                    {
                        if (numara == Convert.ToInt32(ogrenciler[i, 0]))
                            kontrol2 = true;
                    }
                    if (kontrol2 == false)
                    {
                        Console.WriteLine("Sistemde Böyle Bir Öğrenci Bulunmamaktadır Lütfen Öğrenci Numarısını Tekrar Giriniz!");
                        goto a;
                    }
                    for (int j = 0; j < 10; j++)
                    {
                        if (notlar[j, 0] == numara)
                        {
                            for (int k = 0; k < 3; k++)
                            {
                                if (notlar[j, 1] == Convert.ToInt32(dersler[k, 0]))
                                {
                                    if (k == 0)
                                    {
                                        toplam1 = toplam1 + notlar[j, 2];
                                        say1++;
                                    }
                                    else if (k == 1)
                                    {
                                        toplam2 = toplam2 + notlar[j, 2];
                                        say2++;
                                    }
                                    else if (k == 2)
                                    {
                                        toplam3 = toplam3 + notlar[j, 2];
                                        say3++;
                                    }
                                }
                            }
                        }
                    }
                    if (toplam1 == 0 && say1 == 0)
                    {
                        Console.WriteLine("\nGirilen öğrenci için " + dersler[0, 1] + " dersine ait kayıt bulunmadı.");
                        sayac1++;
                    }
                    else
                    {
                        Console.WriteLine("\nGirilen öğrenci için " + dersler[0, 1] + " dersinden aldığı notların ortalaması:" + toplam1 / say1);
                    }
                    if (toplam2 == 0 && say2 == 0)
                    {
                        Console.WriteLine("\nGirilen öğrenci için " + dersler[1, 1] + " dersine ait kayıt bulunmadı.");
                        sayac2++;
                    }
                    else
                    {
                        Console.WriteLine("\nGirilen öğrenci için " + dersler[1, 1] + " dersinden aldığı notların ortalaması:" + toplam2 / say2);
                    }
                    if (toplam3 == 0 && say3 == 0)
                    {
                        Console.WriteLine("\nGirilen öğrenci için " + dersler[2, 1] + " dersine ait kayıt bulunmadı.");
                        sayac3++;
                    }
                    else
                    {
                        Console.WriteLine("\nGirilen öğrenci için " + dersler[2, 1] + " dersinden aldığı notların ortalaması:" + toplam3 / say3);
                    }
                }
                else if (secim == "8")
                {
                    Console.Clear();
                    Console.WriteLine("\n  ~ Tüm Öğrencilerin Notları Ortalamaları ~\n");
                    for (int i = 0; i < 5; i++)
                    {
                        int ortalama = 0;
                        int adet = 0;
                        for (int j = 0; j < 10; j++)
                            if (notlar[j, 0] == Convert.ToInt32(ogrenciler[i, 0]))
                            {
                                ortalama = ortalama + notlar[j, 2];
                                adet++;
                            }
                        if (adet == 0)
                        {
                            Console.WriteLine(ogrenciler[i, 1] + " " + ogrenciler[i, 2] + " Öğrencisinin Sisteme Kayıtlı Hiç Bir Dersi Bulunmamaktadır.\n");
                        }
                        else
                        {
                            Console.WriteLine(ogrenciler[i, 1] + " " + ogrenciler[i, 2] + " Öğrencisinin Tüm Derslerinin Ortalamsı:" + ortalama / adet + "\n");
                        }
                    }
                }
                else if (secim == "0")
                {
                    Environment.Exit(0);
                }
                Console.ReadLine();
            }
        }
    }
}
