
namespace ödev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Kaçtane öğrenci kaydetmek istiyorsunuz:");
                int ogrencısayı = int.Parse(Console.ReadLine());
                string[,] dizi = new string[ogrencısayı + 1, 7];
                double toplam = 0;
                double max = double.MinValue;
                double min = double.MaxValue;


                for (int i = 1; i <= ogrencısayı; i++)
                {



                    Console.Write($"{i}.Öğrenci numarası giriniz: ");
                    string no = Console.ReadLine();


                    Console.Write($"{i}.Öğrenci adı giriniz: ");
                    string ad = Console.ReadLine();

                    Console.Write($"{i}.Soyadı giriniz: ");
                    string soy = Console.ReadLine();

                    double vıze, fınal;
                    do
                    {
                        Console.Write($"{i}.Öğrenci Vize notu giriniz (0-100): ");
                        vıze = double.Parse(Console.ReadLine());
                    } 
                    while (vıze < 0 || vıze > 100);

                    do
                    {
                        Console.Write($"{i}.Öğrenci Final notu giriniz (0-100): ");
                        fınal = double.Parse(Console.ReadLine());
                    }
                    while ( fınal < 0 || fınal > 100);

                    double ortalama = vıze * 0.4 + fınal * 0.6;
                    max = Math.Max(max, Math.Max(vıze, fınal));
                    min = Math.Min(min, Math.Min(vıze, fınal));


                    string harfnotu = ortalama >= 85 ? "AA" :
                                      ortalama >= 75 ? "BA" :
                                      ortalama >= 60 ? "BB" :
                                      ortalama >= 50 ? "CB" :
                                      ortalama >= 40 ? "CC" :
                                      ortalama >= 30 ? "DC" :
                                      ortalama >= 20 ? "DD" :
                                      ortalama >= 10 ? "FD" : "FF";






                    dizi[i, 0] = no;
                    dizi[i, 1] = ad;
                    dizi[i, 2] = soy;
                    dizi[i, 3] = vıze.ToString();
                    dizi[i, 4] = fınal.ToString();
                    dizi[i, 5] = ortalama.ToString("0.00");
                    dizi[i, 6] = harfnotu;
                    toplam += ortalama;
                }

                dizi[0, 0] = "Öğrenci No";
                dizi[0, 1] = "Ad";
                dizi[0, 2] = "Soyad";
                dizi[0, 3] = "Vize Notu";
                dizi[0, 4] = "Final Notu";
                dizi[0, 5] = "Ortalama";
                dizi[0, 6] = "Harf Notu";

                Console.WriteLine("\nGirilen Öğrenci bilgileri");
                Console.WriteLine();
                for (int i = 0; i <= ogrencısayı; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        Console.Write($"{dizi[i, j], -15}");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.WriteLine("\nSınıf Bilgileri:");
                Console.WriteLine($"Sınıf Ortalaması: {toplam / ogrencısayı}");
                Console.WriteLine($"En Yüksek Not: {max}");
                Console.WriteLine($"En Düşük Not: {min}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Yanlış formatta giriş yaptınız. ");

            }
            catch (OverflowException)
            {
                Console.WriteLine(" Lütfen geçerli bir değer giriniz.");

            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Boş bir giriş yaptınız.");

            }
            catch (Exception)
            {
                Console.WriteLine("Beklenmeyen bir hata oluştu.");

            }

        }
    }
}
