using System;

namespace CheckDivisibilityOfNumbersApp
{
    public class DivisibleByThree : DivisibleByNumber
    {

        public const long DIVIDER = 3;
        
        public Boolean isDivisible(int number)
        {
            return number % DIVIDER == 0;
        }
    }
}