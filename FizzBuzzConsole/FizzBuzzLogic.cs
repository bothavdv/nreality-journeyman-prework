using System;

namespace FizzBuzzConsole
{
    public class FizzBuzzLogic
    {
        public enum PrintOptions
        {
            Fizz,
            Buzz,
            FizzBuzz
        };

        public FizzBuzzLogic(int startPosition, int endPosition, ref string[] dataToPrint)
        {
            if (!(startPosition > -1 && endPosition < 101))
            {
                throw new ArgumentOutOfRangeException("Boundaries out of limit");
            }

            dataToPrint = new string[endPosition];
            for (var i = startPosition; i < dataToPrint.Length; i++)
            {
                dataToPrint[i] = (i + 1).ToString();
            }
        }

        public string[] Run(PrintOptions option, string[] dataToPrint)
        {
            switch (option)
            {
                case PrintOptions.Fizz:
                    return PrintFizz(dataToPrint);
                case PrintOptions.Buzz:
                    return PrintBuzz(dataToPrint);
                case PrintOptions.FizzBuzz:
                    return PrintFizzBuzz(dataToPrint);
                default:
                    throw new ArgumentOutOfRangeException("option");
            }
        }

        private string[] PrintFizz(string[] dataToPrint)
        {
            for (var i = 0; i < dataToPrint.Length; i++)
            {
                var canDivideByThree = CanDivideByNumber(3, long.Parse(dataToPrint[i]));
                if (canDivideByThree)
                {
                    dataToPrint[i] = PrintOptions.Fizz.ToString();
                }
            }
            return dataToPrint;
        }

        private string[] PrintBuzz(string[] dataToPrint)
        {
            for (var i = 0; i < dataToPrint.Length; i++)
            {
                var canDivideByFive = CanDivideByNumber(5, long.Parse(dataToPrint[i]));
                if (canDivideByFive)
                {
                    dataToPrint[i] = PrintOptions.Buzz.ToString();
                }
            }
            return dataToPrint;
        }

        private string[] PrintFizzBuzz(string[] dataToPrint)
        {
            for (var i = 0; i < dataToPrint.Length; i++)
            {
                var canDivideByThree = CanDivideByNumber(3, long.Parse(dataToPrint[i]));

                var canDivideByFive = CanDivideByNumber(5, long.Parse(dataToPrint[i]));

                if (canDivideByThree && canDivideByFive)
                {
                    dataToPrint[i] = PrintOptions.FizzBuzz.ToString();
                }
                else if (canDivideByThree)
                {
                    dataToPrint[i] = PrintOptions.Fizz.ToString();
                }
                else if (canDivideByFive)
                {
                    dataToPrint[i] = PrintOptions.Buzz.ToString();
                }
            }
            return dataToPrint;
        }

        private bool CanDivideByNumber(long divideByNumber, long numberToDivideOn)
        {
            long remainder;
            Math.DivRem(numberToDivideOn, divideByNumber, out remainder);
            return remainder == 0;
        }
    }
}
