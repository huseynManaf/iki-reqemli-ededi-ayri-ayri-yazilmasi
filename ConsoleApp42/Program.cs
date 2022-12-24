namespace ConsoleApp42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iki reqemli eded daxil edin");
            string input = Console.ReadLine();
            if (input.Length < 2 || input.Length > 2) 
            {
                Console.WriteLine("Eded iki reqemli deyil");
                return;
            }
            int number = int.Parse(input);
            int LastDigit = number % 10;
            number /= 10;
            Console.WriteLine($"{ number} {LastDigit}");


        }
    }
}