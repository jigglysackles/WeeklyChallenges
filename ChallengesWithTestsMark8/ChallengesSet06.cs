using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ChallengesWithTestsMark8;

public class ChallengesSet06
{
    public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
    {
        if (string.IsNullOrEmpty(word) || words == null)
        {
            return false;
        }
        foreach (var item in words)
        {
            if (string.IsNullOrEmpty(item))
            {
                return false;
            }
            if (ignoreCase)
            {
                if (string.Equals(item, word, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            else
            {
                if (string.Equals(item, word, StringComparison.Ordinal))
                {
                    return true;
                }
            }
        }
        return false;
    }

    public bool IsPrimeNumber(int num)
    {
        if (num < 2)
        {
            return false;
        }

        if (num == 2)
        {
            return true;
        }

        if (num % 2 == 0)
        {
            return false;
        }

        int limit = (int)Math.Sqrt(num);

        for (int i = 3; i <= limit; i += 2)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    public int IndexOfLastUniqueLetter(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return -1;
        }
        int lastUniqueNumber = -1;
        
        for (int i = 0; i < str.Length; i++)
        {
            char c1 = str[i];
            var isUnique = true;
            for (int q = 0; q < str.Length; q++)
            {
                if (i == q)
                {
                    continue;
                }
                char c2 = str[q];
                if (c1 == c2)
                {
                    isUnique = false;
                    break;
                }
            }
            if (isUnique)
            {
                lastUniqueNumber = i;
            }
        }
        return lastUniqueNumber;
    }

    public int MaxConsecutiveCount(int[] numbers)
    {
        
        
        
    }

    public double[] GetEveryNthElement(List<double> elements, int n)
    {
        throw new NotImplementedException();
    }
}