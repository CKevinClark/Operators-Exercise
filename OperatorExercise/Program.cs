using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int sum = a + b;
            int sub = a - b;
            int mult = b * a;

            double quotient = a / b;
            double remainder = a % b;

            Console.WriteLine($"17 plus 4 = {sum}, 17 minus 4 = {sub}, 4 times 17 equals {quotient}. \n 17 divided by 4 equals {quotient}, 17 divided by 4 has a rounded remainder of {remainder}");

            double radius = double.Parse(Console.ReadLine());

            AreaOfCircle(radius);
        }
       static double AreaOfCircle(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            
            Console.WriteLine($"The Area of the Circle with Radius {radius} is equal to: {area}");
            return area;
        }
    }
    
}

