
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonÖrnek
{
    class Program
    {
        static void Main(string[] args)
        {

            YukDengeleyici yd1 = YukDengeleyici.YukDengeleyiciyiGetir();
            YukDengeleyici yd2 = YukDengeleyici.YukDengeleyiciyiGetir();
            YukDengeleyici yd3 = YukDengeleyici.YukDengeleyiciyiGetir();
            YukDengeleyici yd4 = YukDengeleyici.YukDengeleyiciyiGetir();
            YukDengeleyici yd5 = YukDengeleyici.YukDengeleyiciyiGetir();
            // Nesne kontrol
            if (yd1 == yd2 && yd2 == yd3 && yd3 == yd4)
            {
                Console.WriteLine("Nesnelerin ayni oldugu goruluyor.\n");
            }
            // Yuk dengelemek icin 15 sunucu istegi
            YukDengeleyici dengeleyici = YukDengeleyici.YukDengeleyiciyiGetir();
            for (int i = 0; i < 15; i++)
            {
                string server = dengeleyici.Sunucu;
                Console.WriteLine("Su sunucuya istek gonderildi: " + server);
            }
            Console.ReadKey();

        }
    }
}

