using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8;

public class ChallengesSet02
{
    public bool CharacterIsALetter(char c)
    {
        if (!char.TryParse(c.ToString(), out var c1)) return true;

        return false;
    }

    public bool CountOfElementsIsEven(string[] vals)
    {
        if (vals.Length % 2 == 0) return true;

        return false;
    }

    public bool IsNumberEven(int number)
    {
        if (number % 2 == 0) return true;

        return false;
    }

    public bool IsNumberOdd(int num)
    {
        if (num % 2 != 0) return true;

        return false;
    }

    public double SumOfMinAndMax(IEnumerable<double> numbers)
    {
        // var convertedValues = numbers.ToArray();
        // var min = convertedValues.Min();
        // var max =  convertedValues.Max();

        var min = numbers.Min();
        var max = numbers.Max();

        return min + max;
    }

    public int GetLengthOfShortestString(string str1, string str2)
    {
        var countStr1 = str1.Length;
        var countStr2 = str2.Length;
        if (countStr1 < countStr2) return countStr1;

        return countStr2;
    }

    public int Sum(int[] numbers)
    {
        var sum = 0;
        foreach (var number in numbers) sum += number;
        return sum;
    }

    public int SumEvens(int[] numbers)
    {
        var evenSum = 0;
        foreach (var number in numbers)
            if (number % 2 == 0)
                evenSum += number;

        return evenSum;
    }

    public bool IsSumOdd(List<int> numbers)
    {
        foreach (var number in numbers)
            if (number % 2 == 0)
                return false;

        return true;
    }

    public long CountOfPositiveOddsBelowNumber(long number)
    {
        var count = 0;
        for (var i = 1; i < number; i++)
            if (i % 2 != 0)
                count++;

        return count;
    }
}