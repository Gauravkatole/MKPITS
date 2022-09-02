using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace aRRAY_COLSOLE
{
    internal class Program
    {
        static void Main(string[] args)
        {
        student s1 = new student(12,"Gaurav");
            ArrayList ar = new ArrayList();
        student s2 = new student(22,"Akshay");
            ar.Add(s1);
            ar.Add(s2);

            for(int i = 0; i < ar.Count; i++)
            {
                Console.WriteLine("Roll No: " +s1.roll);
                Console.WriteLine("Name: " + s2.name);
            }

        }
    }
}
