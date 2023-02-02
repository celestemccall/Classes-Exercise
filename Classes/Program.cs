namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Name = "Infiniti";
            myCar.Model = "G37";
            myCar.Year = 2009;

            Console.WriteLine($"My {myCar.Name} {myCar.Model} is a {myCar.Year}");
        }
    }
}
