using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.demo5
{
    public class DemoNumber
    {
        public int X { get; set; }  //abstract property
        public int Y { get; set; }

        public void ChangeData()
        {
            X++;
            Y++;
        }

        public void PtintData()
        {
            Console.WriteLine("X " + X);
            Console.WriteLine("Y "+ Y);
        }
    }
}
