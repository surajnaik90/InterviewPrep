using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.AbstractClasses
{   
    public abstract class AbstractTest
    {
        int num;
        public AbstractTest(int number)
        {
            num = number;
        }
        public abstract void Fun();

        public void display()
        {
            Console.WriteLine("I am inside AbstractTest class");
        }

    }

    public class AbstractTestClass : AbstractTest
    {
        public AbstractTestClass(int number) : base(number)
        {
        }

        public override void Fun()
        {
            Console.WriteLine("I am in AbstractTestClass");
        }

        public void display()
        {
            Console.WriteLine("I am inside AbstractTestClass");
        }
    }
}