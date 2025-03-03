using System;

class Program
{
   
    static int CalculateRectangleArea(int width, int length)
    {
        return width * length;
    }

    static void Main()
    {
        
         
        int width = int.Parse(Console.ReadLine());

         
        int length = int.Parse(Console.ReadLine());

         
        int area = CalculateRectangleArea(width, length);

       
        Console.WriteLine($"{area}");
    }
}
