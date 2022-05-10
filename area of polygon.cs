using System.IO;
using System;


class Polygon 
{
    int side1;
    int side2;
    int side3;
   
    public void number()
    {
        Console.WriteLine("Enter the no of sides:");
        int n=Convert.ToInt32(Console.ReadLine());
     
      switch(n)
      {
       case 3:
        {
            DisplayOfTriangle();
            GetareaOfTriangle();
            break;
        }
        case 4:
        {
            Console.WriteLine("Enter Square or Rectangle" );
            string value1=Console.ReadLine();
            string value= value1.ToLower();
            // Console.WriteLine(value.Contains(value.ToLower()));
            switch(value1)
            {
                case "square":
                {
                  DisplayOfSquare();
                  GetareaOfSquare();
                  break;
                } 
                case "rectangle":
                case "rect":
                {
                  DisplayOfRect();
                  GetareaOfRect();
                  break;
                }
                default:
                {
                    Console.WriteLine("Enter proper polygon name");
                    break;
                }
                
            }
            break;
            
        }
        default: 
        {
            Console.WriteLine("Number of sides are less than 2 or more than 5");
            break;
        }
      }
    }
    
    
  
    public double GetareaOfSquare()
    { 
        return side1*side1;
    }
    public void DisplayOfSquare()
    {
         Console.WriteLine("Length of the side:");
        this.side1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Area of Square "+ GetareaOfSquare());
    }
   
        
    
    
    public double GetareaOfRect()
    { 
        return side1*side2;
    }
    public void DisplayOfRect()
    {
         Console.WriteLine("Length of the Rectangle:");
         this.side1=Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Breadth of the Rectangle:");
        this.side2=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Area of rectangle "+ GetareaOfRect());
    }
    
    
    
    
   
    public  double GetareaOfTriangle()
    { 
        double perimeter= (side1+side2+side3)/2;
        double Area=perimeter*(perimeter-side1)*(perimeter-side2)*(perimeter-side3);
      //  Console.WriteLine(Math.Abs(Area));
        
        return Math.Sqrt(Math.Abs(Area));
    }
    public void DisplayOfTriangle()
    {
        Console.WriteLine("Length of 1st side:");
        this.side1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Length of 2nd side:");
        this.side2=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Length of 3rd side:");
        this.side3=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Area of Triangle "+ GetareaOfTriangle());
    }
    
}
class ExecuteSqaure
{
    static void Main(string[] args)
    {
        Polygon a1=new Polygon();
        a1.number();
        Console.ReadLine();
    }

}
    