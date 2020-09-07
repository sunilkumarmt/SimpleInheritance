using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
     class University
    {
        public virtual void Method1() { }
        public virtual void Method2() { }

        public void Method3()
        {

        }
        
    }

   abstract  class MyClass : University
    {

        abstract public  void Method4();
        public override  void Method1()
        {
            
        }

        public override  void Method2()
        {
            
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            University u = new University();
            MyClass my = new MyClass();
        }
    }
}
