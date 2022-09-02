using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculate;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number-1: ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number-2: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Class1 c=new Class1();
            int r=c.addition(a, b);
            Console.WriteLine("Addition of Two Number Is: "+r);

            int e=c.Substraction(a, b);
            Console.WriteLine("Substraction of Two No: "+e);
            Console.ReadLine();

        }
    }
}
