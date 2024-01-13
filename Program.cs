using System.Globalization;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var location = "Rexburg, Idaho";
            var name = "Joseph Gregory";
            Console.WriteLine("My name is: " + name);
            Console.WriteLine("I currently live in : " + location);
            var today = DateOnly.FromDateTime(DateTime.Now);
            var christmas = DateOnly.Parse("December 25 2024", CultureInfo.InvariantCulture);
            var daystillmas = christmas.DayNumber - today.DayNumber;
            Console.WriteLine(today);
            Console.WriteLine("days till christmas: " + daystillmas);
            Console.WriteLine("Hello World!");
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.WriteLine("Enter the width:");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("Enter the height:");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");
            Console.ReadKey();

        }
    }
}