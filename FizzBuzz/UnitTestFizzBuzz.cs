
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz
{
    [TestClass]
    public class UnitTestFizzBuzz
    {
        readonly string[] _dataToPrint = new string[100];

        [TestInitialize]
        public void SetupNumericNumbersOneToOnehundred()
        {          
            for (var i = 0; i < _dataToPrint.Length; i++)
            {
                _dataToPrint[i] = (i + 1).ToString();
            }
        }
       
        [TestMethod]
        public void ShouldPrintFizzForMultiplesOfThree()
        {
            //given
            var dataToPrint = _dataToPrint;
            //when 
            for (var i = 0; i < dataToPrint.Length; i++)
            {
                var canDivideByThree = CanDivideByNumber(3, long.Parse(dataToPrint[i]));
                if (canDivideByThree)
                {
                    dataToPrint[i] = "Fizz";    
                }
            }
            //then
            Assert.AreEqual("Fizz",dataToPrint[98]);
        }
        
        [TestMethod]
        public void ShouldPrintBuzzForMultiplesOfFive()
        {
            //given
            var dataToPrint = _dataToPrint;
            //when 
            for (var i = 0; i < dataToPrint.Length; i++)
            {
                var canDivideByFive = CanDivideByNumber(5, long.Parse(dataToPrint[i]));
                if (canDivideByFive)
                {
                    dataToPrint[i] = "Buzz";
                }
            }
            //then
            Assert.AreEqual("Buzz", dataToPrint[99]);
        }

        [TestMethod]
        public void ShouldPrintFizzBuzzForMultiplesOfThreeAndFive()
        {
            //given
            var dataToPrint = _dataToPrint;
            //when 
            for (var i = 0; i < dataToPrint.Length; i++)
            {
                var canDivideByThree = CanDivideByNumber(3, long.Parse(dataToPrint[i]));
                var canDivideByFive = CanDivideByNumber(5, long.Parse(dataToPrint[i]));
                if (canDivideByThree && canDivideByFive)
                {
                    dataToPrint[i] = "FizzBuzz";
                }
            }
            //then
            Assert.AreEqual("FizzBuzz", dataToPrint[29]);
        }

        [TestMethod]
        public void ShouldPrintAllFizzBuzzCombinations()
        {
            //given
            var dataToPrint = _dataToPrint;
            //when 
            for (var i = 0; i < dataToPrint.Length; i++)
            {
                var canDivideByThree = CanDivideByNumber(3, long.Parse(dataToPrint[i]));
               
                var canDivideByFive = CanDivideByNumber(5, long.Parse(dataToPrint[i]));
               
                if (canDivideByThree && canDivideByFive)
                {
                    dataToPrint[i] = "FizzBuzz";
                }
                else if (canDivideByThree)
                {
                    dataToPrint[i] = "Fizz";
                }
                else if (canDivideByFive)
                {
                    dataToPrint[i] = "Buzz";
                }
            }
            //then
            Assert.AreEqual("Fizz", dataToPrint[98]);
            Assert.AreEqual("Buzz", dataToPrint[99]);
            Assert.AreEqual("FizzBuzz", dataToPrint[29]);
        }

        public bool CanDivideByNumber(long divideByNumber, long numberToDivideOn)
        {
            long remainder;
            Math.DivRem(numberToDivideOn, divideByNumber, out remainder);
            return remainder == 0;
        }

    }
}
