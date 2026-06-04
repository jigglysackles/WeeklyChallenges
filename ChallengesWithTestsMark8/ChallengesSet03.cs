using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8;

public class ChallengesSet03
{
    public bool ArrayContainsAFalse(bool[] vals)
    {
        bool containsFalse = false;
        foreach (bool val in vals)
        {
            if (val == false)
            {
                containsFalse = true;
            }
        }

        return containsFalse;
    }

    public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
    {
        if (numbers == null) return false;
        var sum = 0;
        foreach (var number in numbers)
        {
            if (number % 2 != 0)
            {
                sum += number;
            }
        }

        return (sum % 2 != 0) ? true : false;
    }

    public bool PasswordContainsUpperLowerAndNumber(string password)
    {
        var containsNumber = false;
        var containsUpper = false;
        var containsLower = false;

        var allChars = password.ToCharArray();
        for (int i = 0; i < allChars.Length; i++)
        {
            if (char.IsDigit(allChars[i]))
            {
                containsNumber = true;
            }

            if (char.IsUpper(allChars[i]))
            {
                containsUpper = true;
            }

            if (char.IsLower(allChars[i]))
            {
                containsLower = true;
            }
        }

        if (containsNumber && containsLower && containsUpper)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public char GetFirstLetterOfString(string val)
    {
        var allChars = val.ToCharArray();
        return allChars[0];
    }

    public char GetLastLetterOfString(string val)
    {
        var allChars = val.ToCharArray();
        var lengthofArray = allChars.Length;
        return allChars[lengthofArray - 1];
    }

    public decimal Divide(decimal dividend, decimal divisor)
    {
        return (divisor != 0) ? dividend / divisor : 0;
    }

    public int LastMinusFirst(int[] nums)
    {
        var lengthOfArray = nums.Length;
        var num1 = nums[lengthOfArray - 1];
        var num2 = nums[0];
        return num1 - num2;
    }

    public int[] GetOddsBelow100()
    {
        return Enumerable.Range(1, 99).Where(n => n % 2 != 0).ToArray();
    }

    public void ChangeAllElementsToUppercase(string[] words)
    {
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = words[i].ToUpper();
        }
    }
}