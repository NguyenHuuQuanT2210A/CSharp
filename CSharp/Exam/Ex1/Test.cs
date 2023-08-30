using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2210A_CSharp.Exam.Ex1;

namespace CSharp.Exam.Ex1
{
    public class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the dimensions of the GeometryExample");
            Console.Write("Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Cylinder c = new Cylinder();
            c.Process(radius, height);
            c.Result();
        }
    }
}
