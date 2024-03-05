using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp_P1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Apliksi Calculator";

            //int a = 10;
            //int b = 6;    
            Console.Write("Inputkan nilai a = ");
            int a = int.Parse(Console.ReadLine()); // proses casting

            Console.Write("Inputkan nilai a = ");
            int b =Convert.ToInt32(Console.ReadLine()); // proses casting



            Console.WriteLine("Hasil Penambahan " +a+ "+" +b+ "=" + Penambahan (a,b));
            Console.WriteLine("Hasil perkalian {0} *{1}={2}",a,b,Perkalian(a, b));
            Console.WriteLine("Hasil pengurangan {0} -{1} ={2}" , a , b , Pengurangan(a, b));
            Console.WriteLine("Hasil Pembagian {0}/{1}={2}",a,b, Pembagian(a, b));
        }
        static int Penambahan (int a,int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
