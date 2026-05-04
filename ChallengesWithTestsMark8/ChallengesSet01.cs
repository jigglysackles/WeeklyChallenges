using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            var YayNay = (num1 == num2) ? true : false;
            return YayNay;
            // if(num1 == num2)
            // {
            //     return true;
            // }
            // else
            // {
            //     return false;
            // }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            var val = minuend - subtrahend;
            return val;
        }

        public int Add(int number1, int number2)
        {
            var val  = number1 + number2;
            return val;
        }

        public int GetSmallestNumber(int number1, int number2)
        { 
            var val = (number1 < number2) ? number1 : number2;
            return val;
        }

        public long Multiply(long factor1, long factor2)
        {
            var val = (factor1 * factor2);
            return val;
        }

        public string GetGreeting(string nameOfPerson)
        {
            var greet = $"Hello {nameOfPerson}!";
            return greet;
        }

        public string GetHey()
        {
            var hey = "Hey";
            return hey;
        }
    }
}
