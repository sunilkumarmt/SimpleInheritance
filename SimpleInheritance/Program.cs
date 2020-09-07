using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Multilevel_Inheritance
{
    class Parent
    {

    }

    class Child : Parent
    {

    }

    class GrandChild : Child
    {
        public virtual string OverrideDemo()
        {
            return "inside GrandChild OverrideDemo method";
        }
    }

    class GreatGrandChild : GrandChild
    {
        public override string ToString()
        {
            return ("My Custom String");
        }

        public override string OverrideDemo()
        {
            return "inside GreatGrandChild:OverrideDemo";
        }
    }

    class Demo
    {
        public static void Main(string[] args)
        {
            GrandChild gC = new GrandChild();
            GreatGrandChild gGC = new GreatGrandChild();
            Console.WriteLine(gGC);
            Console.WriteLine(gC.OverrideDemo());//
            gC = gGC;
            Console.WriteLine(gC.OverrideDemo());//
            Console.ReadLine();
        }
    }
}
/*namespace Simple_Inheritance
{
    class DataBase1
    {

    }
    class DataBase
    {
        public int CommonField = 10;

        public DataBase()
        {

        }
        public DataBase(int test)
        {
        }


        public void CommonMethod()
        {
            Console.WriteLine("inside the base class common method");
        }
        public override string ToString()
        {
            return "overriding tostring";
        }
    }

    class SqlDatabase : DataBase
    {
        public void SpecificMethodSql()
        {
            Console.WriteLine("sql specific method");
        }
    }

    class OracleDatabase : DataBase
    {
        public void SpecificMethodOracle()
        {

            Console.WriteLine("Oracle specific method");
        }
    }
    class TestInheritance
    {
        public static void Main(string[] args)
        {

            OracleDatabase Odata = new OracleDatabase();
            SqlDatabase sData = new SqlDatabase();
            DataBase db1;
            db1 = sData;
            Console.WriteLine("common field:" + db1.CommonField);
            db1.CommonMethod();
            Odata.SpecificMethodOracle();
            SqlDatabase odata1 = (SqlDatabase)db1;
            Console.WriteLine(Odata);
            
            //SqlDatabase sData = new SqlDatabase();
            //sData.

            Console.ReadKey();
        }
    }*/


    // A simple class hierarchy. 



    // A class for two-dimensional objects. 
   /* class TwoDShape
    {
        public double Width;
        public double Height;

        public void ShowDim()
        {
            Console.WriteLine("Width and height are " +
                               Width + " and " + Height);
        }
    }

    // Triangle is derived from TwoDShape. 
    class Triangle : TwoDShape
    {
        public string Style; // style of triangle 

        // Return area of triangle. 
        public double Area()
        {
            return Width * Height / 2;
        }

        // Display a triangle's style. 
        public void ShowStyle()
        {
            Console.WriteLine("Triangle is " + Style);
            base.ShowDim();
        }
    }

    class Shapes
    {
        static void Main()
        {
            Triangle t1 = new Triangle();
            Triangle t2 = new Triangle();

            t1.Width = 4.0;
            t1.Height = 4.0;
            t1.Style = "isosceles";

            t2.Width = 8.0;
            t2.Height = 12.0;
            t2.Style = "right";

            Console.WriteLine("Info for t1: ");
            t1.ShowStyle();
            //t1.ShowDim(); 
            Console.WriteLine("Area is " + t1.Area());

            Console.WriteLine();

            Console.WriteLine("Info for t2: ");
            t2.ShowStyle();
            t2.ShowDim();
            Console.WriteLine("Area is " + t2.Area());
            Console.ReadKey();
        }
    }


}*///end of namespace
