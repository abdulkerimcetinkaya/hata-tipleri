using System;

namespace hata_yonetimi
{
    class Program
    {
        public static void Main(String[] args)
        {

            try
            {
                Console.WriteLine("Bir sayi giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı: " + sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine("hata : " + ex.Message.ToString());
            }

            finally
            {
                Console.WriteLine("İşlem tamamlandı.");
            }


            try
            {
                int a = int.Parse("-20000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş bir değer girdiniz");
                Console.WriteLine(ex);
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Veri Tipi uygun değil");
                Console.WriteLine(ex);
            }

            catch(OverflowException ex)
            {
                Console.WriteLine("Çok küçük yada çok büyük değer girdiniz.");
                Console.WriteLine(ex);
            }

            finally
            {
                Console.WriteLine("İşlem başarıyla tamamlandı.");
            }
        }
    }

}
