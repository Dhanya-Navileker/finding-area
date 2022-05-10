using System.IO;
using System;
interface IPolygon
{
    public void area();
}
class Input
{
  public int side1;
  public int side2;
  public int side3;
}
    class Square:Input
    {
    public void area()
    { 
    //public void DisplayOfSquare()
         Console.WriteLine("Length of the side:");
        this.side1=Convert.ToInt32(Console.ReadLine());
        double res=side1*side1;
        Console.WriteLine("Area of Square "+ res);
    }
    }
    class Rectangle:Input
    {
    public void area()
    { 
        
         Console.WriteLine("Length of the Rectangle:");
         Console.WriteLine("Breadth of the Rectangle:");
        this.side1=Convert.ToInt32(Console.ReadLine());
        this.side2=Convert.ToInt32(Console.ReadLine());
        double res=side1*side2;
        Console.WriteLine("Area of rectangle "+res);
    }
    }
    class Triangle:Input
    {
    public void area()
    { 
        Console.WriteLine("Length of the side:");
        this.side1=Convert.ToInt32(Console.ReadLine());
        this.side2=Convert.ToInt32(Console.ReadLine());
        this.side3=Convert.ToInt32(Console.ReadLine());
        double perimeter= (side1+side2+side3)/2;
        double Area=perimeter*(perimeter-side1)*(perimeter-side2)*(perimeter-side3);
        double res=Math.Sqrt(Math.Abs(Area));
          Console.WriteLine("Area of Triangle "+res);
    }
}
class ExecuteSqaure
{
    static void Main(string[] args)
    {
        Input a1=new Input();
        Square b1=new Square();
        Rectangle r1=new Rectangle();
        Triangle t1=new Triangle();
        Console.WriteLine("Enter the no of sides:");
        int n=Convert.ToInt32(Console.ReadLine());
     
      switch(n)
      {
       case 3:
        {
           t1.area();
            break;
        }
        case 4:
        {
            Console.WriteLine("what type of polygon it is ?");
            string value1=Console.ReadLine();
            string value=value1.ToLower();
            switch(value)
            {
                case"rectangle":
                {
                    r1.area();
                    break;
                }
                case"square":
                {
                   b1.area();
                break;
                }
                default:
                {
                    Console.WriteLine("Enter valid shape name");
                     break;
                }
            }
            break;
        }
        default: 
        {
            Console.WriteLine("Number of sides is less than 2 or more than 5");
            break;
        }
    }
      
        Console.ReadLine();
}
}
    
