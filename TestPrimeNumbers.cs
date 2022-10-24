using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TDD_Find_Prime_Numbers_Lab_JT
{
    public class TestPrimeNumbers
    {
        List<int> empty = new List<int>();
        Prime_Numbers prime = new Prime_Numbers();

        [Fact]
        public void testtest() //clear
        {
        }

        [Fact]
        public void IfInputIsZero_ResultIsZero() //clear
        {
            // Arrange - Setup the values for the function
            var Zero = 0;

            // Act - Perform an operation
            var result = prime.ListPrimes(Zero);

            // Assert - Check for validity
            Assert.True(empty.Count == result.Count && empty.Count == 0);
        }


        [Fact]
        public void IfInputIsOne_ResultIsEmpty()
        {
            // Arrange - Setup the values for the function
            var One = 1;

            // Act - Perform an operation
            var result = prime.ListPrimes(One);

            // Assert - Check for validity
            Assert.True(empty.Count.Equals(result.Count) && empty.Count is 0);
        }

        [Fact] //before this fact,the text explorer works fine.
        public void GivenAValueOfThree_TheExpectedResultIsAListContainingOnlyTwoAndThree()
        {
            var Three = 3;

            var result = prime.GetPrime(Three);

            Assert.True(result[0] is 2 && result[1] is 3); //how to determine if the result at the specific index matches or not?
        }

            [Fact]
        public void IfPrimeNumbersUpTo31()
        { 
 
            var value = 31;

            bool result = prime.GetPrime(value);

            Assert.True(result[0] is 2 && //if the result is equal to the following numbers up to the tenth prime# (31), it is prime.
                result[1] is 3 &&
                result[2] is 5 &&
                result[3] is 7 &&
                result[4] is 11 &&
                result[5] is 13 &&
                result[6] is 17 &&
                result[7] is 19 &&
                result[8] is 23 &&
                result[9] is 29 &&
                result[10] is 31); //?? how to write/format this so it works? 
            
           /* (from i in Enumerable.Range(0, oldValues.Length)
             where !oldValues[i] && newValues[i]
             select i).ToList();*/ //????



        }
    }
}
