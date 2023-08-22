using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.demo3
{
    public class CodeTeacher : Teacher, ITeacher
    {
        private int age;
        public CodeTeacher() { }

        public CodeTeacher(string name, int age) : base(name)
        {
            this.age = age;
        }

        public override void Teach()
        {
            base.Lunch();
        }

        public new void Lunch()
        {

        }

        public void Eat()
        {

        }
    }
}
