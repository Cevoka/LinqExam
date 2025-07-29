using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1. Rastgele 10 adet sayıdan oluşan liste oluşturma
        Console.WriteLine("=== LINQ Pratik Uygulaması ===\n");
        
        Random random = new Random();
        List<int> sayilar = new List<int>();
        
        // -30 ile 30 arasında rastgele sayılar üretiyoruz
        for (int i = 0; i < 10; i++)
        {
            sayilar.Add(random.Next(-30, 31));
        }
        
        Console.WriteLine("Oluşturulan Liste:");
        Console.WriteLine($"[{string.Join(", ", sayilar)}]\n");
        
        // 2. Çift olan sayılar
        Console.WriteLine("--- Çift Sayılar ---");
        var ciftSayilar = sayilar.Where(x => x % 2 == 0);
        Console.WriteLine($"Çift sayılar: [{string.Join(", ", ciftSayilar)}]");
        Console.WriteLine($"Toplam çift sayı adedi: {ciftSayilar.Count()}\n");
        
        // 3. Tek olan sayılar
        Console.WriteLine("--- Tek Sayılar ---");
        var tekSayilar = sayilar.Where(x => x % 2 != 0);
        Console.WriteLine($"Tek sayılar: [{string.Join(", ", tekSayilar)}]");
        Console.WriteLine($"Toplam tek sayı adedi: {tekSayilar.Count()}\n");
        
        // 4. Negatif sayılar
        Console.WriteLine("--- Negatif Sayılar ---");
        var negatifSayilar = sayilar.Where(x => x < 0);
        Console.WriteLine($"Negatif sayılar: [{string.Join(", ", negatifSayilar)}]");
        Console.WriteLine($"Toplam negatif sayı adedi: {negatifSayilar.Count()}\n");
        
        // 5. Pozitif sayılar
        Console.WriteLine("--- Pozitif Sayılar ---");
        var pozitifSayilar = sayilar.Where(x => x > 0);
        Console.WriteLine($"Pozitif sayılar: [{string.Join(", ", pozitifSayilar)}]");
        Console.WriteLine($"Toplam pozitif sayı adedi: {pozitifSayilar.Count()}\n");
        
        // 6. 15'ten büyük ve 22'den küçük sayılar
        Console.WriteLine("--- 15 < x < 22 Arasındaki Sayılar ---");
        var aralikSayilari = sayilar.Where(x => x > 15 && x < 22);
        Console.WriteLine($"15'ten büyük ve 22'den küçük sayılar: [{string.Join(", ", aralikSayilari)}]");
        Console.WriteLine($"Bu aralıktaki sayı adedi: {aralikSayilari.Count()}\n");
        
        // 7. Her sayının karesi (yeni liste)
        Console.WriteLine("--- Sayıların Kareleri ---");
        var karelerListesi = sayilar.Select(x => x * x).ToList();
        Console.WriteLine("Orijinal sayılar ve kareleri:");
        for (int i = 0; i < sayilar.Count; i++)
        {
            Console.WriteLine($"{sayilar[i]}² = {karelerListesi[i]}");
        }
        Console.WriteLine($"\nKareler listesi: [{string.Join(", ", karelerListesi)}]\n");
        
        // Bonus: Ek bilgiler
        Console.WriteLine("=== Bonus İstatistikler ===");
        Console.WriteLine($"En büyük sayı: {sayilar.Max()}");
        Console.WriteLine($"En küçük sayı: {sayilar.Min()}");
        Console.WriteLine($"Sayıların toplamı: {sayilar.Sum()}");
        Console.WriteLine($"Sayıların ortalaması: {sayilar.Average():F2}");
        
        Console.WriteLine("\nProgram tamamlandı. Bir tuşa basın...");
        Console.ReadKey();
    }
}
