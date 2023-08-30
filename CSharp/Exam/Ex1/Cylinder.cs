using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2210A_CSharp.Exam.Ex1
{
    public class Cylinder
    {
        public double BaseArea;
        public double LateralArea;
        public double TotalArea;
        public double Volume;

        public void Process(double radius, double height)
        {
            BaseArea = radius * radius * Math.PI;
            LateralArea = 2 * Math.PI * radius * height;
            TotalArea = 2 * Math.PI * radius * (height + radius);
            Volume = Math.PI * radius * radius * height;
        }

        public void Result()
        {
            Console.WriteLine("Base: {0} | Lateral: {1} | Total: {2} | Volume: {3}", BaseArea, LateralArea, TotalArea, Volume);
        }
    }
}