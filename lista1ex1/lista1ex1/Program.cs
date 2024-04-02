using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex1
{
    internal class Program
    {       
        static void Main(string[] args)
        {
            int b;
            int a;
            int area;
           

            Console.Write("digite a base do retângulo:");
            b = int.Parse(Console.ReadLine());

            Console.Write("digite a altura do retângulo:");
            a = int.Parse(Console.ReadLine());

            area = b * a;

            Console.Write("a área do retângulo é:");
            Console.WriteLine(area);
           



        }
    }
}
