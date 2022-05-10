using System;
namespace CsharpInterface {

  interface IPolygon {

    void calculateArea();

  }   

  class Rectangle : IPolygon {

    
    public void calculateArea() {
                Console.WriteLine("Length of the Rectangle:");
                double l=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Breadth of the Rectangle:");
                double  b=Convert.ToInt32(Console.ReadLine());

                double area = l * b;
      Console.WriteLine("Area of Rectangle: " + area);
    }
  }
   class Triangle : IPolygon {
        public void calculateArea()
        {
            Console.WriteLine("Length of 1st side:");
            double a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Length of 2nd side:");
            double b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Length of 3rd side:");
            double c=Convert.ToInt32(Console.ReadLine());
        
            double perimeter= (a+b+c)/2;
            double Area=perimeter*(perimeter-a)*(perimeter-b)*(perimeter-c);
     
        
            double area= Math.Sqrt(Math.Abs(Area));
            Console.WriteLine("Area of Triangle "+ area);
        }
   }  
  

  class Square : IPolygon {

    public void calculateArea() {
      
        Console.WriteLine("Length of the side:");
        double l    =Convert.ToInt32(Console.ReadLine());
    
        double area = l * l;
        Console.WriteLine("Area of Square: " + area);
    }
  }

  class PArea {
    static void Main (string [] args) {
        Console.WriteLine("Enter the no of sides:");
        int numberOfSidesOfPolygon=Convert.ToInt32(Console.ReadLine());
        IPolygon ipolygon;
     
      switch(numberOfSidesOfPolygon)
      {
      case 3:
        {
            Console.WriteLine("Enter the  sides of the triangle:  ");
            Triangle t1= new Triangle();
            ipolygon=(IPolygon)t1;
           // t1.calculateArea();
            break;
        }
        case 4:
        {
            Console.WriteLine("Enter Square or Rectangle" );
            string value1=Console.ReadLine();
            string value= value1.ToLower();
            // Console.WriteLine(value.Contains(value.ToLower()));
            switch(value)
            {
                case "square":
                {
                    Square s1 = new Square(); 
                    ipolygon=(IPolygon)s1;
                   // s1.calculateArea();
                  break;
                } 
                case "rectangle":
                case "rect":
                {
                    Rectangle r1 = new Rectangle();  
                   ipolygon=(IPolygon)r1;
                  break;
                }
                default:
                {
                    ipolygon=null;
                    Console.WriteLine("Enter proper polygon name");
                    break;
                }
                
            }
            break;
            
        }
        default: 
        {
              ipolygon=null;
            Console.WriteLine("Number of sides are less than 2 or more than 5");
            break;
        }
        
        
        
      }  
      ipolygon.calculateArea();
        
        
        


    }
  }
}