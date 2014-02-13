
namespace FizzBuzzConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintFizz();

            PrintBuzz();

            PrintFizzBuzz();
        }

        private static void PrintFizz()
        {
            var printFizz = new string[100];
            var fizzBuzz = new FizzBuzzLogic(0, 100, ref printFizz);

            printFizz = fizzBuzz.Run(FizzBuzzLogic.PrintOptions.Fizz, printFizz);
            for (int i = 0; i < printFizz.Length; i++)
            {
                System.Console.WriteLine(printFizz[i]);
            }
            System.Console.ReadKey();
        }

        private static void PrintBuzz()
        {
            var printFizz = new string[100];
            var fizzBuzz = new FizzBuzzLogic(0, 100, ref printFizz);

            printFizz = fizzBuzz.Run(FizzBuzzLogic.PrintOptions.Buzz, printFizz);
            for (int i = 0; i < printFizz.Length; i++)
            {
                System.Console.WriteLine(printFizz[i]);
            }
            System.Console.ReadKey();
        }

        private static void PrintFizzBuzz()
        {
            var printFizz = new string[100];
            var fizzBuzz = new FizzBuzzLogic(0, 100, ref printFizz);

            printFizz = fizzBuzz.Run(FizzBuzzLogic.PrintOptions.FizzBuzz, printFizz);
            for (int i = 0; i < printFizz.Length; i++)
            {
                System.Console.WriteLine(printFizz[i]);
            }
            System.Console.ReadKey();
        }
    }
}
