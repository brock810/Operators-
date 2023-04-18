using System.Reflection.Metadata;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
          {
        
      var a = 63;
      var b = 32;
      var quotient = a / b;
      var remainder = a % b;

      Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");
      Console.WriteLine("You should enter the radius of your circle");
      var userInput = Console.ReadLine(); 
      
      var radius = double.Parse(userInput);
      

      Console.WriteLine(AreaOfCircle(radius));
        
        }

     public static double AreaOfCircle(double radius)
    {
            
       var area = Math.PI * Math.Pow(radius, 2);
       return area;

        }

    }

}
