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

    /* Sphere class
1.	A sphere "is a" ThreeDShape
5.	Override the ToString() method inherited from ThreeDShape, 
     * make it display information about the sphere.
6.	Test the class. Call the method to calculate the volume of a sphere polymorphically. 
     * Display details of the sphere object.
     * Make a collection of spheres and call various methods on each sphere
 */
    
    public class Sphere : Shape
    {
        /* 2.	The class should have field to store the radius of the sphere, 
                and a read-write property corresponding to the field. 
                The radius must be always positive. */
        public double Radius
        {
            get;
            set;
        }

        /* 4.	Override the method to calculate the volume 
         * i.e. the volume of a sphere is PI * radius * radius * radius. */
        public override double Area
        {
            get
            {
                double PI = 3.14;
                return PI * Radius * Radius * Radius;
            }
        }

        // 3.	Implement appropriate constructors for the class.
        // Default Constructor
        public Sphere(String id, double radius)
            :base(id)
        {
            Radius = radius;
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

            Sphere sp = new Sphere("Sphere 1", 10);
            Console.WriteLine("The Shape Id is: " + sp.Id);
            Console.WriteLine("The volume of the area of " + sp.Id + " is " + sp.Area);
            Console.ReadLine();
        }
    }
}

