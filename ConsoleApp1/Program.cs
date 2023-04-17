using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsuletion;

namespace Encapsuletion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            laptop lp1 = new laptop();
            lp1.merek = "ACER";
            lp1.model = "NITRO 5";
            lp1.tahun = "2023";

            Console.WriteLine($"Merek Laptop : {lp1.merek}" + "\n" + $"Model Laptop : {lp1.model}" + "\n" + $"Tahun Keluaran : {lp1.tahun}");
            Console.WriteLine("----------------------");

            laptop lp2 = new laptop();
            lp2.SetLaptop("LENOVO", "LEGION 5");
            lp2.SetTahunkeluar("2023");
            Console.Write(lp2);

            Console.ReadKey();
        }
    }
}
