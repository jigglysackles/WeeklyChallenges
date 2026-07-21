using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8;

public class ChallengesSet06
{
    public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
    {
        if (string.IsNullOrEmpty(word) || words == null) return false;
        foreach (var item in words)
        {
            if (string.IsNullOrEmpty(item)) return false;
            if (ignoreCase)
            {
                if (string.Equals(item, word, StringComparison.OrdinalIgnoreCase)) return true;
            }
            else
            {
                if (string.Equals(item, word, StringComparison.Ordinal)) return true;
            }
        }

        return false;
    }

    public bool IsPrimeNumber(int num)
    {
        if (num < 2) return false;

        if (num == 2) return true;

        if (num % 2 == 0) return false;

        var limit = (int)Math.Sqrt(num);

        for (var i = 3; i <= limit; i += 2)
            if (num % i == 0)
                return false;

        return true;
    }

    public int IndexOfLastUniqueLetter(string str)
    {
        if (string.IsNullOrEmpty(str)) return -1;
        var lastUniqueNumber = -1;

        for (var i = 0; i < str.Length; i++)
        {
            var c1 = str[i];
            var isUnique = true;
            for (var q = 0; q < str.Length; q++)
            {
                if (i == q) continue;
                var c2 = str[q];
                if (c1 == c2)
                {
                    isUnique = false;
                    break;
                }
            }

            if (isUnique) lastUniqueNumber = i;
        }

        return lastUniqueNumber;
    }

    public int MaxConsecutiveCount(int[] numbers)
    {
        var consecutive = 0;
        if (numbers == null || numbers.Length == 0) return 0;
        var currentCount = 1;
        var maxCount = 0;

        for (var i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] == numbers[i - 1])
                currentCount++;
            else
                currentCount = 1;
            if (currentCount > maxCount) maxCount = currentCount;
        }

        return maxCount;
    }

    public double[] GetEveryNthElement(List<double> elements, int n)
    {
        if (elements == null || elements.Count <= 0 || n < 1 || n == null) return new double[] { };

        var everyNthNumber = new List<double>();

        for (var i = n - 1; i < elements.Count; i += n) everyNthNumber.Add(elements[i]);

        return everyNthNumber.ToArray();
    }
}