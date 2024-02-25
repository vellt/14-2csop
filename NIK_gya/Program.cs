using NIK_gya.Models;
using NIK_gya.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIK_gya
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://localhost:3000/idoutazok";
            NetworkService networkService = new NetworkService(url);
            List<Idoutazo> idoutazok = networkService.GET<Idoutazo>();
            idoutazok.ForEach(x => Console.WriteLine($"{x.TeljesNev()}: {x.Eletkora(DateTime.Now)}"));

            Console.ReadKey();
        }
    }
}
