using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8;

public class ChallengesSet05
{
    public int GetNextNumberDivisibleByN(int startNumber, int n)
    {
        startNumber++;
        if (n == 0) return 0;
        while (startNumber % n != 0) startNumber++;
        return startNumber;
    }

    public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
    {
        foreach (var business in businesses)
            if (business.TotalRevenue == 0)
                business.Name = "CLOSED";
    }

    public bool IsAscendingOrder(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0) return false;
        for (var i = 1; i < numbers.Length; i++)
            if (numbers[i] < numbers[i - 1])
                return false;

        return true;
    }

    public int SumElementsThatFollowAnEven(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0) return 0;
        var sum = 0;
        for (var i = 0; i < numbers.Length; i++)
            if (numbers[i] % 2 == 0)
                try
                {
                    sum += numbers[i + 1];
                }
                catch (IndexOutOfRangeException)
                {
                    return sum;
                }

        return sum;
    }

    public string TurnWordsIntoSentence(string[] words)
    {
        if (words == null || words.Length == 0) return string.Empty;

        var cleanedInput = words.Where(word => !string.IsNullOrWhiteSpace(word)).Select(word => word.Trim()).ToArray();

        if (cleanedInput.Length == 0) return string.Empty;

        return string.Join(" ", cleanedInput) + ".";
    }

    public double[] GetEveryFourthElement(List<double> elements)
    {
        if (elements == null || elements.Count == 0) return new double[] { };

        var everyFourthNumber = new List<double>();

        for (var i = 3; i < elements.Count; i += 4) everyFourthNumber.Add(elements[i]);
        return everyFourthNumber.ToArray();
    }

    public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
    {
        if (nums == null || targetNumber == null || nums.Length <= 1) return false;

        for (var i = 0; i < nums.Length - 1; i++)
        for (var q = i + 1; q < nums.Length; q++)
            if (nums[i] + nums[q] == targetNumber)
                return true;

        return false;
    }
}