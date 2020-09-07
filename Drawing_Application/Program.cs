using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Drawing_Application
{
    class Shape
    {
        public virtual void Draw()
        {
            //...
            Console.WriteLine("base class draw method");
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            
            Console.WriteLine("drawing a Circle");
            
        }
    }

    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("drawing a Triangle");
            
        }
    }

    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("drawing a Rectangle");
           
        }
    }

     class Square : Shape
    {
        public  sealed override void Draw()
        {
            Console.WriteLine("drawing a Square");
            base.Draw();
        }
    }

    class MySquare : Square
    {
        /*public override void Draw()
        {

        }*/
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Shape s=null;
            var drawObjects = new List<Shape>
            {
                new Rectangle(),
                new Triangle(),
                new Square(),
                new Circle()

             };
            int ui;

            do
            {
                Console.WriteLine("Choose an option to draw the shapes");
                Console.WriteLine("1: Rectangle");
                Console.WriteLine("2: Triangle");
                Console.WriteLine("3: Square");
                Console.WriteLine("4: Circle");
                Console.WriteLine("5: Exit");
                Console.WriteLine("Enter your input");

                ui = Convert.ToInt32(Console.ReadLine());

                switch (ui)
                {
                    case 1:
                        //s = new Rectangle();
                        drawObjects[0].Draw();
                        break;
                    case 2:
                        //s = new Triangle();
                        drawObjects[1].Draw();
                        break;
                    case 3:
                        s = new Square();
                        break;
                    case 4:
                        s = new Circle();
                        break;
                    /*case 5:
                        break;*/
                    default:
                        Console.WriteLine("wrong option exiting the app");
                        Environment.Exit(0);
                        break;


                }
                //drawing the selected shape
                s.Draw();
                

            } while (ui >= 1 && ui <= 4);

            /*var drawObjects = new List<Shape>
            {
                new Rectangle(),
                new Circle(),
                 new Triangle(),
                 new Square()

             };

            foreach(Shape s in drawObjects )
            {
                s.Draw();
            }*/
            Console.ReadLine();
        }
    }
}
