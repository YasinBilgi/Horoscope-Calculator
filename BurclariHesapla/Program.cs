namespace BurclariHesapla
{
     internal class Program
     {
        public static void Main(string[] args)
        {
            int gun;
            int ay;
            int yil;

            Console.WriteLine("BURÇ HESAPLAMA");
            Console.WriteLine("***************************************");
            Console.WriteLine("GÜN Giriniz");
            gun = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("AY Giriniz");
            ay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("YIL Giriniz");
            yil = Convert.ToInt32(Console.ReadLine());  
            
            DateTime DogumTarihi = new DateTime(yil, ay, gun);


            
            if (DogumTarihi.Month == 12 && DogumTarihi.Day >= 22 || DogumTarihi.Month == 1 && DogumTarihi.Day <= 21)
            {
                Console.WriteLine("Burcunuz : OĞLAK");
            }
            else if (DogumTarihi.Month == 9 && DogumTarihi.Day >= 23 || DogumTarihi.Month == 10 && DogumTarihi.Day <= 22)
            {
                Console.WriteLine("Burcunuz : TERAZİ");
            }
            else if (DogumTarihi.Month == 1 && DogumTarihi.Day >= 22 || DogumTarihi.Month == 2 && DogumTarihi.Day <= 19)
            {
                Console.WriteLine("Burcunuz : KOVA");
            }
            else if (DogumTarihi.Month == 2 && DogumTarihi.Day >= 20 || DogumTarihi.Month == 3 && DogumTarihi.Day <= 20)
            {
                Console.WriteLine("Burcunuz : BALIK");
            }
            else if (DogumTarihi.Month == 3 && DogumTarihi.Day >= 21 || DogumTarihi.Month == 4 && DogumTarihi.Day <= 20)
            {
                Console.WriteLine("Burcunuz : KOÇ");
            }
            else if (DogumTarihi.Month == 4 && DogumTarihi.Day >= 21 || DogumTarihi.Month == 5 && DogumTarihi.Day <= 21)
            {
                Console.WriteLine("Burcunuz : BOĞA");
            }
            else if (DogumTarihi.Month == 5 && DogumTarihi.Day >= 22 || DogumTarihi.Month == 6 && DogumTarihi.Day <= 22)
            {
                Console.WriteLine("Burcunuz : İKİZLER");
            }
            else if (DogumTarihi.Month == 6 && DogumTarihi.Day >= 23 || DogumTarihi.Month == 7 && DogumTarihi.Day <= 22)
            {
                Console.WriteLine("Burcunuz : YENGEÇ");
            }
            else if (DogumTarihi.Month == 7 && DogumTarihi.Day >= 23 || DogumTarihi.Month == 8 && DogumTarihi.Day <= 22)
            {
                Console.WriteLine("Burcunuz : ASLAN");
            }
            else if (DogumTarihi.Month == 8 && DogumTarihi.Day >= 23 || DogumTarihi.Month == 9 && DogumTarihi.Day <= 22)
            {
                Console.WriteLine("Burcunuz : BAŞAK");
            }
            else if (DogumTarihi.Month == 10 && DogumTarihi.Day >= 23 || DogumTarihi.Month == 11 && DogumTarihi.Day <= 21)
            {
                Console.WriteLine("Burcunuz : AKREP");
            }
            else if (DogumTarihi.Month == 11 && DogumTarihi.Day >= 22 || DogumTarihi.Month == 12 && DogumTarihi.Day <= 21)
            {
                Console.WriteLine("Burcunuz : YAY");
            }
            else
            {
                Console.WriteLine("Hatalı Tuşlama Yaptınız");
            }
        }
    }
}