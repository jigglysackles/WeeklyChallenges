using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8;

public class ChallengesSet04
{
    public int AddEvenSubtractOdd(int[] numbers)
    {
        var evenUp = numbers.Where(n => n % 2 == 0).ToList();
        var oddDown = numbers.Where(n => n % 2 != 0).ToList();
        var sum = evenUp.Sum() - oddDown.Sum();
        return sum;
    }

    public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
    {
        var compiled = new List<string> { str1, str2, str3, str4 };
        return compiled.Min(s => s.Length);
    }

    public int GetSmallestNumber(int number1, int number2, int number3, int number4)
    {
        var smallestNumber = new List<int> { number1, number2, number3, number4 };
        return smallestNumber.Min();
    }

    public void ChangeBusinessNameTo_TrueCoders(Business biz)
    {
        biz.Name = "TrueCoders";
    }

    public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
    {
        if (sideLength1 + sideLength2 > sideLength3 && sideLength2 + sideLength3 > sideLength1 &&
            sideLength1 + sideLength3 > sideLength2) return true;

        return false;
    }

    public bool IsStringANumber(string input)
    {
        if (double.TryParse(input, out var number)) return true;
        return false;
    }

    public bool MajorityOfElementsInArrayAreNull(object[] objs)
    {
        var nullCount = 0;
        var objCount = 0;
        foreach (var obj in objs)
            if (obj == null)
                nullCount++;
            else
                objCount++;

        if (nullCount - objCount > 0) return true;


        return false;
    }

    public double AverageEvens(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0) return 0;

        double evenCount = 0;
        double evenDivisor = 0;
        foreach (double number in numbers)
            if (number % 2 == 0)
            {
                evenCount += number;
                evenDivisor++;
            }

        return evenDivisor ! > 0 ? evenCount / evenDivisor : 0;
    }

    public int Factorial(int number)
    {
        if (number < 0) throw new ArgumentOutOfRangeException();
        if (number == 0) return 1;
        return number * Factorial(number - 1);
    }
}