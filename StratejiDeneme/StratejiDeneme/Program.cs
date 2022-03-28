using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StratejiDeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Eleman eleman = new Eleman(new SirketA(),new YoneticiMaas());
            int yoneticiIzın= eleman.İzinHesap();
            int yoneticiMaas = eleman.MaasHesap();
            Console.WriteLine("Yonetici İzni" + yoneticiIzın + "Yonetici Maasi" + yoneticiMaas);
            Console.ReadLine();
        }
    }
}
