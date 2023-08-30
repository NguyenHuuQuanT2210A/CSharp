using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Exam.Ex2
{
    public class Test
    {
        static void Main(string[] args)
        {
            Tiger tiger = new Tiger(200.0, "Tiger");
            Lion lion = new Lion(100.0, "Lion");
            
            
            tiger.Show();
            lion.Show();
        }
    }
}
