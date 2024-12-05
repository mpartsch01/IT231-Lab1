namespace IT231_CSharp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            DoMath(3, 4);

        }

        public static void DoMath(int x, int y)
        {

            Console.WriteLine("Enter your first number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You've entered {x}");
            Console.WriteLine("Enter your second number: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You've entered {y}");
            Console.WriteLine("And the sum of these two numbers is: ");
            Console.Write(x + y);
        }
    }
}
