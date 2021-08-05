using System;

namespace LineComparisonProblem
{
    class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("Please enter x1 and y1 coordinates: ");
            var x1 = Convert.ToDouble(Console.ReadLine());
            var y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter x2 and y2 coordinates: ");
            var x2 = Convert.ToDouble(Console.ReadLine());
            var y2 = Convert.ToDouble(Console.ReadLine());
            
            Program.Distance(x1,x2,y1,y2);
            
        }
        public static void Distance(double x1, double x2, double y1, double y2)
        {
            var temp1 = Math.Pow((x2 - x1), 2);
            var temp2 = Math.Pow((y2 - y1), 2);
            var result = Math.Sqrt(temp1 + temp2);
            Console.WriteLine(result); 


        }

        

           

          
    }
}
