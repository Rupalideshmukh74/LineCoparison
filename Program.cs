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
            Program.Checkequality();
        }
        public static double Distance(double x1, double x2, double y1, double y2)
        {
            var temp1 = Math.Pow((x2 - x1), 2);
            var temp2 = Math.Pow((y2 - y1), 2);
            var result = Math.Sqrt(temp1 + temp2);
            Console.WriteLine(result);
            return result;

        }
        public static void Checkequality()
        {
            double line1 = Distance(5, 6, 7, 5);
            double line2 = Distance(2, 8, 6, 12);

           
            Console.WriteLine(" Length of Line 1 : " + line1 + " \n");
            Console.WriteLine(" Length of Line 2 : " + line2 + " \n");

            
            Console.WriteLine("Length of Lines are Equal : " + line1.Equals(line2));
        }
        public static void Compare(double line1, double line2)
        {

            int linesCompare = (line1.CompareTo(line2));


            if (linesCompare.Equals(0))
                Console.WriteLine(" Result : Both the lines are having same length or both lines are equal.");
            else if (linesCompare.Equals(-1))
                Console.WriteLine(" Result : Length of FirstLine Is lesser Than secondLine");
            else
                Console.WriteLine(" Result : Length of FirstLine Is Greater Than secondLine");

        }






    }
}
