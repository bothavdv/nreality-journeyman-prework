using System;
using FizzBuzzConsole;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz
{
    [TestClass]
    public class UnitTestFizzBuzz
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ShouldSetupOnlyWithinUpperBoundaryOfOnehundred()
        {
            //given an invalid setup above upper boundry
            var dataToPrint = new string[100];
            var fizzBuzz = new FizzBuzzLogic(4, 106, ref dataToPrint);
            //when configuring the boundaries
            //then an exception is expected
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ShouldSetupOnlyWithinLowerBoundaryOfZero()
        {
            //given an invalid setup below lower boundry
            var dataToPrint = new string[100];
            var fizzBuzz = new FizzBuzzLogic(-2, 55, ref dataToPrint);
            //when configuring the boundaries
            //then an exception is expected
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ShouldSetupOnlyWithinLowerAndUpperBoundariesOfZeroToOnehundred()
        {
            //given an invalid setup below lower boundry and above upper boundry
            var dataToPrint = new string[100];
            var fizzBuzz = new FizzBuzzLogic(-5, 105, ref dataToPrint);
            //when configuring the boundaries
            //then an exception is expected
        }

        [TestMethod]
        public void ShouldPrintFizzForMultiplesOfThree()
        {
            //given a valid setup of program
            var dataToPrint = new string[100];
            var fizzBuzz = new FizzBuzzLogic(0, 100, ref dataToPrint);
            //when run with the print buzz option
            dataToPrint = fizzBuzz.Run(FizzBuzzLogic.PrintOptions.Fizz, dataToPrint);
            //then i expect buzz in every third position
            Assert.AreEqual(FizzBuzzLogic.PrintOptions.Fizz.ToString(), dataToPrint[98]);
        }

        [TestMethod]
        public void ShouldPrintBuzzForMultiplesOfFive()
        {
            //given a valid setup of program
            var dataToPrint = new string[100];
            var fizzBuzz = new FizzBuzzLogic(0, 100, ref dataToPrint);
            //when run with the print buzz option
            dataToPrint = fizzBuzz.Run(FizzBuzzLogic.PrintOptions.Buzz, dataToPrint);
            //then i expect buzz in every five position
            Assert.AreEqual(FizzBuzzLogic.PrintOptions.Buzz.ToString(), dataToPrint[99]);
        }

        [TestMethod]
        public void ShouldPrintFizzBuzzForMultiplesOfThreeAndFive()
        {
            //given a valid setup of program
            var dataToPrint = new string[100];
            var fizzBuzz = new FizzBuzzLogic(0, 100, ref dataToPrint);
            //when run with the print buzz option
            dataToPrint = fizzBuzz.Run(FizzBuzzLogic.PrintOptions.FizzBuzz, dataToPrint);
            //then i expect buzz in every five position
            Assert.AreEqual(FizzBuzzLogic.PrintOptions.FizzBuzz.ToString(), dataToPrint[29]);
        }
    }

    
}
