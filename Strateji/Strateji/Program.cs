using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strateji
{
    class Program
    {
        static void Main(string[] args)
        {
            Eleman eleman = new Eleman(new DepartmanAİzinHesap(), new YöneticiMaasHesap());
            int yöneticiMaas = eleman.MaasHesapla();
            int yöneticiİzin = eleman.İzinHesapla();
            Console.WriteLine("Yönetici Maası:"+" "+ yöneticiMaas +" " + "Yönetici İzini:"+ " " + yöneticiİzin);
            Console.ReadLine();
        }
    }
}
