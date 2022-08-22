using System;

namespace extrabasic
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("enter buy price");
            int cost = int.Parse(Console.ReadLine());
            Console.WriteLine("enter by item");
            int item = int.Parse(Console.ReadLine());
            Console.WriteLine("enter buy profit");
            int profit_per = int.Parse(Console.ReadLine());
            double selling = ((cost * profit_per / 100.0) + cost);
            Console.WriteLine("selling price =" + selling);





            Console.WriteLine("enter the 1st number");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the 2nd number");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("addition =" + (A + B));





            Console.WriteLine("enter the cube number");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine("cube =" + z * z * z);





            Console.WriteLine("enter the wid number");
            int wid = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the length");
            int len = int.Parse(Console.ReadLine());
            Console.WriteLine("area of rectangle =" + (wid * len));




            Console.WriteLine("enter the 1st sub mark");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the 2nd sub mark");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the 3rd sub mark");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the 4th sub mark");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the 5th sub mark");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine("average = " + (a + b + c + d + e) / 5);
            double avg = ((a + b + c + d + e) / 5);




            Console.WriteLine("enter the radius");
            double r = int.Parse(Console.ReadLine());
            double pi = 3.14;
            double area = ((2 / 3) * pi * (r * r));
            double volume = (4 / 3) * pi * (r * r * r);
            double per = 2 * pi * r;
            Console.WriteLine("area of spear is " + (area));
            Console.WriteLine("Volume of sphere is " + volume);
            Console.WriteLine("Perimeter of sphere is " + per);
            Console.ReadLine();

            Console.WriteLine("enter the 1st number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the 2nd number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("addition =" + 10 * 10);

          
            




            
            

           
        }

    }
}
