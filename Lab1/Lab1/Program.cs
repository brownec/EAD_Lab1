// Cliff Browne - X00014810
// C# Lab1
using System;
/* You are required to design and develop a program in C# which stores 
and calculates information about 3D shapes. 
The program will be made up of several classes: 
ThreeDShape class
 
5.	Override the ToString() method inherited from System.Object, 
make it display information about the shape.
6.	Test the class. Try to create instances of the class and call methods.
 */
namespace cSharpLab1
{
    // 1.	Implement an abstract class Shape
    public abstract class Shape
    {
        public String Id
        {
            get;
            set;
        }

        /* 4.	Implement an abstract method which calculates 
        the volume of the shape. */
        public abstract double Area
        {
            get;
        }

        // 3.	Implement appropriate constructors for the class.
        // Constructor
        protected Shape(String Id)
        {
            this.Id = Id;
        }
    }

    /* 2.	The class should have a field which stores the type 
     * of the shape (e.g. sphere, cylinder, cone etc.), 
    and a public read-only property corresponding to this field.*/
    public class Square : Shape
    {
        public double Side
        {
            get;
            set;
        }

        public override double Area
        {
            get
            {
                return Side * Side;
            }
        }

        // Default Constructor
        public Square(String id, double side)
            : base(id)
        {
            Side = side;
        }
    }
    public class Test
    {
        static void Main()
        {
            Square s = new Square("Square 1", 15);
            Console.WriteLine("C# Lab1 - Abstract Property. Cliff Browne X00014810");
            Console.WriteLine();
            Console.WriteLine("The Shape Id is: " + s.Id);
            Console.WriteLine("The volume of the area of " + s.Id + " is " + s.Area);
            Console.ReadLine();
        }
    }
}

