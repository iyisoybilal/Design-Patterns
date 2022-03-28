using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonÖrnek
{
    class YukDengeleyici
    {
        private static YukDengeleyici nesne;
        private List<string> sunucular = new List<string>();
        private Random rnd = new Random();
        // Lock islemi icin gerekli
        private static object kilit = new object();
        protected YukDengeleyici()
        {
            sunucular.Add("Sunucu_I");
            sunucular.Add("Sunucu_II");
            sunucular.Add("Sunucu_III");
            sunucular.Add("Sunucu_IV");
            sunucular.Add("Sunucu_V");
        }
        public static YukDengeleyici YukDengeleyiciyiGetir()
        {
            // Multi thread 
            if (nesne == null)
            {
                lock (kilit)
                {
                    if (nesne == null)
                    {
                        nesne = new YukDengeleyici();
                    }
                }
            }
            return nesne;
        }
        // Yuk dengelemek icin rastgele sunucu acar.
        public string Sunucu
        {
            get
            {
                int r = rnd.Next(sunucular.Count);
                return sunucular[r].ToString();
            }
        }
    }
}